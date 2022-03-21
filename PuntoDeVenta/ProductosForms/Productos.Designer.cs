
namespace PuntoDeVenta.ProductosForms
{
    partial class Productos
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btnSalirProductos = new System.Windows.Forms.Button();
            this.btnRecargarProductos = new System.Windows.Forms.Button();
            this.lblPginacionProductos = new System.Windows.Forms.Label();
            this.lblAuxFormProductos = new System.Windows.Forms.Label();
            this.txtPaginasTotalesProductos = new System.Windows.Forms.TextBox();
            this.Alta = new System.Windows.Forms.TabPage();
            this.lblAviso = new System.Windows.Forms.Label();
            this.txtStockProducto = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioProducto = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiarFormProducto = new System.Windows.Forms.Button();
            this.btnCargarMasivaProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblProveedorProducto = new System.Windows.Forms.Label();
            this.lblDescripProducto = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.comboProveedorProducto = new System.Windows.Forms.ComboBox();
            this.tabControlProductos = new System.Windows.Forms.TabControl();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPagActual = new System.Windows.Forms.TextBox();
            this.btnRegresarPag = new System.Windows.Forms.Button();
            this.btnAvanzarPag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.Alta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockProducto)).BeginInit();
            this.tabControlProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(405, 75);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.Size = new System.Drawing.Size(561, 305);
            this.dataGridViewProductos.TabIndex = 1;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // btnSalirProductos
            // 
            this.btnSalirProductos.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalirProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirProductos.Location = new System.Drawing.Point(884, 19);
            this.btnSalirProductos.Name = "btnSalirProductos";
            this.btnSalirProductos.Size = new System.Drawing.Size(86, 25);
            this.btnSalirProductos.TabIndex = 0;
            this.btnSalirProductos.Text = "Salir";
            this.btnSalirProductos.UseVisualStyleBackColor = false;
            this.btnSalirProductos.Click += new System.EventHandler(this.btnSalirProductos_Click);
            // 
            // btnRecargarProductos
            // 
            this.btnRecargarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRecargarProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecargarProductos.Location = new System.Drawing.Point(805, 20);
            this.btnRecargarProductos.Name = "btnRecargarProductos";
            this.btnRecargarProductos.Size = new System.Drawing.Size(73, 23);
            this.btnRecargarProductos.TabIndex = 2;
            this.btnRecargarProductos.Text = "Recargar";
            this.btnRecargarProductos.UseVisualStyleBackColor = false;
            this.btnRecargarProductos.Click += new System.EventHandler(this.btnRecargarProductos_Click);
            // 
            // lblPginacionProductos
            // 
            this.lblPginacionProductos.AutoSize = true;
            this.lblPginacionProductos.Location = new System.Drawing.Point(402, 4);
            this.lblPginacionProductos.Name = "lblPginacionProductos";
            this.lblPginacionProductos.Size = new System.Drawing.Size(60, 13);
            this.lblPginacionProductos.TabIndex = 18;
            this.lblPginacionProductos.Text = "Paginación";
            // 
            // lblAuxFormProductos
            // 
            this.lblAuxFormProductos.AutoSize = true;
            this.lblAuxFormProductos.Location = new System.Drawing.Point(511, 26);
            this.lblAuxFormProductos.Name = "lblAuxFormProductos";
            this.lblAuxFormProductos.Size = new System.Drawing.Size(19, 13);
            this.lblAuxFormProductos.TabIndex = 19;
            this.lblAuxFormProductos.Text = "de";
            // 
            // txtPaginasTotalesProductos
            // 
            this.txtPaginasTotalesProductos.Location = new System.Drawing.Point(536, 22);
            this.txtPaginasTotalesProductos.Name = "txtPaginasTotalesProductos";
            this.txtPaginasTotalesProductos.ReadOnly = true;
            this.txtPaginasTotalesProductos.Size = new System.Drawing.Size(71, 20);
            this.txtPaginasTotalesProductos.TabIndex = 20;
            // 
            // Alta
            // 
            this.Alta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Alta.Controls.Add(this.lblAviso);
            this.Alta.Controls.Add(this.txtStockProducto);
            this.Alta.Controls.Add(this.txtPrecioProducto);
            this.Alta.Controls.Add(this.btnLimpiarFormProducto);
            this.Alta.Controls.Add(this.btnCargarMasivaProducto);
            this.Alta.Controls.Add(this.btnGuardarProducto);
            this.Alta.Controls.Add(this.txtDescripcionProducto);
            this.Alta.Controls.Add(this.txtNombreProducto);
            this.Alta.Controls.Add(this.lblProveedorProducto);
            this.Alta.Controls.Add(this.lblDescripProducto);
            this.Alta.Controls.Add(this.lblStockProducto);
            this.Alta.Controls.Add(this.lblPrecioProducto);
            this.Alta.Controls.Add(this.lblNombreProducto);
            this.Alta.Controls.Add(this.comboProveedorProducto);
            this.Alta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Alta.Location = new System.Drawing.Point(4, 22);
            this.Alta.Name = "Alta";
            this.Alta.Padding = new System.Windows.Forms.Padding(3);
            this.Alta.Size = new System.Drawing.Size(351, 342);
            this.Alta.TabIndex = 0;
            this.Alta.Text = "Alta";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(23, 312);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(298, 13);
            this.lblAviso.TabIndex = 18;
            this.lblAviso.Text = "Actualmente no tiene el permiso para acceder a esta sección.";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(231, 51);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(100, 20);
            this.txtStockProducto.TabIndex = 17;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(125, 51);
            this.txtPrecioProducto.Mask = "0000,000.00";
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 16;
            // 
            // btnLimpiarFormProducto
            // 
            this.btnLimpiarFormProducto.Location = new System.Drawing.Point(256, 277);
            this.btnLimpiarFormProducto.Name = "btnLimpiarFormProducto";
            this.btnLimpiarFormProducto.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFormProducto.TabIndex = 15;
            this.btnLimpiarFormProducto.Text = "Limpiar";
            this.btnLimpiarFormProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarFormProducto.Click += new System.EventHandler(this.btnLimpiarFormProducto_Click);
            // 
            // btnCargarMasivaProducto
            // 
            this.btnCargarMasivaProducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCargarMasivaProducto.Location = new System.Drawing.Point(110, 277);
            this.btnCargarMasivaProducto.Name = "btnCargarMasivaProducto";
            this.btnCargarMasivaProducto.Size = new System.Drawing.Size(130, 23);
            this.btnCargarMasivaProducto.TabIndex = 14;
            this.btnCargarMasivaProducto.Text = "Realizar carga másiva";
            this.btnCargarMasivaProducto.UseVisualStyleBackColor = true;
            this.btnCargarMasivaProducto.Click += new System.EventHandler(this.btnCargarMasivaProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(19, 277);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProducto.TabIndex = 13;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(19, 108);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(312, 60);
            this.txtDescripcionProducto.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(19, 51);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // lblProveedorProducto
            // 
            this.lblProveedorProducto.AutoSize = true;
            this.lblProveedorProducto.Location = new System.Drawing.Point(23, 196);
            this.lblProveedorProducto.Name = "lblProveedorProducto";
            this.lblProveedorProducto.Size = new System.Drawing.Size(59, 13);
            this.lblProveedorProducto.TabIndex = 11;
            this.lblProveedorProducto.Text = "Proveedor:";
            // 
            // lblDescripProducto
            // 
            this.lblDescripProducto.AutoSize = true;
            this.lblDescripProducto.Location = new System.Drawing.Point(16, 92);
            this.lblDescripProducto.Name = "lblDescripProducto";
            this.lblDescripProducto.Size = new System.Drawing.Size(66, 13);
            this.lblDescripProducto.TabIndex = 9;
            this.lblDescripProducto.Text = "Descripción:";
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Location = new System.Drawing.Point(228, 35);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(38, 13);
            this.lblStockProducto.TabIndex = 8;
            this.lblStockProducto.Text = "Stock:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(125, 35);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioProducto.TabIndex = 7;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(16, 35);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(47, 13);
            this.lblNombreProducto.TabIndex = 6;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // comboProveedorProducto
            // 
            this.comboProveedorProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProveedorProducto.FormattingEnabled = true;
            this.comboProveedorProducto.Location = new System.Drawing.Point(19, 212);
            this.comboProveedorProducto.Name = "comboProveedorProducto";
            this.comboProveedorProducto.Size = new System.Drawing.Size(312, 21);
            this.comboProveedorProducto.TabIndex = 4;
            // 
            // tabControlProductos
            // 
            this.tabControlProductos.Controls.Add(this.Alta);
            this.tabControlProductos.Location = new System.Drawing.Point(12, 12);
            this.tabControlProductos.Name = "tabControlProductos";
            this.tabControlProductos.SelectedIndex = 0;
            this.tabControlProductos.Size = new System.Drawing.Size(359, 368);
            this.tabControlProductos.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(627, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(91, 20);
            this.txtBuscar.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(724, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPagActual
            // 
            this.txtPagActual.Location = new System.Drawing.Point(405, 20);
            this.txtPagActual.Name = "txtPagActual";
            this.txtPagActual.ReadOnly = true;
            this.txtPagActual.Size = new System.Drawing.Size(98, 20);
            this.txtPagActual.TabIndex = 23;
            // 
            // btnRegresarPag
            // 
            this.btnRegresarPag.Location = new System.Drawing.Point(405, 46);
            this.btnRegresarPag.Name = "btnRegresarPag";
            this.btnRegresarPag.Size = new System.Drawing.Size(46, 23);
            this.btnRegresarPag.TabIndex = 24;
            this.btnRegresarPag.Text = "<<";
            this.btnRegresarPag.UseVisualStyleBackColor = true;
            this.btnRegresarPag.Click += new System.EventHandler(this.btnRegresarPag_Click);
            // 
            // btnAvanzarPag
            // 
            this.btnAvanzarPag.Location = new System.Drawing.Point(457, 46);
            this.btnAvanzarPag.Name = "btnAvanzarPag";
            this.btnAvanzarPag.Size = new System.Drawing.Size(46, 23);
            this.btnAvanzarPag.TabIndex = 25;
            this.btnAvanzarPag.Text = ">>";
            this.btnAvanzarPag.UseVisualStyleBackColor = true;
            this.btnAvanzarPag.Click += new System.EventHandler(this.btnAvanzarPag_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 392);
            this.Controls.Add(this.btnAvanzarPag);
            this.Controls.Add(this.btnRegresarPag);
            this.Controls.Add(this.txtPagActual);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtPaginasTotalesProductos);
            this.Controls.Add(this.lblAuxFormProductos);
            this.Controls.Add(this.lblPginacionProductos);
            this.Controls.Add(this.btnRecargarProductos);
            this.Controls.Add(this.btnSalirProductos);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.tabControlProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.Alta.ResumeLayout(false);
            this.Alta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockProducto)).EndInit();
            this.tabControlProductos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button btnSalirProductos;
        private System.Windows.Forms.Button btnRecargarProductos;
        private System.Windows.Forms.Label lblPginacionProductos;
        private System.Windows.Forms.Label lblAuxFormProductos;
        private System.Windows.Forms.TextBox txtPaginasTotalesProductos;
        private System.Windows.Forms.TabPage Alta;
        private System.Windows.Forms.NumericUpDown txtStockProducto;
        private System.Windows.Forms.MaskedTextBox txtPrecioProducto;
        private System.Windows.Forms.Button btnLimpiarFormProducto;
        private System.Windows.Forms.Button btnCargarMasivaProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblProveedorProducto;
        private System.Windows.Forms.Label lblDescripProducto;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.ComboBox comboProveedorProducto;
        private System.Windows.Forms.TabControl tabControlProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPagActual;
        private System.Windows.Forms.Button btnRegresarPag;
        private System.Windows.Forms.Button btnAvanzarPag;
        private System.Windows.Forms.Label lblAviso;
    }
}