using Entidades;
using System;
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
        public FRMVentas(string  email)
        {
            InitializeComponent();
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
            int i = dgvListaProductos.CurrentRow.Index;
            foreach (var prod in Negocio.ProductosList)
            {
                if (prod == (int)dgvListaProductos.Rows[i].Cells[0].Value)
                {
                    MessageBox.Show(prod.MostrarInfo());
                }
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
    }
}
