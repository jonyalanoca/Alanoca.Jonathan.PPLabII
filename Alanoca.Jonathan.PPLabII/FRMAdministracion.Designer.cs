namespace Labo_tp1
{
    partial class FRMAdministracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFiltroElecto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpModo = new System.Windows.Forms.GroupBox();
            this.rdbElectro = new System.Windows.Forms.RadioButton();
            this.rdbHerramientas = new System.Windows.Forms.RadioButton();
            this.rdbCelular = new System.Windows.Forms.RadioButton();
            this.rdbComputacion = new System.Windows.Forms.RadioButton();
            this.rdbTodo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCaja = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPalabraBuscar = new System.Windows.Forms.TextBox();
            this.rdbOrigen = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDetalle_data = new System.Windows.Forms.Label();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltroPrecio = new System.Windows.Forms.GroupBox();
            this.btnFiltrarPrecio = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblEentre = new System.Windows.Forms.Label();
            this.rdbMenorPrecio = new System.Windows.Forms.RadioButton();
            this.rdbMayorPrecio = new System.Windows.Forms.RadioButton();
            this.grpModo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.grpFiltroPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltroElecto
            // 
            this.btnFiltroElecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnFiltroElecto.FlatAppearance.BorderSize = 0;
            this.btnFiltroElecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroElecto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroElecto.ForeColor = System.Drawing.Color.White;
            this.btnFiltroElecto.Location = new System.Drawing.Point(678, 417);
            this.btnFiltroElecto.Name = "btnFiltroElecto";
            this.btnFiltroElecto.Size = new System.Drawing.Size(230, 34);
            this.btnFiltroElecto.TabIndex = 17;
            this.btnFiltroElecto.Text = "Editar ";
            this.btnFiltroElecto.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(678, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(678, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // grpModo
            // 
            this.grpModo.Controls.Add(this.rdbElectro);
            this.grpModo.Controls.Add(this.rdbHerramientas);
            this.grpModo.Controls.Add(this.rdbCelular);
            this.grpModo.Controls.Add(this.rdbComputacion);
            this.grpModo.Controls.Add(this.rdbTodo);
            this.grpModo.ForeColor = System.Drawing.Color.White;
            this.grpModo.Location = new System.Drawing.Point(12, 12);
            this.grpModo.Name = "grpModo";
            this.grpModo.Size = new System.Drawing.Size(177, 158);
            this.grpModo.TabIndex = 24;
            this.grpModo.TabStop = false;
            this.grpModo.Text = "Filtrar Categoria";
            // 
            // rdbElectro
            // 
            this.rdbElectro.AutoSize = true;
            this.rdbElectro.Location = new System.Drawing.Point(20, 47);
            this.rdbElectro.Name = "rdbElectro";
            this.rdbElectro.Size = new System.Drawing.Size(122, 19);
            this.rdbElectro.TabIndex = 4;
            this.rdbElectro.Text = "Electrodomesticos";
            this.rdbElectro.UseVisualStyleBackColor = true;
            this.rdbElectro.CheckedChanged += new System.EventHandler(this.rdbElectro_CheckedChanged);
            // 
            // rdbHerramientas
            // 
            this.rdbHerramientas.AutoSize = true;
            this.rdbHerramientas.Location = new System.Drawing.Point(20, 126);
            this.rdbHerramientas.Name = "rdbHerramientas";
            this.rdbHerramientas.Size = new System.Drawing.Size(96, 19);
            this.rdbHerramientas.TabIndex = 3;
            this.rdbHerramientas.Text = "Herramientas";
            this.rdbHerramientas.UseVisualStyleBackColor = true;
            this.rdbHerramientas.CheckedChanged += new System.EventHandler(this.rdbHerramientas_CheckedChanged);
            // 
            // rdbCelular
            // 
            this.rdbCelular.AutoSize = true;
            this.rdbCelular.Location = new System.Drawing.Point(20, 76);
            this.rdbCelular.Name = "rdbCelular";
            this.rdbCelular.Size = new System.Drawing.Size(62, 19);
            this.rdbCelular.TabIndex = 2;
            this.rdbCelular.TabStop = true;
            this.rdbCelular.Text = "Celular";
            this.rdbCelular.UseVisualStyleBackColor = true;
            this.rdbCelular.CheckedChanged += new System.EventHandler(this.rdbCelular_CheckedChanged);
            // 
            // rdbComputacion
            // 
            this.rdbComputacion.AutoSize = true;
            this.rdbComputacion.Location = new System.Drawing.Point(20, 101);
            this.rdbComputacion.Name = "rdbComputacion";
            this.rdbComputacion.Size = new System.Drawing.Size(98, 19);
            this.rdbComputacion.TabIndex = 1;
            this.rdbComputacion.Text = "Computación";
            this.rdbComputacion.UseVisualStyleBackColor = true;
            this.rdbComputacion.CheckedChanged += new System.EventHandler(this.rdbComputacion_CheckedChanged);
            // 
            // rdbTodo
            // 
            this.rdbTodo.AutoSize = true;
            this.rdbTodo.Checked = true;
            this.rdbTodo.Location = new System.Drawing.Point(20, 22);
            this.rdbTodo.Name = "rdbTodo";
            this.rdbTodo.Size = new System.Drawing.Size(51, 19);
            this.rdbTodo.TabIndex = 0;
            this.rdbTodo.TabStop = true;
            this.rdbTodo.Text = "Todo";
            this.rdbTodo.UseVisualStyleBackColor = true;
            this.rdbTodo.CheckedChanged += new System.EventHandler(this.rdbTodo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCaja);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtPalabraBuscar);
            this.groupBox1.Controls.Add(this.rdbOrigen);
            this.groupBox1.Controls.Add(this.rdbMarca);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(379, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 158);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCaja.Location = new System.Drawing.Point(109, 30);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(80, 21);
            this.lblCaja.TabIndex = 27;
            this.lblCaja.Text = "Buscador";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(60, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 28);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtPalabraBuscar
            // 
            this.txtPalabraBuscar.Location = new System.Drawing.Point(23, 63);
            this.txtPalabraBuscar.Name = "txtPalabraBuscar";
            this.txtPalabraBuscar.Size = new System.Drawing.Size(236, 23);
            this.txtPalabraBuscar.TabIndex = 2;
            // 
            // rdbOrigen
            // 
            this.rdbOrigen.AutoSize = true;
            this.rdbOrigen.Location = new System.Drawing.Point(158, 95);
            this.rdbOrigen.Name = "rdbOrigen";
            this.rdbOrigen.Size = new System.Drawing.Size(61, 19);
            this.rdbOrigen.TabIndex = 1;
            this.rdbOrigen.Text = "Origen";
            this.rdbOrigen.UseVisualStyleBackColor = true;
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Checked = true;
            this.rdbMarca.Location = new System.Drawing.Point(60, 92);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(58, 19);
            this.rdbMarca.TabIndex = 0;
            this.rdbMarca.TabStop = true;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lblDetalle_data);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(677, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 323);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del producto";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(27, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 49);
            this.button3.TabIndex = 28;
            this.button3.Text = "Ver detalle del producto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lblDetalle_data
            // 
            this.lblDetalle_data.AutoSize = true;
            this.lblDetalle_data.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetalle_data.ForeColor = System.Drawing.Color.White;
            this.lblDetalle_data.Location = new System.Drawing.Point(16, 32);
            this.lblDetalle_data.Name = "lblDetalle_data";
            this.lblDetalle_data.Size = new System.Drawing.Size(13, 19);
            this.lblDetalle_data.TabIndex = 28;
            this.lblDetalle_data.Text = ".";
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProductos.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProd,
            this.Marca,
            this.Origen,
            this.Categoria,
            this.Precio,
            this.Stock});
            this.dgvListaProductos.GridColor = System.Drawing.Color.Gray;
            this.dgvListaProductos.Location = new System.Drawing.Point(12, 176);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowTemplate.Height = 25;
            this.dgvListaProductos.Size = new System.Drawing.Size(660, 325);
            this.dgvListaProductos.TabIndex = 27;
            this.dgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellContentClick);
            // 
            // IdProd
            // 
            this.IdProd.HeaderText = "ID Producto";
            this.IdProd.Name = "IdProd";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Catogoria";
            this.Categoria.Name = "Categoria";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // grpFiltroPrecio
            // 
            this.grpFiltroPrecio.Controls.Add(this.btnFiltrarPrecio);
            this.grpFiltroPrecio.Controls.Add(this.lblA);
            this.grpFiltroPrecio.Controls.Add(this.txtHasta);
            this.grpFiltroPrecio.Controls.Add(this.txtDesde);
            this.grpFiltroPrecio.Controls.Add(this.lblEentre);
            this.grpFiltroPrecio.Controls.Add(this.rdbMenorPrecio);
            this.grpFiltroPrecio.Controls.Add(this.rdbMayorPrecio);
            this.grpFiltroPrecio.ForeColor = System.Drawing.Color.White;
            this.grpFiltroPrecio.Location = new System.Drawing.Point(195, 12);
            this.grpFiltroPrecio.Name = "grpFiltroPrecio";
            this.grpFiltroPrecio.Size = new System.Drawing.Size(178, 158);
            this.grpFiltroPrecio.TabIndex = 25;
            this.grpFiltroPrecio.TabStop = false;
            this.grpFiltroPrecio.Text = "Filtrar Precio";
            // 
            // btnFiltrarPrecio
            // 
            this.btnFiltrarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnFiltrarPrecio.FlatAppearance.BorderSize = 0;
            this.btnFiltrarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPrecio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarPrecio.Location = new System.Drawing.Point(30, 127);
            this.btnFiltrarPrecio.Name = "btnFiltrarPrecio";
            this.btnFiltrarPrecio.Size = new System.Drawing.Size(122, 25);
            this.btnFiltrarPrecio.TabIndex = 28;
            this.btnFiltrarPrecio.Text = "Filtrar";
            this.btnFiltrarPrecio.UseVisualStyleBackColor = false;
            this.btnFiltrarPrecio.Click += new System.EventHandler(this.btnFiltrarPrecio_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblA.Location = new System.Drawing.Point(80, 95);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(19, 21);
            this.lblA.TabIndex = 31;
            this.lblA.Text = "a";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(105, 93);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(58, 23);
            this.txtHasta.TabIndex = 30;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(16, 93);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(58, 23);
            this.txtDesde.TabIndex = 29;
            // 
            // lblEentre
            // 
            this.lblEentre.AutoSize = true;
            this.lblEentre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEentre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEentre.Location = new System.Drawing.Point(30, 69);
            this.lblEentre.Name = "lblEentre";
            this.lblEentre.Size = new System.Drawing.Size(102, 21);
            this.lblEentre.TabIndex = 28;
            this.lblEentre.Text = "Precio entre";
            // 
            // rdbMenorPrecio
            // 
            this.rdbMenorPrecio.AutoSize = true;
            this.rdbMenorPrecio.Location = new System.Drawing.Point(20, 47);
            this.rdbMenorPrecio.Name = "rdbMenorPrecio";
            this.rdbMenorPrecio.Size = new System.Drawing.Size(96, 19);
            this.rdbMenorPrecio.TabIndex = 4;
            this.rdbMenorPrecio.Text = "Menor precio";
            this.rdbMenorPrecio.UseVisualStyleBackColor = true;
            this.rdbMenorPrecio.CheckedChanged += new System.EventHandler(this.rdbMenorPrecio_CheckedChanged);
            // 
            // rdbMayorPrecio
            // 
            this.rdbMayorPrecio.AutoSize = true;
            this.rdbMayorPrecio.Location = new System.Drawing.Point(20, 22);
            this.rdbMayorPrecio.Name = "rdbMayorPrecio";
            this.rdbMayorPrecio.Size = new System.Drawing.Size(95, 19);
            this.rdbMayorPrecio.TabIndex = 0;
            this.rdbMayorPrecio.Text = "Mayor Precio";
            this.rdbMayorPrecio.UseVisualStyleBackColor = true;
            this.rdbMayorPrecio.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // FRMAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(919, 513);
            this.Controls.Add(this.grpFiltroPrecio);
            this.Controls.Add(this.dgvListaProductos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpModo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiltroElecto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRMAdministracion";
            this.Text = "FRMAdministracion";
            this.Load += new System.EventHandler(this.FRMAdministracion_Load);
            this.grpModo.ResumeLayout(false);
            this.grpModo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.grpFiltroPrecio.ResumeLayout(false);
            this.grpFiltroPrecio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnFiltroElecto;
        private Button button1;
        private Button button2;
        private GroupBox grpModo;
        private RadioButton rdbElectro;
        private RadioButton rdbHerramientas;
        private RadioButton rdbCelular;
        private RadioButton rdbComputacion;
        private RadioButton rdbTodo;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private TextBox txtPalabraBuscar;
        private RadioButton rdbOrigen;
        private RadioButton rdbMarca;
        private Label lblCaja;
        private GroupBox groupBox2;
        private Label lblDetalle_data;
        private DataGridView dgvListaProductos;
        private DataGridViewTextBoxColumn IdProd;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private Button button3;
        private GroupBox grpFiltroPrecio;
        private Button btnFiltrarPrecio;
        private Label lblA;
        private TextBox txtHasta;
        private TextBox txtDesde;
        private Label lblEentre;
        private RadioButton rdbMenorPrecio;
        private RadioButton rdbMayorPrecio;
    }
}