namespace Labo_tp1
{
    partial class FRMEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMEditar));
            this.grpFiltroPrecio = new System.Windows.Forms.GroupBox();
            this.lblStock_data = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.tkbStock = new System.Windows.Forms.TrackBar();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnFiltrarPrecio = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.grpFiltroPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStock)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltroPrecio
            // 
            this.grpFiltroPrecio.Controls.Add(this.lblStock_data);
            this.grpFiltroPrecio.Controls.Add(this.lblStock);
            this.grpFiltroPrecio.Controls.Add(this.nupPrecio);
            this.grpFiltroPrecio.Controls.Add(this.tkbStock);
            this.grpFiltroPrecio.Controls.Add(this.cmbCategoria);
            this.grpFiltroPrecio.Controls.Add(this.btnFiltrarPrecio);
            this.grpFiltroPrecio.Controls.Add(this.lblPrecio);
            this.grpFiltroPrecio.Controls.Add(this.lblCategoria);
            this.grpFiltroPrecio.ForeColor = System.Drawing.Color.White;
            this.grpFiltroPrecio.Location = new System.Drawing.Point(12, 12);
            this.grpFiltroPrecio.Name = "grpFiltroPrecio";
            this.grpFiltroPrecio.Size = new System.Drawing.Size(426, 174);
            this.grpFiltroPrecio.TabIndex = 26;
            this.grpFiltroPrecio.TabStop = false;
            this.grpFiltroPrecio.Text = "Filtrar Precio";
            // 
            // lblStock_data
            // 
            this.lblStock_data.AutoSize = true;
            this.lblStock_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStock_data.ForeColor = System.Drawing.Color.White;
            this.lblStock_data.Location = new System.Drawing.Point(246, 97);
            this.lblStock_data.Name = "lblStock_data";
            this.lblStock_data.Size = new System.Drawing.Size(19, 21);
            this.lblStock_data.TabIndex = 36;
            this.lblStock_data.Text = "0";
            this.lblStock_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStock.Location = new System.Drawing.Point(25, 100);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(52, 21);
            this.lblStock.TabIndex = 35;
            this.lblStock.Text = "Stock";
            // 
            // nupPrecio
            // 
            this.nupPrecio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nupPrecio.Location = new System.Drawing.Point(115, 71);
            this.nupPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(150, 23);
            this.nupPrecio.TabIndex = 34;
            // 
            // tkbStock
            // 
            this.tkbStock.Location = new System.Drawing.Point(105, 100);
            this.tkbStock.Maximum = 100;
            this.tkbStock.Name = "tkbStock";
            this.tkbStock.Size = new System.Drawing.Size(150, 45);
            this.tkbStock.TabIndex = 33;
            this.tkbStock.Scroll += new System.EventHandler(this.tkbStock_Scroll);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(115, 32);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(150, 23);
            this.cmbCategoria.TabIndex = 32;
            // 
            // btnFiltrarPrecio
            // 
            this.btnFiltrarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btnFiltrarPrecio.FlatAppearance.BorderSize = 0;
            this.btnFiltrarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPrecio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarPrecio.Location = new System.Drawing.Point(282, 32);
            this.btnFiltrarPrecio.Name = "btnFiltrarPrecio";
            this.btnFiltrarPrecio.Size = new System.Drawing.Size(122, 57);
            this.btnFiltrarPrecio.TabIndex = 28;
            this.btnFiltrarPrecio.Text = "Guardar Datos";
            this.btnFiltrarPrecio.UseVisualStyleBackColor = false;
            this.btnFiltrarPrecio.Click += new System.EventHandler(this.btnFiltrarPrecio_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecio.Location = new System.Drawing.Point(25, 68);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 21);
            this.lblPrecio.TabIndex = 31;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(25, 34);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(84, 21);
            this.lblCategoria.TabIndex = 28;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblEentre_Click);
            // 
            // FRMEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(448, 192);
            this.Controls.Add(this.grpFiltroPrecio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMEditar";
            this.Load += new System.EventHandler(this.FRMEditar_Load);
            this.grpFiltroPrecio.ResumeLayout(false);
            this.grpFiltroPrecio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpFiltroPrecio;
        private Button btnFiltrarPrecio;
        private Label lblPrecio;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private TrackBar tkbStock;
        private Label lblStock;
        private NumericUpDown nupPrecio;
        private Label lblStock_data;
    }
}