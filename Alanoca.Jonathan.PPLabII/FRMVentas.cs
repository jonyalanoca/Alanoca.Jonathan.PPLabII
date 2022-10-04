using Entidades;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_tp1
{
    public partial class FRMVentas : Form
    {
        private Usuario usuario;
        private int tiempo = 0;
        private Dictionary<Producto,int> listaCarrito;
        private int numeroLista;
        private double precioTotal;
        private Random nroRandom;
        private double dineroClinte;
        private bool clienteActivo;
        private Color color;
        public FRMVentas(string  email,Color color)
        {
            InitializeComponent();
            this.listaCarrito = new Dictionary<Producto, int> ();
            this.numeroLista = 1;
            this.precioTotal = 0;
            this.color = color;
            this.clienteActivo = false;
            this.nroRandom = new Random();
            foreach(var i in Negocio.UsuariosList)
            {
                if (i == email)
                {
                    usuario = i;
                }
            }
        }
        private void FRMVentas_Load(object sender, EventArgs e)
        {
            dgvListaProductos.ForeColor = Color.Black;
            lblVendedor_data.Text = usuario.Nombre + " " + usuario.Apellido;
            lblCumplir_data.Text = Negocio.HorasPorDia.ToString() + " hs.";
            tmrTiempoActivo.Enabled = true;
            lblCajaDinero_data.Text = "$" +Negocio.DineroCaja.ToString();
            Size = new Size(320, 560);
            this.BackColor = this.color;
        }

        private void grpCliente_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();        
            int i = dgvListaProductos.CurrentRow.Index;
            if (ValidarStock((int)dgvListaProductos.Rows[i].Cells[5].Value, int.Parse(txtCantidad.Text)) &&  txtCantidad.Text!="0")
            {
                foreach (var prod in Negocio.ProductosList)
                {
                    if (prod == (int)dgvListaProductos.Rows[i].Cells[0].Value)
                    {
                        if (ExisteProducto(prod))
                        {
                            MessageBox.Show("Ya se agregó este producto","Producto existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.listaCarrito.Add(prod, int.Parse(txtCantidad.Text));
                            sb.AppendLine($"{this.numeroLista}) {prod.Id}        Cant: {txtCantidad.Text}        Precio: ${prod.Precio}");
                            ltbCarrito.Items.Add(sb.ToString());
                            this.precioTotal += int.Parse(txtCantidad.Text) * prod.Precio;
                            lblTotalCarrito_data.Text = "$" + this.precioTotal.ToString();
                            this.numeroLista++;
                            txtCantidad.Text = "0";
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor verifique:\n-Si hay stock\n-Si ingresó la cantidad.", "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tiempo++;
            lblActivo_data.Text =TransformadorTiempo.Transformar(this.tiempo);
        }

        private void lblCajaDinero_data_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalleProducto_Click(object sender, EventArgs e)
        {
            int i = dgvListaProductos.CurrentRow.Index;
            foreach (var prod in Negocio.ProductosList)
            {
                if (prod == (int)dgvListaProductos.Rows[i].Cells[0].Value)
                {
                    MessageBox.Show(prod.MostrarInfo(),"Detalle del producto", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
        private bool ValidarStock(int stock, int cantidad)
        {
            if (cantidad <= stock)
            {
                return true;
            }
            return false;
        }
        private void Filtrar(ECategoria categoria)
        {
            
            dgvListaProductos.Rows.Clear();
            foreach (var i in Negocio.ProductosList)
            {
                if (i.Categoria == categoria)
                {
                    dgvListaProductos.Rows.Add(i.Id, i.Marca, i.Origen, i.Categoria.ToString(), i.Precio, i.Stock);
                }
            }
        }
        private void SinFiltro()
        {
            foreach (var i in Negocio.ProductosList)
            {
                dgvListaProductos.Rows.Add(i.Id, i.Marca, i.Origen, i.Categoria.ToString(), i.Precio, i.Stock);
            }
        }

        private void ResetearDatos()
        {
            this.listaCarrito.Clear();
            this.precioTotal = 0;
            lblTotalCarrito_data.Text = "0";
            ltbCarrito.Items.Clear();
            this.numeroLista = 1;
        }
        private void ActualizarProductos()
        {
            foreach(var i in this.listaCarrito)
            {
                i.Key.Stock -= i.Value;
            }
        }
        private bool ExisteProducto(Producto prod)
        {
            foreach(var i in listaCarrito)
            {
                if (i.Key == prod)
                {
                    return true;
                }
            }
            return false;
        }
        private void GuardarHistorial()
        {
            Venta venta=null;
            double recargo = 0;
            if (rdbEfectivo.Checked == true)
            {
                foreach (var i in this.listaCarrito)
                {
                    venta = new Venta(this.usuario, i.Key, i.Value);
                    Negocio.AgregarVentaAHistorial(venta);
                }
            }
            else
            {
                foreach (var i in this.listaCarrito)
                {
                    recargo = (i.Key.Precio * i.Value)*10/100;
                    venta = new Venta(this.usuario, i.Key, i.Value,true,recargo);
                    Negocio.AgregarVentaAHistorial(venta);
                }
            }
            
        }
        private void btnFiltroComp_Click(object sender, EventArgs e)
        {
            Console.Beep(100, 300);
            Filtrar(ECategoria.Computación);
        }

        private void btnFiltroElecto_Click(object sender, EventArgs e)
        {
            Console.Beep(200, 300);
            Filtrar(ECategoria.Electrodomesticos);
        }

        private void btnFiltroCelular_Click(object sender, EventArgs e)
        {
            Console.Beep(300, 300);
            Filtrar(ECategoria.Celulares);
        }

        private void btnFiltroHerra_Click(object sender, EventArgs e)
        {
            Console.Beep(400, 300);
            Filtrar(ECategoria.Herramientas);
        }

        private void btnFiltroTodo_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 300);
            dgvListaProductos.Rows.Clear();
            SinFiltro();
        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            if (clienteActivo == false)
            {
                lblNroCliente_data.Text = Negocio.NumeroClientes.ToString();
                Negocio.NumeroClientes++;
                this.dineroClinte = this.nroRandom.Next(30, 2000) * 1000;
                lblDineroDisponible_data.Text = "$ " + this.dineroClinte.ToString();
                this.clienteActivo = true;
                Size = new Size(1230, 560);
            }
            else
            {
                MessageBox.Show("Ya está atendiendo un cliente.\nTermine la venta o cancele la venta.", "Antención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dgvListaProductos.Rows.Clear();
            SinFiltro();

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            double recargo = 0;
            bool seVende = false;
            if (lblTotalCarrito_data.Text != "0")
            {
                recargo = this.precioTotal * (float)10 / 100;
                if (rdbEfectivo.Checked && this.dineroClinte >= this.precioTotal)
                {
                    Negocio.DineroCaja += this.precioTotal;
                    seVende = true;
                }
                else if(rdbCredito.Checked && this.dineroClinte >= this.precioTotal+recargo)
                {
                        
                    Negocio.DineroCaja +=  this.precioTotal+recargo;
                    seVende = true;
                    MessageBox.Show("Se hizo un recargo del 10% de pago con targeta", "Información de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cliente no cuenta con dinero suficiente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (seVende == true)
                {
                    lblCajaDinero_data.Text = Negocio.DineroCaja.ToString();
                    if (MessageBox.Show("¿Desea ver la factura?", "Venta exitosa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        FRMFactura frmFactura = new FRMFactura(this.listaCarrito, this.usuario, recargo);
                        frmFactura.ShowDialog();
                        this.Show();
                    }
                    GuardarHistorial();
                    ActualizarProductos();
                    ResetearDatos();
                    Size = new Size(320, 560);
                    this.clienteActivo = false;
                }
            }
            else
            {
                MessageBox.Show("No agregó nada al carrito.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea cancelar la venta?", "Confimación de cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetearDatos();
                this.clienteActivo = false;
                Size = new Size(320, 560);
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ResetearDatos();
        }

        private void lblFinalizar_Click(object sender, EventArgs e)
        {
            FRMHistorial frmHistorial = new FRMHistorial();
            this.Hide();
            frmHistorial.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
