namespace Labo_tp1
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnSalir = new System.Windows.Forms.Button();
            this.picBanerStore = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnHCodearDuenio = new System.Windows.Forms.Button();
            this.picPersonas = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSeccVender = new System.Windows.Forms.Button();
            this.btnSeccAdmin = new System.Windows.Forms.Button();
            this.btnHCodearVendedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBanerStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(571, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(29, 28);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // picBanerStore
            // 
            this.picBanerStore.Image = ((System.Drawing.Image)(resources.GetObject("picBanerStore.Image")));
            this.picBanerStore.Location = new System.Drawing.Point(0, 0);
            this.picBanerStore.Name = "picBanerStore";
            this.picBanerStore.Size = new System.Drawing.Size(300, 400);
            this.picBanerStore.TabIndex = 1;
            this.picBanerStore.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(341, 284);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(216, 40);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(341, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(216, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(341, 240);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "Contraceña";
            this.txtPass.Size = new System.Drawing.Size(216, 23);
            this.txtPass.TabIndex = 4;
            // 
            // btnHCodearDuenio
            // 
            this.btnHCodearDuenio.FlatAppearance.BorderSize = 0;
            this.btnHCodearDuenio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHCodearDuenio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHCodearDuenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHCodearDuenio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnHCodearDuenio.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHCodearDuenio.Location = new System.Drawing.Point(341, 330);
            this.btnHCodearDuenio.Name = "btnHCodearDuenio";
            this.btnHCodearDuenio.Size = new System.Drawing.Size(216, 24);
            this.btnHCodearDuenio.TabIndex = 5;
            this.btnHCodearDuenio.Text = "Soy dueño olvidé mis datos";
            this.btnHCodearDuenio.UseVisualStyleBackColor = true;
            this.btnHCodearDuenio.Click += new System.EventHandler(this.btnHCodearDuenio_Click);
            // 
            // picPersonas
            // 
            this.picPersonas.BackColor = System.Drawing.Color.Transparent;
            this.picPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPersonas.Image = global::Labo_tp1.Properties.Resources.man;
            this.picPersonas.Location = new System.Drawing.Point(387, 30);
            this.picPersonas.Name = "picPersonas";
            this.picPersonas.Size = new System.Drawing.Size(118, 116);
            this.picPersonas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonas.TabIndex = 6;
            this.picPersonas.TabStop = false;
            this.picPersonas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLogin.Location = new System.Drawing.Point(384, 140);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(121, 44);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login";
            // 
            // btnSeccVender
            // 
            this.btnSeccVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnSeccVender.FlatAppearance.BorderSize = 0;
            this.btnSeccVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeccVender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeccVender.ForeColor = System.Drawing.Color.White;
            this.btnSeccVender.Location = new System.Drawing.Point(341, 284);
            this.btnSeccVender.Name = "btnSeccVender";
            this.btnSeccVender.Size = new System.Drawing.Size(108, 40);
            this.btnSeccVender.TabIndex = 8;
            this.btnSeccVender.Text = "Vender";
            this.btnSeccVender.UseVisualStyleBackColor = false;
            this.btnSeccVender.Visible = false;
            this.btnSeccVender.Click += new System.EventHandler(this.btnSeccVender_Click);
            // 
            // btnSeccAdmin
            // 
            this.btnSeccAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnSeccAdmin.FlatAppearance.BorderSize = 0;
            this.btnSeccAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeccAdmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeccAdmin.ForeColor = System.Drawing.Color.White;
            this.btnSeccAdmin.Location = new System.Drawing.Point(455, 284);
            this.btnSeccAdmin.Name = "btnSeccAdmin";
            this.btnSeccAdmin.Size = new System.Drawing.Size(102, 40);
            this.btnSeccAdmin.TabIndex = 9;
            this.btnSeccAdmin.Text = "Administrar";
            this.btnSeccAdmin.UseVisualStyleBackColor = false;
            this.btnSeccAdmin.Visible = false;
            this.btnSeccAdmin.Click += new System.EventHandler(this.btnSeccAdmin_Click);
            // 
            // btnHCodearVendedor
            // 
            this.btnHCodearVendedor.BackColor = System.Drawing.Color.Transparent;
            this.btnHCodearVendedor.FlatAppearance.BorderSize = 0;
            this.btnHCodearVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHCodearVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHCodearVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHCodearVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnHCodearVendedor.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHCodearVendedor.Location = new System.Drawing.Point(341, 349);
            this.btnHCodearVendedor.Name = "btnHCodearVendedor";
            this.btnHCodearVendedor.Size = new System.Drawing.Size(216, 24);
            this.btnHCodearVendedor.TabIndex = 10;
            this.btnHCodearVendedor.Text = "Soy vendedor olvidé mis datos";
            this.btnHCodearVendedor.UseVisualStyleBackColor = false;
            this.btnHCodearVendedor.Click += new System.EventHandler(this.btnHCodearVendedor_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnHCodearVendedor);
            this.Controls.Add(this.btnSeccAdmin);
            this.Controls.Add(this.btnSeccVender);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.picPersonas);
            this.Controls.Add(this.btnHCodearDuenio);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.picBanerStore);
            this.Controls.Add(this.btnSalir);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanerStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalir;
        private PictureBox picBanerStore;
        private Button btnIngresar;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnHCodearDuenio;
        private PictureBox picPersonas;
        private Label lblLogin;
        private Button btnSeccVender;
        private Button btnSeccAdmin;
        private Button btnHCodearVendedor;
    }
}