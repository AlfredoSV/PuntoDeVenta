
namespace PuntoDeVenta.UsuariosForms
{
    partial class EditarUsuarioFrm
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
            this.comboBoxSucursales = new System.Windows.Forms.ComboBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.lbltIEditarProducto = new System.Windows.Forms.Label();
            this.btnSalirEditarProductos = new System.Windows.Forms.Button();
            this.comboEstatusBusqueda = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSucursales
            // 
            this.comboBoxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSucursales.FormattingEnabled = true;
            this.comboBoxSucursales.Location = new System.Drawing.Point(123, 137);
            this.comboBoxSucursales.Name = "comboBoxSucursales";
            this.comboBoxSucursales.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSucursales.TabIndex = 36;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(123, 178);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(122, 21);
            this.comboBoxRoles.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Usuario:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(124, 92);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(121, 20);
            this.txtContrasenia.TabIndex = 30;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(123, 48);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 29;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(32, 275);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 27;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // lbltIEditarProducto
            // 
            this.lbltIEditarProducto.AutoSize = true;
            this.lbltIEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltIEditarProducto.Location = new System.Drawing.Point(71, 9);
            this.lbltIEditarProducto.Name = "lbltIEditarProducto";
            this.lbltIEditarProducto.Size = new System.Drawing.Size(107, 20);
            this.lbltIEditarProducto.TabIndex = 37;
            this.lbltIEditarProducto.Text = "Editar usuario";
            // 
            // btnSalirEditarProductos
            // 
            this.btnSalirEditarProductos.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalirEditarProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirEditarProductos.Location = new System.Drawing.Point(146, 273);
            this.btnSalirEditarProductos.Name = "btnSalirEditarProductos";
            this.btnSalirEditarProductos.Size = new System.Drawing.Size(86, 25);
            this.btnSalirEditarProductos.TabIndex = 38;
            this.btnSalirEditarProductos.Text = "Salir";
            this.btnSalirEditarProductos.UseVisualStyleBackColor = false;
            this.btnSalirEditarProductos.Click += new System.EventHandler(this.btnSalirEditarProductos_Click);
            // 
            // comboEstatusBusqueda
            // 
            this.comboEstatusBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstatusBusqueda.FormattingEnabled = true;
            this.comboEstatusBusqueda.Location = new System.Drawing.Point(123, 227);
            this.comboEstatusBusqueda.Name = "comboEstatusBusqueda";
            this.comboEstatusBusqueda.Size = new System.Drawing.Size(122, 21);
            this.comboEstatusBusqueda.TabIndex = 40;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(29, 235);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(82, 13);
            this.lblActivo.TabIndex = 39;
            this.lblActivo.Text = "Estatus usuario:";
            // 
            // EditarUsuarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(265, 314);
            this.Controls.Add(this.comboEstatusBusqueda);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.btnSalirEditarProductos);
            this.Controls.Add(this.lbltIEditarProducto);
            this.Controls.Add(this.comboBoxSucursales);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnGuardarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarUsuarioFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuarioFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSucursales;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Label lbltIEditarProducto;
        private System.Windows.Forms.Button btnSalirEditarProductos;
        private System.Windows.Forms.ComboBox comboEstatusBusqueda;
        private System.Windows.Forms.Label lblActivo;
    }
}