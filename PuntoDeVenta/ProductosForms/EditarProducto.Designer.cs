
namespace PuntoDeVenta.ProductosForms
{
    partial class EditarProducto
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
            this.btnGuardarProductoEditado = new System.Windows.Forms.Button();
            this.txtDescripcionProductoEdi = new System.Windows.Forms.TextBox();
            this.txtNombreProductoEdi = new System.Windows.Forms.TextBox();
            this.lblProveedorProducto = new System.Windows.Forms.Label();
            this.lblDescripProducto = new System.Windows.Forms.Label();
            this.comboProveedorProductoEdi = new System.Windows.Forms.ComboBox();
            this.txtStockProductoEdi = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioProductoEdi = new System.Windows.Forms.MaskedTextBox();
            this.lbltIEditarProducto = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnSalirEditarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockProductoEdi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarProductoEditado
            // 
            this.btnGuardarProductoEditado.Location = new System.Drawing.Point(66, 282);
            this.btnGuardarProductoEditado.Name = "btnGuardarProductoEditado";
            this.btnGuardarProductoEditado.Size = new System.Drawing.Size(149, 23);
            this.btnGuardarProductoEditado.TabIndex = 19;
            this.btnGuardarProductoEditado.Text = "Guardar edición";
            this.btnGuardarProductoEditado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionProductoEdi
            // 
            this.txtDescripcionProductoEdi.Location = new System.Drawing.Point(12, 127);
            this.txtDescripcionProductoEdi.Multiline = true;
            this.txtDescripcionProductoEdi.Name = "txtDescripcionProductoEdi";
            this.txtDescripcionProductoEdi.Size = new System.Drawing.Size(312, 60);
            this.txtDescripcionProductoEdi.TabIndex = 15;
            // 
            // txtNombreProductoEdi
            // 
            this.txtNombreProductoEdi.Location = new System.Drawing.Point(12, 70);
            this.txtNombreProductoEdi.Name = "txtNombreProductoEdi";
            this.txtNombreProductoEdi.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProductoEdi.TabIndex = 14;
            // 
            // lblProveedorProducto
            // 
            this.lblProveedorProducto.AutoSize = true;
            this.lblProveedorProducto.Location = new System.Drawing.Point(16, 215);
            this.lblProveedorProducto.Name = "lblProveedorProducto";
            this.lblProveedorProducto.Size = new System.Drawing.Size(59, 13);
            this.lblProveedorProducto.TabIndex = 18;
            this.lblProveedorProducto.Text = "Proveedor:";
            // 
            // lblDescripProducto
            // 
            this.lblDescripProducto.AutoSize = true;
            this.lblDescripProducto.Location = new System.Drawing.Point(9, 111);
            this.lblDescripProducto.Name = "lblDescripProducto";
            this.lblDescripProducto.Size = new System.Drawing.Size(66, 13);
            this.lblDescripProducto.TabIndex = 17;
            this.lblDescripProducto.Text = "Descripción:";
            // 
            // comboProveedorProductoEdi
            // 
            this.comboProveedorProductoEdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProveedorProductoEdi.FormattingEnabled = true;
            this.comboProveedorProductoEdi.Location = new System.Drawing.Point(12, 231);
            this.comboProveedorProductoEdi.Name = "comboProveedorProductoEdi";
            this.comboProveedorProductoEdi.Size = new System.Drawing.Size(312, 21);
            this.comboProveedorProductoEdi.TabIndex = 16;
            // 
            // txtStockProductoEdi
            // 
            this.txtStockProductoEdi.Location = new System.Drawing.Point(221, 70);
            this.txtStockProductoEdi.Name = "txtStockProductoEdi";
            this.txtStockProductoEdi.Size = new System.Drawing.Size(100, 20);
            this.txtStockProductoEdi.TabIndex = 20;
            // 
            // txtPrecioProductoEdi
            // 
            this.txtPrecioProductoEdi.Location = new System.Drawing.Point(115, 70);
            this.txtPrecioProductoEdi.Mask = "0000,000.00";
            this.txtPrecioProductoEdi.Name = "txtPrecioProductoEdi";
            this.txtPrecioProductoEdi.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProductoEdi.TabIndex = 21;
            // 
            // lbltIEditarProducto
            // 
            this.lbltIEditarProducto.AutoSize = true;
            this.lbltIEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltIEditarProducto.Location = new System.Drawing.Point(97, 9);
            this.lbltIEditarProducto.Name = "lbltIEditarProducto";
            this.lbltIEditarProducto.Size = new System.Drawing.Size(118, 20);
            this.lbltIEditarProducto.TabIndex = 22;
            this.lbltIEditarProducto.Text = "Editar producto";
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Location = new System.Drawing.Point(218, 54);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(38, 13);
            this.lblStockProducto.TabIndex = 25;
            this.lblStockProducto.Text = "Stock:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(112, 54);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioProducto.TabIndex = 24;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(12, 54);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(47, 13);
            this.lblNombreProducto.TabIndex = 23;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // btnSalirEditarProductos
            // 
            this.btnSalirEditarProductos.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalirEditarProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirEditarProductos.Location = new System.Drawing.Point(235, 281);
            this.btnSalirEditarProductos.Name = "btnSalirEditarProductos";
            this.btnSalirEditarProductos.Size = new System.Drawing.Size(86, 25);
            this.btnSalirEditarProductos.TabIndex = 26;
            this.btnSalirEditarProductos.Text = "Salir";
            this.btnSalirEditarProductos.UseVisualStyleBackColor = false;
            this.btnSalirEditarProductos.Click += new System.EventHandler(this.btnSalirEditarProductos_Click);
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 318);
            this.Controls.Add(this.btnSalirEditarProductos);
            this.Controls.Add(this.lblStockProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lbltIEditarProducto);
            this.Controls.Add(this.txtPrecioProductoEdi);
            this.Controls.Add(this.txtStockProductoEdi);
            this.Controls.Add(this.btnGuardarProductoEditado);
            this.Controls.Add(this.txtDescripcionProductoEdi);
            this.Controls.Add(this.txtNombreProductoEdi);
            this.Controls.Add(this.lblProveedorProducto);
            this.Controls.Add(this.lblDescripProducto);
            this.Controls.Add(this.comboProveedorProductoEdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStockProductoEdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarProductoEditado;
        private System.Windows.Forms.TextBox txtDescripcionProductoEdi;
        private System.Windows.Forms.TextBox txtNombreProductoEdi;
        private System.Windows.Forms.Label lblProveedorProducto;
        private System.Windows.Forms.Label lblDescripProducto;
        private System.Windows.Forms.ComboBox comboProveedorProductoEdi;
        private System.Windows.Forms.NumericUpDown txtStockProductoEdi;
        private System.Windows.Forms.MaskedTextBox txtPrecioProductoEdi;
        private System.Windows.Forms.Label lbltIEditarProducto;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnSalirEditarProductos;
    }
}