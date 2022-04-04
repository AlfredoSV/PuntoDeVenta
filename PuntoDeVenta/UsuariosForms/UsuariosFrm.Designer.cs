
namespace PuntoDeVenta.UsuariosForms
{
    partial class UsuariosFrm
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
            this.btnAvanzarPag = new System.Windows.Forms.Button();
            this.btnRegresarPag = new System.Windows.Forms.Button();
            this.txtPagActual = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtPaginasTotalesProductos = new System.Windows.Forms.TextBox();
            this.lblAuxFormProductos = new System.Windows.Forms.Label();
            this.lblPginacionProductos = new System.Windows.Forms.Label();
            this.btnRecargarUsuarios = new System.Windows.Forms.Button();
            this.btnSalirUsuario = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.tabControlProductos = new System.Windows.Forms.TabControl();
            this.Alta = new System.Windows.Forms.TabPage();
            this.comboBoxSucursales = new System.Windows.Forms.ComboBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLimpiarFormUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.comboEstatusBusqueda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.tabControlProductos.SuspendLayout();
            this.Alta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvanzarPag
            // 
            this.btnAvanzarPag.Location = new System.Drawing.Point(365, 50);
            this.btnAvanzarPag.Name = "btnAvanzarPag";
            this.btnAvanzarPag.Size = new System.Drawing.Size(46, 23);
            this.btnAvanzarPag.TabIndex = 37;
            this.btnAvanzarPag.Text = ">>";
            this.btnAvanzarPag.UseVisualStyleBackColor = true;
            // 
            // btnRegresarPag
            // 
            this.btnRegresarPag.Location = new System.Drawing.Point(313, 50);
            this.btnRegresarPag.Name = "btnRegresarPag";
            this.btnRegresarPag.Size = new System.Drawing.Size(46, 23);
            this.btnRegresarPag.TabIndex = 36;
            this.btnRegresarPag.Text = "<<";
            this.btnRegresarPag.UseVisualStyleBackColor = true;
            // 
            // txtPagActual
            // 
            this.txtPagActual.Location = new System.Drawing.Point(313, 24);
            this.txtPagActual.Name = "txtPagActual";
            this.txtPagActual.ReadOnly = true;
            this.txtPagActual.Size = new System.Drawing.Size(98, 20);
            this.txtPagActual.TabIndex = 35;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(535, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 23);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(535, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(91, 20);
            this.txtBuscar.TabIndex = 33;
            // 
            // txtPaginasTotalesProductos
            // 
            this.txtPaginasTotalesProductos.Location = new System.Drawing.Point(444, 26);
            this.txtPaginasTotalesProductos.Name = "txtPaginasTotalesProductos";
            this.txtPaginasTotalesProductos.ReadOnly = true;
            this.txtPaginasTotalesProductos.Size = new System.Drawing.Size(71, 20);
            this.txtPaginasTotalesProductos.TabIndex = 32;
            // 
            // lblAuxFormProductos
            // 
            this.lblAuxFormProductos.AutoSize = true;
            this.lblAuxFormProductos.Location = new System.Drawing.Point(419, 30);
            this.lblAuxFormProductos.Name = "lblAuxFormProductos";
            this.lblAuxFormProductos.Size = new System.Drawing.Size(19, 13);
            this.lblAuxFormProductos.TabIndex = 31;
            this.lblAuxFormProductos.Text = "de";
            // 
            // lblPginacionProductos
            // 
            this.lblPginacionProductos.AutoSize = true;
            this.lblPginacionProductos.Location = new System.Drawing.Point(310, 8);
            this.lblPginacionProductos.Name = "lblPginacionProductos";
            this.lblPginacionProductos.Size = new System.Drawing.Size(60, 13);
            this.lblPginacionProductos.TabIndex = 30;
            this.lblPginacionProductos.Text = "Paginación";
            // 
            // btnRecargarUsuarios
            // 
            this.btnRecargarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRecargarUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecargarUsuarios.Location = new System.Drawing.Point(733, 24);
            this.btnRecargarUsuarios.Name = "btnRecargarUsuarios";
            this.btnRecargarUsuarios.Size = new System.Drawing.Size(73, 26);
            this.btnRecargarUsuarios.TabIndex = 29;
            this.btnRecargarUsuarios.Text = "Recargar";
            this.btnRecargarUsuarios.UseVisualStyleBackColor = false;
            this.btnRecargarUsuarios.Click += new System.EventHandler(this.btnRecargarUsuarios_Click);
            // 
            // btnSalirUsuario
            // 
            this.btnSalirUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalirUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirUsuario.Location = new System.Drawing.Point(812, 24);
            this.btnSalirUsuario.Name = "btnSalirUsuario";
            this.btnSalirUsuario.Size = new System.Drawing.Size(73, 28);
            this.btnSalirUsuario.TabIndex = 26;
            this.btnSalirUsuario.Text = "Salir";
            this.btnSalirUsuario.UseVisualStyleBackColor = false;
            this.btnSalirUsuario.Click += new System.EventHandler(this.btnSalirUsuario_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AllowUserToOrderColumns = true;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(313, 83);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(572, 239);
            this.dataGridViewUsuarios.TabIndex = 28;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClickAsync);
            // 
            // tabControlProductos
            // 
            this.tabControlProductos.Controls.Add(this.Alta);
            this.tabControlProductos.Location = new System.Drawing.Point(14, 14);
            this.tabControlProductos.Name = "tabControlProductos";
            this.tabControlProductos.SelectedIndex = 0;
            this.tabControlProductos.Size = new System.Drawing.Size(270, 308);
            this.tabControlProductos.TabIndex = 27;
            // 
            // Alta
            // 
            this.Alta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Alta.Controls.Add(this.comboBoxSucursales);
            this.Alta.Controls.Add(this.comboBoxRoles);
            this.Alta.Controls.Add(this.label4);
            this.Alta.Controls.Add(this.label3);
            this.Alta.Controls.Add(this.label2);
            this.Alta.Controls.Add(this.label1);
            this.Alta.Controls.Add(this.txtContrasenia);
            this.Alta.Controls.Add(this.txtUsuario);
            this.Alta.Controls.Add(this.btnLimpiarFormUsuario);
            this.Alta.Controls.Add(this.btnGuardarUsuario);
            this.Alta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Alta.Location = new System.Drawing.Point(4, 22);
            this.Alta.Name = "Alta";
            this.Alta.Padding = new System.Windows.Forms.Padding(3);
            this.Alta.Size = new System.Drawing.Size(262, 282);
            this.Alta.TabIndex = 0;
            this.Alta.Text = "Alta";
            // 
            // comboBoxSucursales
            // 
            this.comboBoxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSucursales.FormattingEnabled = true;
            this.comboBoxSucursales.Location = new System.Drawing.Point(102, 125);
            this.comboBoxSucursales.Name = "comboBoxSucursales";
            this.comboBoxSucursales.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSucursales.TabIndex = 26;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(103, 174);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoles.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuario:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(104, 73);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(120, 20);
            this.txtContrasenia.TabIndex = 20;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(104, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 20);
            this.txtUsuario.TabIndex = 19;
            // 
            // btnLimpiarFormUsuario
            // 
            this.btnLimpiarFormUsuario.Location = new System.Drawing.Point(149, 235);
            this.btnLimpiarFormUsuario.Name = "btnLimpiarFormUsuario";
            this.btnLimpiarFormUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFormUsuario.TabIndex = 15;
            this.btnLimpiarFormUsuario.Text = "Limpiar";
            this.btnLimpiarFormUsuario.UseVisualStyleBackColor = true;
            this.btnLimpiarFormUsuario.Click += new System.EventHandler(this.btnLimpiarFormUsuario_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(36, 235);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 13;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // comboEstatusBusqueda
            // 
            this.comboEstatusBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstatusBusqueda.FormattingEnabled = true;
            this.comboEstatusBusqueda.Location = new System.Drawing.Point(632, 26);
            this.comboEstatusBusqueda.Name = "comboEstatusBusqueda";
            this.comboEstatusBusqueda.Size = new System.Drawing.Size(89, 21);
            this.comboEstatusBusqueda.TabIndex = 27;
            this.comboEstatusBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboEstatusBusqueda_SelectedIndexChanged);
            // 
            // UsuariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(897, 335);
            this.Controls.Add(this.comboEstatusBusqueda);
            this.Controls.Add(this.btnAvanzarPag);
            this.Controls.Add(this.btnRegresarPag);
            this.Controls.Add(this.txtPagActual);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtPaginasTotalesProductos);
            this.Controls.Add(this.lblAuxFormProductos);
            this.Controls.Add(this.lblPginacionProductos);
            this.Controls.Add(this.btnRecargarUsuarios);
            this.Controls.Add(this.btnSalirUsuario);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.tabControlProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuariosFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.tabControlProductos.ResumeLayout(false);
            this.Alta.ResumeLayout(false);
            this.Alta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvanzarPag;
        private System.Windows.Forms.Button btnRegresarPag;
        private System.Windows.Forms.TextBox txtPagActual;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtPaginasTotalesProductos;
        private System.Windows.Forms.Label lblAuxFormProductos;
        private System.Windows.Forms.Label lblPginacionProductos;
        private System.Windows.Forms.Button btnRecargarUsuarios;
        private System.Windows.Forms.Button btnSalirUsuario;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.TabControl tabControlProductos;
        private System.Windows.Forms.TabPage Alta;
        private System.Windows.Forms.Button btnLimpiarFormUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.ComboBox comboBoxSucursales;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox comboEstatusBusqueda;
    }
}