namespace Labo_tp1
{
    partial class FRMVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMVentas));
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.grpCarrito = new System.Windows.Forms.GroupBox();
            this.ltbCarrito = new System.Windows.Forms.ListBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpCaja = new System.Windows.Forms.GroupBox();
            this.lblFinalizar = new System.Windows.Forms.Button();
            this.lblSiguiente = new System.Windows.Forms.Button();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblCumplir = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.picElectroStore = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltroTodo = new System.Windows.Forms.Button();
            this.btnFiltroHerra = new System.Windows.Forms.Button();
            this.btnFiltroCelular = new System.Windows.Forms.Button();
            this.btnFiltroElecto = new System.Windows.Forms.Button();
            this.btnFiltroComp = new System.Windows.Forms.Button();
            this.btnDetalleProducto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblVendedor_data = new System.Windows.Forms.Label();
            this.lblActivo_data = new System.Windows.Forms.Label();
            this.lblCumplir_data = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCliente.SuspendLayout();
            this.grpCarrito.SuspendLayout();
            this.grpCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElectroStore)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblCredito);
            this.grpCliente.Controls.Add(this.lblEfectivo);
            this.grpCliente.Controls.Add(this.lblNroCliente);
            this.grpCliente.ForeColor = System.Drawing.Color.White;
            this.grpCliente.Location = new System.Drawing.Point(953, 14);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(253, 172);
            this.grpCliente.TabIndex = 1;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Credito Disponible";
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroCliente.Location = new System.Drawing.Point(6, 22);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(92, 21);
            this.lblNroCliente.TabIndex = 13;
            this.lblNroCliente.Text = "Nº Cliente ";
            this.lblNroCliente.Click += new System.EventHandler(this.label4_Click);
            // 
            // grpCarrito
            // 
            this.grpCarrito.Controls.Add(this.ltbCarrito);
            this.grpCarrito.Controls.Add(this.btnVender);
            this.grpCarrito.Controls.Add(this.btnCancelar);
            this.grpCarrito.ForeColor = System.Drawing.Color.White;
            this.grpCarrito.Location = new System.Drawing.Point(953, 192);
            this.grpCarrito.Name = "grpCarrito";
            this.grpCarrito.Size = new System.Drawing.Size(253, 322);
            this.grpCarrito.TabIndex = 2;
            this.grpCarrito.TabStop = false;
            this.grpCarrito.Text = "Carrito de compra";
            this.grpCarrito.Enter += new System.EventHandler(this.grpCliente_Enter);
            // 
            // ltbCarrito
            // 
            this.ltbCarrito.FormattingEnabled = true;
            this.ltbCarrito.ItemHeight = 15;
            this.ltbCarrito.Items.AddRange(new object[] {
            "1-qer",
            "2-asda"});
            this.ltbCarrito.Location = new System.Drawing.Point(6, 31);
            this.ltbCarrito.Name = "ltbCarrito";
            this.ltbCarrito.Size = new System.Drawing.Size(241, 184);
            this.ltbCarrito.TabIndex = 11;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(22, 221);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(212, 40);
            this.btnVender.TabIndex = 9;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(22, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(212, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar Venta";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // grpCaja
            // 
            this.grpCaja.Controls.Add(this.label4);
            this.grpCaja.Controls.Add(this.lblCumplir_data);
            this.grpCaja.Controls.Add(this.lblActivo_data);
            this.grpCaja.Controls.Add(this.lblVendedor_data);
            this.grpCaja.Controls.Add(this.lblFinalizar);
            this.grpCaja.Controls.Add(this.lblSiguiente);
            this.grpCaja.Controls.Add(this.lblCaja);
            this.grpCaja.Controls.Add(this.lblCumplir);
            this.grpCaja.Controls.Add(this.lblActivo);
            this.grpCaja.Controls.Add(this.lblVendedor);
            this.grpCaja.Controls.Add(this.picElectroStore);
            this.grpCaja.ForeColor = System.Drawing.Color.White;
            this.grpCaja.Location = new System.Drawing.Point(12, 14);
            this.grpCaja.Name = "grpCaja";
            this.grpCaja.Size = new System.Drawing.Size(290, 500);
            this.grpCaja.TabIndex = 3;
            this.grpCaja.TabStop = false;
            this.grpCaja.Text = "Caja";
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.lblFinalizar.FlatAppearance.BorderSize = 0;
            this.lblFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFinalizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalizar.ForeColor = System.Drawing.Color.White;
            this.lblFinalizar.Location = new System.Drawing.Point(6, 445);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(278, 40);
            this.lblFinalizar.TabIndex = 12;
            this.lblFinalizar.Text = "Finalizar Jornada";
            this.lblFinalizar.UseVisualStyleBackColor = false;
            this.lblFinalizar.Visible = false;
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.lblSiguiente.FlatAppearance.BorderSize = 0;
            this.lblSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSiguiente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSiguiente.ForeColor = System.Drawing.Color.White;
            this.lblSiguiente.Location = new System.Drawing.Point(6, 399);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(278, 40);
            this.lblSiguiente.TabIndex = 11;
            this.lblSiguiente.Text = "Atender al Siguiente";
            this.lblSiguiente.UseVisualStyleBackColor = false;
            this.lblSiguiente.Visible = false;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCaja.Location = new System.Drawing.Point(63, 283);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(128, 21);
            this.lblCaja.TabIndex = 4;
            this.lblCaja.Text = "Dinero en caja :";
            // 
            // lblCumplir
            // 
            this.lblCumplir.AutoSize = true;
            this.lblCumplir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCumplir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCumplir.Location = new System.Drawing.Point(20, 219);
            this.lblCumplir.Name = "lblCumplir";
            this.lblCumplir.Size = new System.Drawing.Size(90, 21);
            this.lblCumplir.TabIndex = 3;
            this.lblCumplir.Text = "T. cumplir:";
            this.lblCumplir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblActivo.Location = new System.Drawing.Point(33, 198);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(83, 21);
            this.lblActivo.TabIndex = 2;
            this.lblActivo.Text = "T. Activo: ";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVendedor.Location = new System.Drawing.Point(20, 177);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(96, 21);
            this.lblVendedor.TabIndex = 1;
            this.lblVendedor.Text = "Vendedor : ";
            this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picElectroStore
            // 
            this.picElectroStore.Image = ((System.Drawing.Image)(resources.GetObject("picElectroStore.Image")));
            this.picElectroStore.Location = new System.Drawing.Point(6, 16);
            this.picElectroStore.Name = "picElectroStore";
            this.picElectroStore.Size = new System.Drawing.Size(278, 115);
            this.picElectroStore.TabIndex = 0;
            this.picElectroStore.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.btnFiltroTodo);
            this.groupBox1.Controls.Add(this.btnFiltroHerra);
            this.groupBox1.Controls.Add(this.btnFiltroCelular);
            this.groupBox1.Controls.Add(this.btnFiltroElecto);
            this.groupBox1.Controls.Add(this.btnFiltroComp);
            this.groupBox1.Controls.Add(this.btnDetalleProducto);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.dgvListaProductos);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(308, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 500);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de productos";
            // 
            // btnFiltroTodo
            // 
            this.btnFiltroTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnFiltroTodo.FlatAppearance.BorderSize = 0;
            this.btnFiltroTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroTodo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroTodo.ForeColor = System.Drawing.Color.White;
            this.btnFiltroTodo.Location = new System.Drawing.Point(514, 22);
            this.btnFiltroTodo.Name = "btnFiltroTodo";
            this.btnFiltroTodo.Size = new System.Drawing.Size(121, 61);
            this.btnFiltroTodo.TabIndex = 19;
            this.btnFiltroTodo.Text = "Todos los productos";
            this.btnFiltroTodo.UseVisualStyleBackColor = false;
            this.btnFiltroTodo.Visible = false;
            // 
            // btnFiltroHerra
            // 
            this.btnFiltroHerra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnFiltroHerra.FlatAppearance.BorderSize = 0;
            this.btnFiltroHerra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroHerra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroHerra.ForeColor = System.Drawing.Color.White;
            this.btnFiltroHerra.Location = new System.Drawing.Point(387, 22);
            this.btnFiltroHerra.Name = "btnFiltroHerra";
            this.btnFiltroHerra.Size = new System.Drawing.Size(121, 61);
            this.btnFiltroHerra.TabIndex = 18;
            this.btnFiltroHerra.Text = "Filtrar Herramientas";
            this.btnFiltroHerra.UseVisualStyleBackColor = false;
            this.btnFiltroHerra.Visible = false;
            // 
            // btnFiltroCelular
            // 
            this.btnFiltroCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnFiltroCelular.FlatAppearance.BorderSize = 0;
            this.btnFiltroCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroCelular.ForeColor = System.Drawing.Color.White;
            this.btnFiltroCelular.Location = new System.Drawing.Point(260, 22);
            this.btnFiltroCelular.Name = "btnFiltroCelular";
            this.btnFiltroCelular.Size = new System.Drawing.Size(121, 61);
            this.btnFiltroCelular.TabIndex = 17;
            this.btnFiltroCelular.Text = "Filtrar Celulares";
            this.btnFiltroCelular.UseVisualStyleBackColor = false;
            this.btnFiltroCelular.Visible = false;
            // 
            // btnFiltroElecto
            // 
            this.btnFiltroElecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnFiltroElecto.FlatAppearance.BorderSize = 0;
            this.btnFiltroElecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroElecto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroElecto.ForeColor = System.Drawing.Color.White;
            this.btnFiltroElecto.Location = new System.Drawing.Point(133, 22);
            this.btnFiltroElecto.Name = "btnFiltroElecto";
            this.btnFiltroElecto.Size = new System.Drawing.Size(121, 61);
            this.btnFiltroElecto.TabIndex = 16;
            this.btnFiltroElecto.Text = "Filtrar Electro domesticos";
            this.btnFiltroElecto.UseVisualStyleBackColor = false;
            this.btnFiltroElecto.Visible = false;
            // 
            // btnFiltroComp
            // 
            this.btnFiltroComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnFiltroComp.FlatAppearance.BorderSize = 0;
            this.btnFiltroComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroComp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroComp.ForeColor = System.Drawing.Color.White;
            this.btnFiltroComp.Location = new System.Drawing.Point(6, 22);
            this.btnFiltroComp.Name = "btnFiltroComp";
            this.btnFiltroComp.Size = new System.Drawing.Size(121, 61);
            this.btnFiltroComp.TabIndex = 15;
            this.btnFiltroComp.Text = "Filtrar Computacion";
            this.btnFiltroComp.UseVisualStyleBackColor = false;
            this.btnFiltroComp.Visible = false;
            // 
            // btnDetalleProducto
            // 
            this.btnDetalleProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnDetalleProducto.FlatAppearance.BorderSize = 0;
            this.btnDetalleProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetalleProducto.ForeColor = System.Drawing.Color.White;
            this.btnDetalleProducto.Location = new System.Drawing.Point(6, 419);
            this.btnDetalleProducto.Name = "btnDetalleProducto";
            this.btnDetalleProducto.Size = new System.Drawing.Size(121, 66);
            this.btnDetalleProducto.TabIndex = 14;
            this.btnDetalleProducto.Text = "Detalles del producto";
            this.btnDetalleProducto.UseVisualStyleBackColor = false;
            this.btnDetalleProducto.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(512, 419);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 66);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(6, 89);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowTemplate.Height = 25;
            this.dgvListaProductos.Size = new System.Drawing.Size(627, 324);
            this.dgvListaProductos.TabIndex = 1;
            this.dgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEfectivo.Location = new System.Drawing.Point(48, 62);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(157, 21);
            this.lblEfectivo.TabIndex = 14;
            this.lblEfectivo.Text = "Efectivo disponible";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCredito.Location = new System.Drawing.Point(57, 110);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(148, 21);
            this.lblCredito.TabIndex = 15;
            this.lblCredito.Text = "Credito Dispinible";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.Location = new System.Drawing.Point(372, 456);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(136, 29);
            this.txtCantidad.TabIndex = 20;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(399, 428);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 21);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVendedor_data
            // 
            this.lblVendedor_data.AutoSize = true;
            this.lblVendedor_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor_data.ForeColor = System.Drawing.Color.White;
            this.lblVendedor_data.Location = new System.Drawing.Point(122, 178);
            this.lblVendedor_data.Name = "lblVendedor_data";
            this.lblVendedor_data.Size = new System.Drawing.Size(96, 21);
            this.lblVendedor_data.TabIndex = 14;
            this.lblVendedor_data.Text = "Vendedor : ";
            this.lblVendedor_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActivo_data
            // 
            this.lblActivo_data.AutoSize = true;
            this.lblActivo_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivo_data.ForeColor = System.Drawing.Color.White;
            this.lblActivo_data.Location = new System.Drawing.Point(122, 199);
            this.lblActivo_data.Name = "lblActivo_data";
            this.lblActivo_data.Size = new System.Drawing.Size(96, 21);
            this.lblActivo_data.TabIndex = 16;
            this.lblActivo_data.Text = "Vendedor : ";
            this.lblActivo_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCumplir_data
            // 
            this.lblCumplir_data.AutoSize = true;
            this.lblCumplir_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCumplir_data.ForeColor = System.Drawing.Color.White;
            this.lblCumplir_data.Location = new System.Drawing.Point(122, 219);
            this.lblCumplir_data.Name = "lblCumplir_data";
            this.lblCumplir_data.Size = new System.Drawing.Size(96, 21);
            this.lblCumplir_data.TabIndex = 17;
            this.lblCumplir_data.Text = "Vendedor : ";
            this.lblCumplir_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vendedor : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FRMVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1213, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCaja);
            this.Controls.Add(this.grpCarrito);
            this.Controls.Add(this.grpCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMVentas";
            this.Text = "ElectroStore Ventas";
            this.Load += new System.EventHandler(this.FRMVentas_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpCarrito.ResumeLayout(false);
            this.grpCaja.ResumeLayout(false);
            this.grpCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElectroStore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grpCliente;
        private GroupBox grpCarrito;
        private GroupBox grpCaja;
        private Button btnVender;
        private Button btnCancelar;
        private PictureBox picElectroStore;
        private Label lblCaja;
        private Label lblCumplir;
        private Label lblActivo;
        private Label lblVendedor;
        private Label lblNroCliente;
        private ListBox ltbCarrito;
        private Button lblFinalizar;
        private Button lblSiguiente;
        private GroupBox groupBox1;
        private Button btnFiltroComp;
        private Button btnDetalleProducto;
        private Button btnAgregar;
        private DataGridView dgvListaProductos;
        private Button btnFiltroTodo;
        private Button btnFiltroHerra;
        private Button btnFiltroCelular;
        private Button btnFiltroElecto;
        private Label lblCredito;
        private Label lblEfectivo;
        private Label label4;
        private Label lblCumplir_data;
        private Label lblActivo_data;
        private Label lblVendedor_data;
        private Label lblCantidad;
        private TextBox txtCantidad;
    }
}