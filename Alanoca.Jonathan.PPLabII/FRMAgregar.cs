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
            if (cmbSeleccionProd.SelectedIndex == 0 && ValidarCamposPrincipales() && chkNombre.Checked == true)
            {
                Producto productoNuevo = new Producto(Negocio.IdProducto,txtNombre.Text,txtMarca.Text,(float)nupPrecio.Value,txtOrigen.Text,BuscarCatogoriaByString(cmbCategoria.Text),tkbStock.Value);
                AgrearProducto(productoNuevo);
            }
            else if (cmbSeleccionProd.SelectedIndex == 1 && ValidarCamposPrincipales() && chkMicro.Checked==true && chkMemoria.Checked==true && chkRam.Checked == true)
            {
                Notebook productoNuevo = new Notebook(Negocio.IdProducto,txtMarca.Text,(float)nupPrecio.Value,txtOrigen.Text,BuscarCatogoriaByString(cmbCategoria.Text),tkbStock.Value,txtMicro.Text, BuscarMemoriaByRadioButton(),int.Parse(cmbMemoria.Text),tkbRam.Value);
                AgrearProducto(productoNuevo);
            }
            else if (cmbSeleccionProd.SelectedIndex == 2 && ValidarCamposPrincipales() && chkCelModelo.Checked==true && chkCelSo.Checked==true && chkCelCam.Checked==true && chkCelPulgadas.Checked==true && chkCelMemoria.Checked == true)
            {
                Celular productoNuevo = new Celular(
                    Negocio.IdProducto,
                    txtMarca.Text,
                    (float)nupPrecio.Value,
                    txtOrigen.Text,
                    BuscarCatogoriaByString(cmbCategoria.Text),
                    tkbStock.Value,
                    txtCelModelo.Text,
                    cmbCelSo.Text,
                    (float)tkbCelCam.Value,
                    float.Parse(cmbCelPulgadas.Text),
                    int.Parse(cmbCelMemoria.Text)
                    );
                AgrearProducto(productoNuevo);
            }
            else
            {
                MessageBox.Show("Porfavor revise que tiene los campos bien completados\nConsejo: revise los checks", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            BorrarCampos();

            
        }
        private bool ValidarCamposPrincipales()
        {
            if (chkMarca.Checked==true && chkOrigen.Checked == true && chkCategoria.Checked == true && chkPrecio.Checked == true && chkStock.Checked == true)
            {
                return true;
            }
            return false;
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
        private ECategoria BuscarCatogoriaByString(string catString)
        {
            ECategoria auxCategoria=ECategoria.Otros;
            foreach(var i in Enum.GetValues(typeof(ECategoria))){
                if (i.ToString() == catString)
                {
                    auxCategoria = (ECategoria)i;
                }
            }
            return auxCategoria;
        }
        private ETipoMemoria BuscarMemoriaByRadioButton()
        {
            ETipoMemoria auxTipo = ETipoMemoria.SSD;
            if (rdbHdd.Checked == true)
            {
                auxTipo = ETipoMemoria.HDD;
            }else if (rdbM2.Checked == true)
            {
                auxTipo = ETipoMemoria.M2;
            }
            return auxTipo;
        }
        private void AgrearProducto(Producto prod)
        {
            if(MessageBox.Show("¿Seguro que desea agregar el siguiente producto?\n" + prod.MostrarInfo(), "Añadir producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Negocio.ProductosList.Add(prod);
                Negocio.IdProducto++;
                MessageBox.Show("¡Se agregó el producto!", "Producto añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
