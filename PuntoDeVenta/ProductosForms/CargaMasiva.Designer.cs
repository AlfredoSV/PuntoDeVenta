
namespace PuntoDeVenta.ProductosForms
{
    partial class CargaMasiva
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProductosCargados = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.btnSalirCargaMasiva = new System.Windows.Forms.Button();
            this.btnConfirmarCarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosCargados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Carga másiva de productos";
            // 
            // dataGridViewProductosCargados
            // 
            this.dataGridViewProductosCargados.AllowUserToAddRows = false;
            this.dataGridViewProductosCargados.AllowUserToDeleteRows = false;
            this.dataGridViewProductosCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductosCargados.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewProductosCargados.Name = "dataGridViewProductosCargados";
            this.dataGridViewProductosCargados.ReadOnly = true;
            this.dataGridViewProductosCargados.Size = new System.Drawing.Size(715, 292);
            this.dataGridViewProductosCargados.TabIndex = 24;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(12, 44);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(121, 23);
            this.btnSeleccionarArchivo.TabIndex = 25;
            this.btnSeleccionarArchivo.Text = "Seleccionar archivo";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = false;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // btnSalirCargaMasiva
            // 
            this.btnSalirCargaMasiva.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalirCargaMasiva.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirCargaMasiva.Location = new System.Drawing.Point(641, 42);
            this.btnSalirCargaMasiva.Name = "btnSalirCargaMasiva";
            this.btnSalirCargaMasiva.Size = new System.Drawing.Size(86, 25);
            this.btnSalirCargaMasiva.TabIndex = 27;
            this.btnSalirCargaMasiva.Text = "Salir";
            this.btnSalirCargaMasiva.UseVisualStyleBackColor = false;
            this.btnSalirCargaMasiva.Click += new System.EventHandler(this.btnSalirCargaMasiva_Click);
            // 
            // btnConfirmarCarga
            // 
            this.btnConfirmarCarga.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmarCarga.Location = new System.Drawing.Point(155, 44);
            this.btnConfirmarCarga.Name = "btnConfirmarCarga";
            this.btnConfirmarCarga.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmarCarga.TabIndex = 26;
            this.btnConfirmarCarga.Text = "Confirmar carga";
            this.btnConfirmarCarga.UseVisualStyleBackColor = false;
            this.btnConfirmarCarga.Click += new System.EventHandler(this.btnConfirmarCarga_Click);
            // 
            // CargaMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 377);
            this.Controls.Add(this.btnSalirCargaMasiva);
            this.Controls.Add(this.btnConfirmarCarga);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.dataGridViewProductosCargados);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CargaMasiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargaMasiva";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosCargados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProductosCargados;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.Button btnSalirCargaMasiva;
        private System.Windows.Forms.Button btnConfirmarCarga;
    }
}