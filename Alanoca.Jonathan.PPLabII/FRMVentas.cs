using Entidades;
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
        private List<Producto> listaCarrito;
        private int numeroLista;
        private double precioTotal;
        public FRMVentas(string  email)
        {
            InitializeComponent();
            this.listaCarrito = new List<Producto>();
            this.numeroLista = 1;
            this.precioTotal = 0;
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
            foreach(var i  in Negocio.ProductosList)
            {
                dgvListaProductos.Rows.Add(i.Id,i.Marca,i.Origen,i.Categoria.ToString(),i.Precio,i.Stock);
            }
            lblVendedor_data.Text = usuario.Nombre + " " + usuario.Apellido;
            lblCumplir_data.Text = Negocio.HorasPorDia.ToString() + " hs.";
            tmrTiempoActivo.Enabled = true;
            lblCajaDinero_data.Text = "$" +Negocio.DineroCaja.ToString();
            lblNroCliente_data.Text = Negocio.NumeroClientes.ToString();
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
                        this.listaCarrito.Add(prod);
                        sb.AppendLine($"{this.numeroLista}) {prod.Id}        Cant: {txtCantidad.Text}        Precio: ${prod.Precio}");
                        ltbCarrito.Items.Add(sb.ToString());
                        this.precioTotal += int.Parse(txtCantidad.Text) * prod.Precio;
                        lblTotalCarrito_data.Text = "$" + this.precioTotal.ToString();
                        this.numeroLista++;
                        txtCantidad.Text = "0";
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
        private void filtrar(ECategoria categoria)
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

        private void btnFiltroComp_Click(object sender, EventArgs e)
        {
            filtrar(ECategoria.Computación);
        }

        private void btnFiltroElecto_Click(object sender, EventArgs e)
        {
            filtrar(ECategoria.Electrodomesticos);
        }

        private void btnFiltroCelular_Click(object sender, EventArgs e)
        {
            filtrar(ECategoria.Celulares);
        }

        private void btnFiltroHerra_Click(object sender, EventArgs e)
        {
            filtrar(ECategoria.Herramientas);
        }

        private void btnFiltroTodo_Click(object sender, EventArgs e)
        {
            dgvListaProductos.Rows.Clear();
            foreach (var i in Negocio.ProductosList)
            {
                dgvListaProductos.Rows.Add(i.Id, i.Marca, i.Origen, i.Categoria.ToString(), i.Precio, i.Stock);

            }
        }
    }
}
