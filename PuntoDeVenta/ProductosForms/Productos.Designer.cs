
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
            this.dataGridViewProductos.Location = new System.Drawing.Point(540, 92);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.Size = new System.Drawing.Size(901, 375);
            this.dataGridViewProductos.TabIndex = 1;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // btnRecargarProductos
            // 
            this.btnRecargarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRecargarProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecargarProductos.Location = new System.Drawing.Point(1324, 28);
            this.btnRecargarProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecargarProductos.Name = "btnRecargarProductos";
            this.btnRecargarProductos.Size = new System.Drawing.Size(117, 28);
            this.btnRecargarProductos.TabIndex = 2;
            this.btnRecargarProductos.Text = "Recargar";
            this.btnRecargarProductos.UseVisualStyleBackColor = false;
            this.btnRecargarProductos.Click += new System.EventHandler(this.btnRecargarProductos_Click);
            // 
            // lblPginacionProductos
            // 
            this.lblPginacionProductos.AutoSize = true;
            this.lblPginacionProductos.Location = new System.Drawing.Point(536, 5);
            this.lblPginacionProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPginacionProductos.Name = "lblPginacionProductos";
            this.lblPginacionProductos.Size = new System.Drawing.Size(78, 17);
            this.lblPginacionProductos.TabIndex = 18;
            this.lblPginacionProductos.Text = "Paginación";
            // 
            // lblAuxFormProductos
            // 
            this.lblAuxFormProductos.AutoSize = true;
            this.lblAuxFormProductos.Location = new System.Drawing.Point(681, 32);
            this.lblAuxFormProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuxFormProductos.Name = "lblAuxFormProductos";
            this.lblAuxFormProductos.Size = new System.Drawing.Size(24, 17);
            this.lblAuxFormProductos.TabIndex = 19;
            this.lblAuxFormProductos.Text = "de";
            // 
            // txtPaginasTotalesProductos
            // 
            this.txtPaginasTotalesProductos.Location = new System.Drawing.Point(715, 27);
            this.txtPaginasTotalesProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaginasTotalesProductos.Name = "txtPaginasTotalesProductos";
            this.txtPaginasTotalesProductos.ReadOnly = true;
            this.txtPaginasTotalesProductos.Size = new System.Drawing.Size(93, 22);
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
            this.Alta.Location = new System.Drawing.Point(4, 25);
            this.Alta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Alta.Name = "Alta";
            this.Alta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Alta.Size = new System.Drawing.Size(471, 424);
            this.Alta.TabIndex = 0;
            this.Alta.Text = "Alta";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(31, 384);
            this.lblAviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(397, 17);
            this.lblAviso.TabIndex = 18;
            this.lblAviso.Text = "Actualmente no tiene el permiso para acceder a esta sección.";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(308, 63);
            this.txtStockProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(133, 22);
            this.txtStockProducto.TabIndex = 17;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(167, 63);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioProducto.TabIndex = 16;
            // 
            // btnLimpiarFormProducto
            // 
            this.btnLimpiarFormProducto.Location = new System.Drawing.Point(341, 341);
            this.btnLimpiarFormProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarFormProducto.Name = "btnLimpiarFormProducto";
            this.btnLimpiarFormProducto.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiarFormProducto.TabIndex = 15;
            this.btnLimpiarFormProducto.Text = "Limpiar";
            this.btnLimpiarFormProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarFormProducto.Click += new System.EventHandler(this.btnLimpiarFormProducto_Click);
            // 
            // btnCargarMasivaProducto
            // 
            this.btnCargarMasivaProducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCargarMasivaProducto.Location = new System.Drawing.Point(147, 341);
            this.btnCargarMasivaProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarMasivaProducto.Name = "btnCargarMasivaProducto";
            this.btnCargarMasivaProducto.Size = new System.Drawing.Size(173, 28);
            this.btnCargarMasivaProducto.TabIndex = 14;
            this.btnCargarMasivaProducto.Text = "Realizar carga másiva";
            this.btnCargarMasivaProducto.UseVisualStyleBackColor = true;
            this.btnCargarMasivaProducto.Click += new System.EventHandler(this.btnCargarMasivaProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(25, 341);
            this.btnGuardarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarProducto.TabIndex = 13;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(25, 133);
            this.txtDescripcionProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(415, 73);
            this.txtDescripcionProducto.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(25, 63);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(132, 22);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // lblProveedorProducto
            // 
            this.lblProveedorProducto.AutoSize = true;
            this.lblProveedorProducto.Location = new System.Drawing.Point(31, 241);
            this.lblProveedorProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedorProducto.Name = "lblProveedorProducto";
            this.lblProveedorProducto.Size = new System.Drawing.Size(78, 17);
            this.lblProveedorProducto.TabIndex = 11;
            this.lblProveedorProducto.Text = "Proveedor:";
            // 
            // lblDescripProducto
            // 
            this.lblDescripProducto.AutoSize = true;
            this.lblDescripProducto.Location = new System.Drawing.Point(21, 113);
            this.lblDescripProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripProducto.Name = "lblDescripProducto";
            this.lblDescripProducto.Size = new System.Drawing.Size(86, 17);
            this.lblDescripProducto.TabIndex = 9;
            this.lblDescripProducto.Text = "Descripción:";
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Location = new System.Drawing.Point(304, 43);
            this.lblStockProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(47, 17);
            this.lblStockProducto.TabIndex = 8;
            this.lblStockProducto.Text = "Stock:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(167, 43);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(52, 17);
            this.lblPrecioProducto.TabIndex = 7;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(21, 43);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(62, 17);
            this.lblNombreProducto.TabIndex = 6;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // comboProveedorProducto
            // 
            this.comboProveedorProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProveedorProducto.FormattingEnabled = true;
            this.comboProveedorProducto.Location = new System.Drawing.Point(25, 261);
            this.comboProveedorProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboProveedorProducto.Name = "comboProveedorProducto";
            this.comboProveedorProducto.Size = new System.Drawing.Size(415, 24);
            this.comboProveedorProducto.TabIndex = 4;
            // 
            // tabControlProductos
            // 
            this.tabControlProductos.Controls.Add(this.Alta);
            this.tabControlProductos.Location = new System.Drawing.Point(16, 15);
            this.tabControlProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlProductos.Name = "tabControlProductos";
            this.tabControlProductos.SelectedIndex = 0;
            this.tabControlProductos.Size = new System.Drawing.Size(479, 453);
            this.tabControlProductos.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(836, 28);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(188, 22);
            this.txtBuscar.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1049, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPagActual
            // 
            this.txtPagActual.Location = new System.Drawing.Point(540, 25);
            this.txtPagActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPagActual.Name = "txtPagActual";
            this.txtPagActual.ReadOnly = true;
            this.txtPagActual.Size = new System.Drawing.Size(129, 22);
            this.txtPagActual.TabIndex = 23;
            // 
            // btnRegresarPag
            // 
            this.btnRegresarPag.Location = new System.Drawing.Point(540, 57);
            this.btnRegresarPag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresarPag.Name = "btnRegresarPag";
            this.btnRegresarPag.Size = new System.Drawing.Size(61, 28);
            this.btnRegresarPag.TabIndex = 24;
            this.btnRegresarPag.Text = "<<";
            this.btnRegresarPag.UseVisualStyleBackColor = true;
            this.btnRegresarPag.Click += new System.EventHandler(this.btnRegresarPag_Click);
            // 
            // btnAvanzarPag
            // 
            this.btnAvanzarPag.Location = new System.Drawing.Point(609, 57);
            this.btnAvanzarPag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvanzarPag.Name = "btnAvanzarPag";
            this.btnAvanzarPag.Size = new System.Drawing.Size(61, 28);
            this.btnAvanzarPag.TabIndex = 25;
            this.btnAvanzarPag.Text = ">>";
            this.btnAvanzarPag.UseVisualStyleBackColor = true;
            this.btnAvanzarPag.Click += new System.EventHandler(this.btnAvanzarPag_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1457, 482);
            this.Controls.Add(this.btnAvanzarPag);
            this.Controls.Add(this.btnRegresarPag);
            this.Controls.Add(this.txtPagActual);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtPaginasTotalesProductos);
            this.Controls.Add(this.lblAuxFormProductos);
            this.Controls.Add(this.lblPginacionProductos);
            this.Controls.Add(this.btnRecargarProductos);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.tabControlProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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