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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMVentas));
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.grpModo = new System.Windows.Forms.GroupBox();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.lblNroCliente_data = new System.Windows.Forms.Label();
            this.lblDineroDisponible_data = new System.Windows.Forms.Label();
            this.lblDineroDisponible = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.grpCarrito = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblTotalCarrito_data = new System.Windows.Forms.Label();
            this.lblTotalCarrito = new System.Windows.Forms.Label();
            this.ltbCarrito = new System.Windows.Forms.ListBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpCaja = new System.Windows.Forms.GroupBox();
            this.lblCajaDinero_data = new System.Windows.Forms.Label();
            this.lblCumplir_data = new System.Windows.Forms.Label();
            this.lblActivo_data = new System.Windows.Forms.Label();
            this.lblVendedor_data = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Button();
            this.lblSiguiente = new System.Windows.Forms.Button();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblCumplir = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.picElectroStore = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnFiltroTodo = new System.Windows.Forms.Button();
            this.btnFiltroHerra = new System.Windows.Forms.Button();
            this.btnFiltroCelular = new System.Windows.Forms.Button();
            this.btnFiltroElecto = new System.Windows.Forms.Button();
            this.btnFiltroComp = new System.Windows.Forms.Button();
            this.btnDetalleProducto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrTiempoActivo = new System.Windows.Forms.Timer(this.components);
            this.grpCliente.SuspendLayout();
            this.grpModo.SuspendLayout();
            this.grpCarrito.SuspendLayout();
            this.grpCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElectroStore)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.grpModo);
            this.grpCliente.Controls.Add(this.lblNroCliente_data);
            this.grpCliente.Controls.Add(this.lblDineroDisponible_data);
            this.grpCliente.Controls.Add(this.lblDineroDisponible);
            this.grpCliente.Controls.Add(this.lblNroCliente);
            this.grpCliente.ForeColor = System.Drawing.Color.White;
            this.grpCliente.Location = new System.Drawing.Point(953, 14);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(253, 142);
            this.grpCliente.TabIndex = 1;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Credito Disponible";
            // 
            // grpModo
            // 
            this.grpModo.Controls.Add(this.rdbCredito);
            this.grpModo.Controls.Add(this.rdbEfectivo);
            this.grpModo.ForeColor = System.Drawing.Color.White;
            this.grpModo.Location = new System.Drawing.Point(15, 72);
            this.grpModo.Name = "grpModo";
            this.grpModo.Size = new System.Drawing.Size(225, 53);
            this.grpModo.TabIndex = 23;
            this.grpModo.TabStop = false;
            this.grpModo.Text = "Modo de pago";
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(126, 22);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(64, 19);
            this.rdbCredito.TabIndex = 1;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(21, 22);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(67, 19);
            this.rdbEfectivo.TabIndex = 0;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblNroCliente_data
            // 
            this.lblNroCliente_data.AutoSize = true;
            this.lblNroCliente_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroCliente_data.ForeColor = System.Drawing.Color.White;
            this.lblNroCliente_data.Location = new System.Drawing.Point(104, 22);
            this.lblNroCliente_data.Name = "lblNroCliente_data";
            this.lblNroCliente_data.Size = new System.Drawing.Size(14, 21);
            this.lblNroCliente_data.TabIndex = 21;
            this.lblNroCliente_data.Text = ".";
            this.lblNroCliente_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDineroDisponible_data
            // 
            this.lblDineroDisponible_data.AutoSize = true;
            this.lblDineroDisponible_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDineroDisponible_data.ForeColor = System.Drawing.Color.White;
            this.lblDineroDisponible_data.Location = new System.Drawing.Point(104, 43);
            this.lblDineroDisponible_data.Name = "lblDineroDisponible_data";
            this.lblDineroDisponible_data.Size = new System.Drawing.Size(14, 21);
            this.lblDineroDisponible_data.TabIndex = 20;
            this.lblDineroDisponible_data.Text = ".";
            this.lblDineroDisponible_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDineroDisponible
            // 
            this.lblDineroDisponible.AutoSize = true;
            this.lblDineroDisponible.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDineroDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDineroDisponible.Location = new System.Drawing.Point(36, 43);
            this.lblDineroDisponible.Name = "lblDineroDisponible";
            this.lblDineroDisponible.Size = new System.Drawing.Size(62, 21);
            this.lblDineroDisponible.TabIndex = 14;
            this.lblDineroDisponible.Text = "Dinero";
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroCliente.Location = new System.Drawing.Point(6, 22);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(92, 21);
            this.lblNroCliente.TabIndex = 13;
            this.lblNroCliente.Text = "Nº Cliente ";
            this.lblNroCliente.Click += new System.EventHandler(this.label4_Click);
            // 
            // grpCarrito
            // 
            this.grpCarrito.Controls.Add(this.btnBorrar);
            this.grpCarrito.Controls.Add(this.lblTotalCarrito_data);
            this.grpCarrito.Controls.Add(this.lblTotalCarrito);
            this.grpCarrito.Controls.Add(this.ltbCarrito);
            this.grpCarrito.Controls.Add(this.btnVender);
            this.grpCarrito.Controls.Add(this.btnCancelar);
            this.grpCarrito.ForeColor = System.Drawing.Color.White;
            this.grpCarrito.Location = new System.Drawing.Point(953, 162);
            this.grpCarrito.Name = "grpCarrito";
            this.grpCarrito.Size = new System.Drawing.Size(253, 352);
            this.grpCarrito.TabIndex = 2;
            this.grpCarrito.TabStop = false;
            this.grpCarrito.Text = "Carrito de compra";
            this.grpCarrito.Enter += new System.EventHandler(this.grpCliente_Enter);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(22, 282);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(212, 27);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar Carrito";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblTotalCarrito_data
            // 
            this.lblTotalCarrito_data.AutoSize = true;
            this.lblTotalCarrito_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCarrito_data.ForeColor = System.Drawing.Color.White;
            this.lblTotalCarrito_data.Location = new System.Drawing.Point(97, 215);
            this.lblTotalCarrito_data.Name = "lblTotalCarrito_data";
            this.lblTotalCarrito_data.Size = new System.Drawing.Size(19, 21);
            this.lblTotalCarrito_data.TabIndex = 18;
            this.lblTotalCarrito_data.Text = "0";
            this.lblTotalCarrito_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCarrito
            // 
            this.lblTotalCarrito.AutoSize = true;
            this.lblTotalCarrito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalCarrito.Location = new System.Drawing.Point(22, 215);
            this.lblTotalCarrito.Name = "lblTotalCarrito";
            this.lblTotalCarrito.Size = new System.Drawing.Size(56, 21);
            this.lblTotalCarrito.TabIndex = 14;
            this.lblTotalCarrito.Text = "Total :";
            // 
            // ltbCarrito
            // 
            this.ltbCarrito.FormattingEnabled = true;
            this.ltbCarrito.ItemHeight = 15;
            this.ltbCarrito.Location = new System.Drawing.Point(6, 31);
            this.ltbCarrito.Name = "ltbCarrito";
            this.ltbCarrito.Size = new System.Drawing.Size(241, 169);
            this.ltbCarrito.TabIndex = 11;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(22, 251);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(212, 27);
            this.btnVender.TabIndex = 9;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(22, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(212, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar Venta";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpCaja
            // 
            this.grpCaja.Controls.Add(this.lblCajaDinero_data);
            this.grpCaja.Controls.Add(this.lblCumplir_data);
            this.grpCaja.Controls.Add(this.lblActivo_data);
            this.grpCaja.Controls.Add(this.lblVendedor_data);
            this.grpCaja.Controls.Add(this.lblHistorial);
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
            // lblCajaDinero_data
            // 
            this.lblCajaDinero_data.AutoSize = true;
            this.lblCajaDinero_data.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCajaDinero_data.ForeColor = System.Drawing.Color.White;
            this.lblCajaDinero_data.Location = new System.Drawing.Point(91, 318);
            this.lblCajaDinero_data.Name = "lblCajaDinero_data";
            this.lblCajaDinero_data.Size = new System.Drawing.Size(19, 30);
            this.lblCajaDinero_data.TabIndex = 18;
            this.lblCajaDinero_data.Text = ".";
            this.lblCajaDinero_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCajaDinero_data.Click += new System.EventHandler(this.lblCajaDinero_data_Click);
            // 
            // lblCumplir_data
            // 
            this.lblCumplir_data.AutoSize = true;
            this.lblCumplir_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCumplir_data.ForeColor = System.Drawing.Color.White;
            this.lblCumplir_data.Location = new System.Drawing.Point(122, 219);
            this.lblCumplir_data.Name = "lblCumplir_data";
            this.lblCumplir_data.Size = new System.Drawing.Size(18, 21);
            this.lblCumplir_data.TabIndex = 17;
            this.lblCumplir_data.Text = ". ";
            this.lblCumplir_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActivo_data
            // 
            this.lblActivo_data.AutoSize = true;
            this.lblActivo_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivo_data.ForeColor = System.Drawing.Color.White;
            this.lblActivo_data.Location = new System.Drawing.Point(122, 199);
            this.lblActivo_data.Name = "lblActivo_data";
            this.lblActivo_data.Size = new System.Drawing.Size(14, 21);
            this.lblActivo_data.TabIndex = 16;
            this.lblActivo_data.Text = ".";
            this.lblActivo_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVendedor_data
            // 
            this.lblVendedor_data.AutoSize = true;
            this.lblVendedor_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor_data.ForeColor = System.Drawing.Color.White;
            this.lblVendedor_data.Location = new System.Drawing.Point(122, 178);
            this.lblVendedor_data.Name = "lblVendedor_data";
            this.lblVendedor_data.Size = new System.Drawing.Size(14, 21);
            this.lblVendedor_data.TabIndex = 14;
            this.lblVendedor_data.Text = ".";
            this.lblVendedor_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHistorial
            // 
            this.lblHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.lblHistorial.FlatAppearance.BorderSize = 0;
            this.lblHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial.ForeColor = System.Drawing.Color.White;
            this.lblHistorial.Location = new System.Drawing.Point(6, 445);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(278, 40);
            this.lblHistorial.TabIndex = 12;
            this.lblHistorial.Text = "Ver Historial de Ventas";
            this.lblHistorial.UseVisualStyleBackColor = false;
            this.lblHistorial.Click += new System.EventHandler(this.lblFinalizar_Click);
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
            this.lblSiguiente.Click += new System.EventHandler(this.lblSiguiente_Click);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.Location = new System.Drawing.Point(372, 456);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(136, 29);
            this.txtCantidad.TabIndex = 20;
            this.txtCantidad.Text = "0";
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
            this.btnFiltroTodo.Click += new System.EventHandler(this.btnFiltroTodo_Click);
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
            this.btnFiltroHerra.Click += new System.EventHandler(this.btnFiltroHerra_Click);
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
            this.btnFiltroCelular.Click += new System.EventHandler(this.btnFiltroCelular_Click);
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
            this.btnFiltroElecto.Text = "Filtrar Electro domésticos";
            this.btnFiltroElecto.UseVisualStyleBackColor = false;
            this.btnFiltroElecto.Click += new System.EventHandler(this.btnFiltroElecto_Click);
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
            this.btnFiltroComp.Text = "Filtrar Computación";
            this.btnFiltroComp.UseVisualStyleBackColor = false;
            this.btnFiltroComp.Click += new System.EventHandler(this.btnFiltroComp_Click);
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
            this.btnDetalleProducto.Click += new System.EventHandler(this.btnDetalleProducto_Click);
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.dgvListaProductos.Location = new System.Drawing.Point(6, 89);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowTemplate.Height = 25;
            this.dgvListaProductos.Size = new System.Drawing.Size(629, 315);
            this.dgvListaProductos.TabIndex = 1;
            this.dgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // tmrTiempoActivo
            // 
            this.tmrTiempoActivo.Interval = 1000;
            this.tmrTiempoActivo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRMVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1214, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCaja);
            this.Controls.Add(this.grpCarrito);
            this.Controls.Add(this.grpCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroStore Ventas";
            this.Load += new System.EventHandler(this.FRMVentas_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpModo.ResumeLayout(false);
            this.grpModo.PerformLayout();
            this.grpCarrito.ResumeLayout(false);
            this.grpCarrito.PerformLayout();
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
        private Button lblHistorial;
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
        private Label lblDineroDisponible;
        private Label lblCajaDinero_data;
        private Label lblCumplir_data;
        private Label lblActivo_data;
        private Label lblVendedor_data;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblNroCliente_data;
        private Label lblDineroDisponible_data;
        private Label lblTotalCarrito_data;
        private Label lblTotalCarrito;
        private System.Windows.Forms.Timer tmrTiempoActivo;
        private GroupBox grpModo;
        private RadioButton rdbCredito;
        private RadioButton rdbEfectivo;
        private Button btnBorrar;
        private DataGridViewTextBoxColumn IdProd;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
    }
}