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
    public partial class FRMFactura : Form
    {
        private Dictionary<Producto, int> lista;
        private Usuario usuario;
        public FRMFactura(Dictionary<Producto,int> lista, Usuario usuario)
        {
            InitializeComponent();
            this.lista = lista;
            this.usuario = usuario;
        }

        private void FRMFactura_Load(object sender, EventArgs e)
        {
            StringBuilder sbId = new StringBuilder();
            StringBuilder sbCant = new StringBuilder();
            StringBuilder sbPrecio = new StringBuilder();
            StringBuilder sbTotal = new StringBuilder();
            double Subtotal;
            double total=0;
            DateTime dt = DateTime.Now;
            lblNroFatura_data.Text = Negocio.NumeroClientes.ToString();
            lblFecha_data.Text = dt.ToString();
            lblVendedor_data.Text= usuario.Nombre + " " + usuario.Apellido;
           
            foreach(var i in lista)
            {
                sbId.AppendLine(i.Key.Id.ToString());
                sbCant.AppendLine(i.Value.ToString());
                sbPrecio.AppendLine(i.Key.Precio.ToString());
                Subtotal = i.Value * i.Key.Precio;
                sbTotal.AppendLine(Subtotal.ToString());
                total += Subtotal;

            }
            lblIDs.Text = sbId.ToString();
            lblCantidades.Text = sbCant.ToString();
            lblPrecios.Text = sbPrecio.ToString();
            lblSubTotales.Text = sbTotal.ToString();
            lblTotal_data.Text = total.ToString();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se mando a imprimir", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
