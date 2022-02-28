
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
            this.Elimiar = new System.Windows.Forms.TabPage();
            this.Editar = new System.Windows.Forms.TabPage();
            this.Alta = new System.Windows.Forms.TabPage();
            this.tabControlProductos = new System.Windows.Forms.TabControl();
            this.btnSalirVentas = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.Detalle = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
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
            this.dataGridViewProductos.Location = new System.Drawing.Point(405, 41);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.Size = new System.Drawing.Size(383, 330);
            this.dataGridViewProductos.TabIndex = 1;
            // 
            // Elimiar
            // 
            this.Elimiar.BackColor = System.Drawing.Color.SlateGray;
            this.Elimiar.Location = new System.Drawing.Point(4, 22);
            this.Elimiar.Name = "Elimiar";
            this.Elimiar.Padding = new System.Windows.Forms.Padding(3);
            this.Elimiar.Size = new System.Drawing.Size(351, 337);
            this.Elimiar.TabIndex = 3;
            this.Elimiar.Text = "Elimiar";
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.SlateGray;
            this.Editar.Location = new System.Drawing.Point(4, 22);
            this.Editar.Name = "Editar";
            this.Editar.Padding = new System.Windows.Forms.Padding(3);
            this.Editar.Size = new System.Drawing.Size(351, 337);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar";
            // 
            // Alta
            // 
            this.Alta.BackColor = System.Drawing.Color.SlateGray;
            this.Alta.Location = new System.Drawing.Point(4, 22);
            this.Alta.Name = "Alta";
            this.Alta.Padding = new System.Windows.Forms.Padding(3);
            this.Alta.Size = new System.Drawing.Size(351, 337);
            this.Alta.TabIndex = 0;
            this.Alta.Text = "Alta";
            // 
            // tabControlProductos
            // 
            this.tabControlProductos.Controls.Add(this.Alta);
            this.tabControlProductos.Controls.Add(this.Editar);
            this.tabControlProductos.Controls.Add(this.Elimiar);
            this.tabControlProductos.Controls.Add(this.Detalle);
            this.tabControlProductos.Location = new System.Drawing.Point(12, 12);
            this.tabControlProductos.Name = "tabControlProductos";
            this.tabControlProductos.SelectedIndex = 0;
            this.tabControlProductos.Size = new System.Drawing.Size(359, 363);
            this.tabControlProductos.TabIndex = 0;
            // 
            // btnSalirVentas
            // 
            this.btnSalirVentas.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalirVentas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirVentas.Location = new System.Drawing.Point(702, 3);
            this.btnSalirVentas.Name = "btnSalirVentas";
            this.btnSalirVentas.Size = new System.Drawing.Size(86, 32);
            this.btnSalirVentas.TabIndex = 0;
            this.btnSalirVentas.Text = "Salir";
            this.btnSalirVentas.UseVisualStyleBackColor = false;
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRecargar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecargar.Location = new System.Drawing.Point(599, 3);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(86, 32);
            this.btnRecargar.TabIndex = 2;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = false;
            // 
            // Detalle
            // 
            this.Detalle.BackColor = System.Drawing.Color.SlateGray;
            this.Detalle.Location = new System.Drawing.Point(4, 22);
            this.Detalle.Name = "Detalle";
            this.Detalle.Padding = new System.Windows.Forms.Padding(3);
            this.Detalle.Size = new System.Drawing.Size(351, 337);
            this.Detalle.TabIndex = 4;
            this.Detalle.Text = "Detalle";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnSalirVentas);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.tabControlProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.tabControlProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TabPage Elimiar;
        private System.Windows.Forms.TabPage Editar;
        private System.Windows.Forms.TabPage Alta;
        private System.Windows.Forms.TabControl tabControlProductos;
        private System.Windows.Forms.Button btnSalirVentas;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.TabPage Detalle;
    }
}