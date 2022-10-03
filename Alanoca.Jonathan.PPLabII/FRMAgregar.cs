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
    public partial class FRMAgregar : Form
    {
        public FRMAgregar()
        {
            InitializeComponent();
        }

        private void FRMAgregar_Load(object sender, EventArgs e)
        {
            cmbSeleccionProd.SelectedIndex = 0;
            //grpDatosNote.Location= new System.Drawing.Point(586, 107);
            //grpCelular.Location = new System.Drawing.Point(586, 107);
            Size = new Size(560, 413);
            lblId_data.Text = Negocio.IdProducto.ToString();
        }

        private void grpDatosNote_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSeleccionProd_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbSeleccionProd.SelectedIndex)
            {
               case 0:
                    grpCelular.Visible = false;
                    grpDatosNote.Visible = false;
                    lblNombre.Visible = true;
                    txtNombre.Visible = true;
                    chkNombre.Visible = true;
                    break;
                case 1:
                    grpCelular.Visible = false;
                    grpDatosNote.Visible = true;
                    lblNombre.Visible = false;
                    txtNombre.Visible = false;
                    chkNombre.Visible = false;

                    break;
                case 2:
                    grpCelular.Visible = true;
                    grpDatosNote.Visible = false;
                    lblNombre.Visible = false;
                    txtNombre.Visible = false;
                    chkNombre.Visible = false;
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmrEntrada_Tick(object sender, EventArgs e)
        {
          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                chkNombre.Checked = true;
            }
        }
    }
}
