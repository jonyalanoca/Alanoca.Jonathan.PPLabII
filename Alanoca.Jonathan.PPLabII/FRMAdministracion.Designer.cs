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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAdministracion));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpModo = new System.Windows.Forms.GroupBox();
            this.rdbElectro = new System.Windows.Forms.RadioButton();
            this.rdbHerramientas = new System.Windows.Forms.RadioButton();
            this.rdbCelular = new System.Windows.Forms.RadioButton();
            this.rdbComputacion = new System.Windows.Forms.RadioButton();
            this.rdbTodo = new System.Windows.Forms.RadioButton();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.lblCaja = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPalabraBuscar = new System.Windows.Forms.TextBox();
            this.rdbOrigen = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.btnDetalles = new System.Windows.Forms.Button();
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
            this.grpBuscar.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.grpFiltroPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(678, 417);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(230, 34);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar ";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(678, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(230, 34);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(678, 467);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 34);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.rdbElectro.Text = "Electrodomésticos";
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
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.lblCaja);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.txtPalabraBuscar);
            this.grpBuscar.Controls.Add(this.rdbOrigen);
            this.grpBuscar.Controls.Add(this.rdbMarca);
            this.grpBuscar.ForeColor = System.Drawing.Color.White;
            this.grpBuscar.Location = new System.Drawing.Point(379, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(293, 158);
            this.grpBuscar.TabIndex = 25;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
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
            this.btnBuscar.Location = new System.Drawing.Point(60, 124);
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
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.btnDetalles);
            this.grpDetalle.Controls.Add(this.lblDetalle_data);
            this.grpDetalle.ForeColor = System.Drawing.Color.White;
            this.grpDetalle.Location = new System.Drawing.Point(677, 12);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(230, 323);
            this.grpDetalle.TabIndex = 26;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle del producto";
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetalles.ForeColor = System.Drawing.Color.White;
            this.btnDetalles.Location = new System.Drawing.Point(27, 268);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(182, 49);
            this.btnDetalles.TabIndex = 28;
            this.btnDetalles.Text = "Ver detalle del producto";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.button3_Click_1);
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
            this.dgvListaProductos.AllowUserToAddRows = false;
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
            this.Categoria.HeaderText = "Categoría";
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
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpModo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroStore Administración";
            this.Load += new System.EventHandler(this.FRMAdministracion_Load);
            this.grpModo.ResumeLayout(false);
            this.grpModo.PerformLayout();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.grpFiltroPrecio.ResumeLayout(false);
            this.grpFiltroPrecio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAgregar;
        private GroupBox grpModo;
        private RadioButton rdbElectro;
        private RadioButton rdbHerramientas;
        private RadioButton rdbCelular;
        private RadioButton rdbComputacion;
        private RadioButton rdbTodo;
        private GroupBox grpBuscar;
        private Button btnBuscar;
        private TextBox txtPalabraBuscar;
        private RadioButton rdbOrigen;
        private RadioButton rdbMarca;
        private Label lblCaja;
        private GroupBox grpDetalle;
        private Label lblDetalle_data;
        private DataGridView dgvListaProductos;
        private Button btnDetalles;
        private GroupBox grpFiltroPrecio;
        private Button btnFiltrarPrecio;
        private Label lblA;
        private TextBox txtHasta;
        private TextBox txtDesde;
        private Label lblEentre;
        private RadioButton rdbMenorPrecio;
        private RadioButton rdbMayorPrecio;
        private DataGridViewTextBoxColumn IdProd;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
    }
}