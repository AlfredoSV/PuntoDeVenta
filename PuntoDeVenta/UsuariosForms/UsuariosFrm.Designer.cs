
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
            this.btnAvanzarPag.Location = new System.Drawing.Point(487, 62);
            this.btnAvanzarPag.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvanzarPag.Name = "btnAvanzarPag";
            this.btnAvanzarPag.Size = new System.Drawing.Size(61, 28);
            this.btnAvanzarPag.TabIndex = 37;
            this.btnAvanzarPag.Text = ">>";
            this.btnAvanzarPag.UseVisualStyleBackColor = true;
            this.btnAvanzarPag.Click += new System.EventHandler(this.btnAvanzarPag_Click);
            // 
            // btnRegresarPag
            // 
            this.btnRegresarPag.Location = new System.Drawing.Point(417, 62);
            this.btnRegresarPag.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarPag.Name = "btnRegresarPag";
            this.btnRegresarPag.Size = new System.Drawing.Size(61, 28);
            this.btnRegresarPag.TabIndex = 36;
            this.btnRegresarPag.Text = "<<";
            this.btnRegresarPag.UseVisualStyleBackColor = true;
            this.btnRegresarPag.Click += new System.EventHandler(this.btnRegresarPag_Click);
            // 
            // txtPagActual
            // 
            this.txtPagActual.Location = new System.Drawing.Point(417, 30);
            this.txtPagActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagActual.Name = "txtPagActual";
            this.txtPagActual.ReadOnly = true;
            this.txtPagActual.Size = new System.Drawing.Size(129, 22);
            this.txtPagActual.TabIndex = 35;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(713, 66);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 28);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(713, 33);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(120, 22);
            this.txtBuscar.TabIndex = 33;
            // 
            // txtPaginasTotalesProductos
            // 
            this.txtPaginasTotalesProductos.Location = new System.Drawing.Point(592, 32);
            this.txtPaginasTotalesProductos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaginasTotalesProductos.Name = "txtPaginasTotalesProductos";
            this.txtPaginasTotalesProductos.ReadOnly = true;
            this.txtPaginasTotalesProductos.Size = new System.Drawing.Size(93, 22);
            this.txtPaginasTotalesProductos.TabIndex = 32;
            // 
            // lblAuxFormProductos
            // 
            this.lblAuxFormProductos.AutoSize = true;
            this.lblAuxFormProductos.Location = new System.Drawing.Point(559, 37);
            this.lblAuxFormProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuxFormProductos.Name = "lblAuxFormProductos";
            this.lblAuxFormProductos.Size = new System.Drawing.Size(24, 17);
            this.lblAuxFormProductos.TabIndex = 31;
            this.lblAuxFormProductos.Text = "de";
            // 
            // lblPginacionProductos
            // 
            this.lblPginacionProductos.AutoSize = true;
            this.lblPginacionProductos.Location = new System.Drawing.Point(413, 10);
            this.lblPginacionProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPginacionProductos.Name = "lblPginacionProductos";
            this.lblPginacionProductos.Size = new System.Drawing.Size(78, 17);
            this.lblPginacionProductos.TabIndex = 30;
            this.lblPginacionProductos.Text = "Paginación";
            // 
            // btnRecargarUsuarios
            // 
            this.btnRecargarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRecargarUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecargarUsuarios.Location = new System.Drawing.Point(1086, 25);
            this.btnRecargarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecargarUsuarios.Name = "btnRecargarUsuarios";
            this.btnRecargarUsuarios.Size = new System.Drawing.Size(97, 32);
            this.btnRecargarUsuarios.TabIndex = 29;
            this.btnRecargarUsuarios.Text = "Recargar";
            this.btnRecargarUsuarios.UseVisualStyleBackColor = false;
            this.btnRecargarUsuarios.Click += new System.EventHandler(this.btnRecargarUsuarios_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AllowUserToOrderColumns = true;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(417, 102);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(763, 294);
            this.dataGridViewUsuarios.TabIndex = 28;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClickAsync);
            // 
            // tabControlProductos
            // 
            this.tabControlProductos.Controls.Add(this.Alta);
            this.tabControlProductos.Location = new System.Drawing.Point(19, 17);
            this.tabControlProductos.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlProductos.Name = "tabControlProductos";
            this.tabControlProductos.SelectedIndex = 0;
            this.tabControlProductos.Size = new System.Drawing.Size(360, 379);
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
            this.Alta.Location = new System.Drawing.Point(4, 25);
            this.Alta.Margin = new System.Windows.Forms.Padding(4);
            this.Alta.Name = "Alta";
            this.Alta.Padding = new System.Windows.Forms.Padding(4);
            this.Alta.Size = new System.Drawing.Size(352, 350);
            this.Alta.TabIndex = 0;
            this.Alta.Text = "Alta";
            // 
            // comboBoxSucursales
            // 
            this.comboBoxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSucursales.FormattingEnabled = true;
            this.comboBoxSucursales.Location = new System.Drawing.Point(136, 154);
            this.comboBoxSucursales.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSucursales.Name = "comboBoxSucursales";
            this.comboBoxSucursales.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSucursales.TabIndex = 26;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(137, 214);
            this.comboBoxRoles.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(160, 24);
            this.comboBoxRoles.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuario:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(139, 90);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(159, 22);
            this.txtContrasenia.TabIndex = 20;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(139, 25);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(159, 22);
            this.txtUsuario.TabIndex = 19;
            // 
            // btnLimpiarFormUsuario
            // 
            this.btnLimpiarFormUsuario.Location = new System.Drawing.Point(199, 289);
            this.btnLimpiarFormUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFormUsuario.Name = "btnLimpiarFormUsuario";
            this.btnLimpiarFormUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiarFormUsuario.TabIndex = 15;
            this.btnLimpiarFormUsuario.Text = "Limpiar";
            this.btnLimpiarFormUsuario.UseVisualStyleBackColor = true;
            this.btnLimpiarFormUsuario.Click += new System.EventHandler(this.btnLimpiarFormUsuario_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(48, 289);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarUsuario.TabIndex = 13;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // comboEstatusBusqueda
            // 
            this.comboEstatusBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstatusBusqueda.FormattingEnabled = true;
            this.comboEstatusBusqueda.Location = new System.Drawing.Point(843, 32);
            this.comboEstatusBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.comboEstatusBusqueda.Name = "comboEstatusBusqueda";
            this.comboEstatusBusqueda.Size = new System.Drawing.Size(117, 24);
            this.comboEstatusBusqueda.TabIndex = 27;
            this.comboEstatusBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboEstatusBusqueda_SelectedIndexChanged);
            // 
            // UsuariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1196, 412);
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
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.tabControlProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
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