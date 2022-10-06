using Entidades;
using System.Media;

namespace Labo_tp1
{
    public partial class FrmLogin : Form
    {
        private Usuario usuarioLogeado;
        public FrmLogin()
        {
            InitializeComponent();
            this.usuarioLogeado = null;
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
                        MessageBox.Show("Los datos ingresados son incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case EPuesto.Vendedor:
                        this.usuarioLogeado = Validador.Validar(Negocio.UsuariosList, txtEmail.Text);
                        MessageBox.Show("Bienvenido " + this.usuarioLogeado.CrearNombreCompleto() + "\nQue tenga un buen día.", "Bievenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FRMVentas formVentas = new FRMVentas(this.usuarioLogeado, Color.Crimson);
                        formVentas.ShowDialog();
                        this.Show();
                        break;
                    case EPuesto.Dueño:
                        this.usuarioLogeado = Validador.Validar(Negocio.UsuariosList, txtEmail.Text);
                        MessageBox.Show("Bienvenido " +this.usuarioLogeado.CrearNombreCompleto()+ "\nPorfavor seleccione a que sector desea ir.", "Bievenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BloquearYDesbloquear();
                        break;
                    case EPuesto.Contador:
                        this.usuarioLogeado = Validador.Validar(Negocio.UsuariosList, txtEmail.Text);
                        MessageBox.Show("Bienvenido " + this.usuarioLogeado.CrearNombreCompleto() + "\nQue tenga un buen día.", "Bievenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FRMEstadisticas formAdmin = new FRMEstadisticas(this.usuarioLogeado);
                        formAdmin.ShowDialog();
                        this.Show();
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

        private void btnSeccVender_Click(object sender, EventArgs e)
        {
            Console.Beep(100, 300);
            this.Hide();
            FRMVentas formVentas = new FRMVentas(this.usuarioLogeado, Color.FromArgb(128, 64, 64));
            formVentas.ShowDialog();
            this.Show();
            BloquearYDesbloquear();
        }

        private void btnSeccAdmin_Click(object sender, EventArgs e)
        {
            Console.Beep(100, 300);
            this.Hide();
            FRMAdministracion formAdministracion= new FRMAdministracion();
            formAdministracion.ShowDialog();
            this.Show();
            BloquearYDesbloquear();
        }
        /// <summary>
        /// Si ya esta bloqueado lo desbloquea y viceversa
        /// </summary>
        private void BloquearYDesbloquear()
        {
            btnIngresar.Visible = !btnIngresar.Visible;
            btnSeccAdmin.Visible = !btnSeccAdmin.Visible;
            btnSeccVender.Visible = !btnSeccVender.Visible;
            txtEmail.Enabled = !txtEmail.Enabled;
            txtPass.Enabled = !txtPass.Enabled;
            btnHCodearDuenio.Enabled = !btnHCodearDuenio.Enabled;
            btnHCodearVendedor.Enabled = !btnHCodearVendedor.Enabled;
        }
    }
}