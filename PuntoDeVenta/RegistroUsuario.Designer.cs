
namespace PuntoDeVenta
{
    partial class RegistroUsuario
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.comBRol = new System.Windows.Forms.ComboBox();
            this.comBSucursal = new System.Windows.Forms.ComboBox();
            this.btnRealizarSol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(227, 292);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 36);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(137, 65);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(229, 22);
            this.txtUsuario.TabIndex = 9;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(139, 117);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(228, 22);
            this.txtContrasenia.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(45, 69);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(45, 126);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(85, 17);
            this.lblContrasenia.TabIndex = 13;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(45, 187);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(67, 17);
            this.lblSucursal.TabIndex = 14;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(45, 238);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 17);
            this.lblRol.TabIndex = 16;
            this.lblRol.Text = "Rol:";
            // 
            // comBRol
            // 
            this.comBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBRol.FormattingEnabled = true;
            this.comBRol.Location = new System.Drawing.Point(137, 238);
            this.comBRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comBRol.Name = "comBRol";
            this.comBRol.Size = new System.Drawing.Size(229, 24);
            this.comBRol.TabIndex = 17;
            // 
            // comBSucursal
            // 
            this.comBSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBSucursal.FormattingEnabled = true;
            this.comBSucursal.Location = new System.Drawing.Point(137, 177);
            this.comBSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comBSucursal.Name = "comBSucursal";
            this.comBSucursal.Size = new System.Drawing.Size(229, 24);
            this.comBSucursal.TabIndex = 18;
            // 
            // btnRealizarSol
            // 
            this.btnRealizarSol.BackColor = System.Drawing.Color.LightGreen;
            this.btnRealizarSol.Location = new System.Drawing.Point(41, 292);
            this.btnRealizarSol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRealizarSol.Name = "btnRealizarSol";
            this.btnRealizarSol.Size = new System.Drawing.Size(145, 36);
            this.btnRealizarSol.TabIndex = 19;
            this.btnRealizarSol.Text = "Realizar Solicitud";
            this.btnRealizarSol.UseVisualStyleBackColor = false;
            this.btnRealizarSol.Click += new System.EventHandler(this.btnRealizarSol_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 368);
            this.Controls.Add(this.btnRealizarSol);
            this.Controls.Add(this.comBSucursal);
            this.Controls.Add(this.comBRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUsuario";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox comBRol;
        private System.Windows.Forms.ComboBox comBSucursal;
        private System.Windows.Forms.Button btnRealizarSol;
    }
}