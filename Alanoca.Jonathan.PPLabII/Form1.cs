using Entidades;

namespace Labo_tp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            this.btnSalir.BackColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.btnSalir.BackColor = Color.FromArgb(0, 128, 64, 64);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPass.Text) && String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar algun dato.", "Caracteres no validos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EPuesto puesto= Validador.Validar(txtEmail.Text, txtPass.Text);
                switch (puesto)
                {
                    case EPuesto.Ninguno:
                        //MessageBox.Show("Los datos ingresados son incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        foreach(var i in Negocio.ProductosList)
                        {
                            if (i.GetType() == typeof(Celular))
                            {
                                MessageBox.Show(i.MostrarInfo());
                            }
                            
                        }
                        
                        break;
                    case EPuesto.Vendedor:
                        MessageBox.Show("Bienvenido " + Negocio.ObtenerNombreCompleto(txtEmail.Text) + "\nQue tenga un buen día.", "Bievenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case EPuesto.Dueño:
                        MessageBox.Show("Bienvenido " + Negocio.ObtenerNombreCompleto(txtEmail.Text) + "\nPorfavor seleccione a que sector desea ir.", "Bievenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnIngresar.Visible = false;
                        btnSeccAdmin.Visible = true;
                        btnSeccVender.Visible = true;
                        txtEmail.Enabled = false;
                        txtPass.Enabled = false;
                        btnHCodearDuenio.Enabled = false;
                        btnHCodearVendedor.Enabled = false;
                        break;
                }
            }
        }
        private void btnHCodearDuenio_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "camisimpson@gmail.com";
            txtPass.Text = "123pass";
        }

        private void btnHCodearVendedor_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "geraduviri@gmail.com";
            txtPass.Text = "123contra";
        }
    }
}