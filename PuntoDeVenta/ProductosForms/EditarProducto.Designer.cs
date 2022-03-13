
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
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblProveedorProducto = new System.Windows.Forms.Label();
            this.lblDescripProducto = new System.Windows.Forms.Label();
            this.comboProveedorProducto = new System.Windows.Forms.ComboBox();
            this.txtStockProducto = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioProducto = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(93, 283);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(149, 23);
            this.btnGuardarProducto.TabIndex = 19;
            this.btnGuardarProducto.Text = "Guardar edición";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(12, 127);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(312, 60);
            this.txtDescripcionProducto.TabIndex = 15;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(12, 70);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 14;
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
            // comboProveedorProducto
            // 
            this.comboProveedorProducto.FormattingEnabled = true;
            this.comboProveedorProducto.Location = new System.Drawing.Point(12, 231);
            this.comboProveedorProducto.Name = "comboProveedorProducto";
            this.comboProveedorProducto.Size = new System.Drawing.Size(312, 21);
            this.comboProveedorProducto.TabIndex = 16;
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(221, 70);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(100, 20);
            this.txtStockProducto.TabIndex = 20;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(115, 70);
            this.txtPrecioProducto.Mask = "0000,000.00";
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Editar producto";
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
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 318);
            this.Controls.Add(this.lblStockProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblProveedorProducto);
            this.Controls.Add(this.lblDescripProducto);
            this.Controls.Add(this.comboProveedorProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStockProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblProveedorProducto;
        private System.Windows.Forms.Label lblDescripProducto;
        private System.Windows.Forms.ComboBox comboProveedorProducto;
        private System.Windows.Forms.NumericUpDown txtStockProducto;
        private System.Windows.Forms.MaskedTextBox txtPrecioProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
    }
}