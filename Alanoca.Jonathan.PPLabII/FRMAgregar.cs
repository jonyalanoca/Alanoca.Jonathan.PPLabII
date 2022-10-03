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
            int numero;
        }

        private void FRMAgregar_Load(object sender, EventArgs e)
        {
            cmbSeleccionProd.SelectedIndex = 0;
            //grpDatosNote.Location= new System.Drawing.Point(586, 107);
            //grpCelular.Location = new System.Drawing.Point(586, 107);
            Size = new Size(560, 413);
            lblId_data.Text = Negocio.IdProducto.ToString();
            foreach (var i in Enum.GetValues(typeof(ECategoria)))
            {
                cmbCategoria.Items.Add(i.ToString());
            }
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

            BorrarCampos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            VerificarVacio(txtNombre, chkNombre);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            VerificarVacio(txtMarca, chkMarca);
        }
        private void VerificarVacio(TextBox herramienta,CheckBox cheched)
        {
            if (herramienta.Text != "")
            {
                cheched.Checked = true;
            }
            else
            {
                cheched.Checked = false;
            }
        }
        private void VerificarCombo(ComboBox combo, CheckBox check)
        {
            if (combo.SelectedIndex == -1)
            {
                check.Checked = false;
            }
            else
            {
                check.Checked = true;
            }
        }
        private void ValidarTrackBar(TrackBar track, CheckBox check)
        {
            if (track.Value != 0)
            {
                check.Checked = true;
            }
            else
            {
                check.Checked = false;
            }
        }
        private void BorrarCampos()
        {
            lblId_data.Text = Negocio.IdProducto.ToString();
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtOrigen.Text = "";
            cmbCategoria.SelectedIndex = -1;
            nupPrecio.Value = 0;
            tkbStock.Value = 0;
            lblStock_data.Text = "0";

            txtMicro.Text = "";
            cmbMemoria.SelectedIndex = -1;
            rdbSsd.Checked = true;
            tkbRam.Value = 0;
            lblRam_data.Text = "0";
            chkRam.Checked = false;

            txtCelModelo.Text = "";
            cmbCelSo.SelectedIndex = -1;
            tkbCelCam.Value = 0;
            lblCelCam_data.Text = "0";
            chkCelCam.Checked = false;
            cmbCelPulgadas.SelectedIndex = -1;
            cmbCelMemoria.SelectedIndex = -1;
        }
        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {
            VerificarVacio(txtOrigen, chkOrigen);
        }

        private void txrMicro_TextChanged(object sender, EventArgs e)
        {
            VerificarVacio(txtMicro, chkMicro);
        }

        private void txtCelModelo_TextChanged(object sender, EventArgs e)
        {
            VerificarVacio(txtCelModelo, chkCelModelo);
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCombo(cmbCategoria,chkCategoria);
        }

        private void cmbMemoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCombo(cmbMemoria,chkMemoria);
        }

        private void cmbCelSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCombo(cmbCelSo,chkCelSo);
        }

        private void cmbCelPulgadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCombo(cmbCelPulgadas,chkCelPulgadas);
        }

        private void cmbCelMemoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCombo(cmbCelMemoria,chkCelMemoria);
        }

        private void tkbStock_Scroll(object sender, EventArgs e)
        {
            lblStock_data.Text = tkbStock.Value.ToString();
        }

        private void trbRam_Scroll(object sender, EventArgs e)
        {
            ValidarTrackBar(tkbRam,chkRam);
            lblRam_data.Text = tkbRam.Value.ToString();
        }
        private void tkbCelCam_Scroll(object sender, EventArgs e)
        {
            ValidarTrackBar(tkbCelCam, chkCelCam);
            lblCelCam_data.Text = tkbCelCam.Value.ToString();
        }

        private void nupPrecio_ValueChanged(object sender, EventArgs e)
        {
            if (nupPrecio.Value == 0)
            {
                chkPrecio.Checked = false;
            }
            else
            {
                chkPrecio.Checked = true;
            }
        }

        
    }
}
