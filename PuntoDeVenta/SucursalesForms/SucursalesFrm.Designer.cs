
namespace PuntoDeVenta.SucursalesForms
{
    partial class SucursalesFrm
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
            this.btnSalirFormSucursales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalirFormSucursales
            // 
            this.btnSalirFormSucursales.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalirFormSucursales.Location = new System.Drawing.Point(720, 12);
            this.btnSalirFormSucursales.Name = "btnSalirFormSucursales";
            this.btnSalirFormSucursales.Size = new System.Drawing.Size(75, 23);
            this.btnSalirFormSucursales.TabIndex = 11;
            this.btnSalirFormSucursales.Text = "Salir";
            this.btnSalirFormSucursales.UseVisualStyleBackColor = false;
            this.btnSalirFormSucursales.Click += new System.EventHandler(this.btnSalirFormSucursales_Click);
            // 
            // SucursalesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 326);
            this.Controls.Add(this.btnSalirFormSucursales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SucursalesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SucursalesFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirFormSucursales;
    }
}