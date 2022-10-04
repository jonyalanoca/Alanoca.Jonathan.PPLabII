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
    public partial class FRMHistorial : Form
    {
        public FRMHistorial()
        {
            InitializeComponent();
        }

        private void FRMHistorial_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach(var venta in Negocio.HistorialVentas)
            {
                dgvHistorial.Rows.Add(i.ToString(),venta.Fecha.ToString(), venta.Vendedor, venta.Producto.ToString(),venta.Precio.ToString(), venta.Cantidad, venta.Targeta, venta.Recargo.ToString(), venta.Total.ToString());
                i++;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Se mando a imprimir!", "Impresión de historial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
