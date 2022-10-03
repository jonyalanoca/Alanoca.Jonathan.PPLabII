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
    public partial class FRMEditar : Form
    {
        private Producto prod;
        public FRMEditar(Producto prod)
        {
            InitializeComponent();
            this.prod = prod;
        }

        private void lblEentre_Click(object sender, EventArgs e)
        {

        }

        private void FRMEditar_Load(object sender, EventArgs e)
        {
            foreach(var i in Enum.GetValues(typeof(ECategoria)))
            {
                cmbCategoria.Items.Add(i.ToString());
                cmbCategoria.SelectedIndex = 0;
            }
            
        }

        private void tkbStock_Scroll(object sender, EventArgs e)
        {
            lblStock_data.Text = tkbStock.Value.ToString();
        }

        private void btnFiltrarPrecio_Click(object sender, EventArgs e)
        {
            foreach(var i in Enum.GetValues(typeof(ECategoria)))
            {
                if (i.ToString() == cmbCategoria.Text)
                {
                    this.prod.Categoria = (ECategoria)i;
                }
            }
            this.prod.Precio = (float)nupPrecio.Value;
            this.prod.Stock = tkbStock.Value;
            this.Close();
        }
    }
}
