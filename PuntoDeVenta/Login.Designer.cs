
namespace PuntoDeVenta
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(768, 188);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(218, 22);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenia.Location = new System.Drawing.Point(768, 252);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(218, 22);
            this.txtContrasenia.TabIndex = 1;
            this.txtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasenia_KeyDown);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.Location = new System.Drawing.Point(805, 298);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(141, 36);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(835, 164);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(820, 228);
            this.lblcontraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(95, 20);
            this.lblcontraseña.TabIndex = 4;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(30, 28);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(709, 500);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 5;
            this.picBoxLogo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(972, -2);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = " X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarme.Location = new System.Drawing.Point(805, 352);
            this.btnRegistrarme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.Size = new System.Drawing.Size(141, 36);
            this.btnRegistrarme.TabIndex = 7;
            this.btnRegistrarme.Text = "Registrarme";
            this.btnRegistrarme.UseVisualStyleBackColor = false;
            this.btnRegistrarme.Click += new System.EventHandler(this.btnRegistrarme_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 567);
            this.Controls.Add(this.btnRegistrarme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar - Punto de venta";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarme;
    }
}

