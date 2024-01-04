using Aplicacion.Servicios;
using Dominio.Entidades;
using PuntoDeVenta.MiInformacionForms;
using PuntoDeVenta.ProductosForms;
using PuntoDeVenta.ProveedoresForms;
using PuntoDeVenta.UsuariosForms;
using System;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Init : Form
    {
        private ServicioAutenticacion _servicioAutenticacion;
        private Usuario _usuarioLogueado;

        public Init()
        {
            InitializeComponent();
            _servicioAutenticacion = ServicioAutenticacion.Instacia;
        }

        private void Init_Load(object sender, EventArgs e)
        {
            try
            {
                
                _usuarioLogueado.AsignarPermisos(_servicioAutenticacion.ConsultarPermisosPorIdUsuario(_usuarioLogueado.IdUsuario));
            }
            catch (Exception)
            {
                MessageBox.Show("Sucedió un error no controlado, favor de contactar con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Show(Usuario usuario)
        {
            
            _usuarioLogueado = usuario;
            base.Show();
        }


        private void Init_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = false;
            Login.Instancia.Show();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosFrm usuarios = new UsuariosFrm(); 

            if (!_usuarioLogueado.Rol.Nombre.Equals("Admin"))
            {
                MessageBox.Show("No tiene los permisos necesarios para acceder a este permiso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            this.IsMdiContainer = true;
            usuarios.MdiParent = this;
            toolStripContainer.Width = this.Width;
            toolStripContainer.Height = this.Height;
            toolStripContainer.ContentPanel.Controls.Add(usuarios);
          
            usuarios.Show(_usuarioLogueado);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            this.IsMdiContainer = true;
            productos.MdiParent = this;
            toolStripContainer.Width = this.Width;
            toolStripContainer.Height = this.Height;
            toolStripContainer.ContentPanel.Controls.Add(productos);
            productos.Show(_usuarioLogueado);


        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedoresFrm proveedoresFrom = new ProveedoresFrm();
            this.IsMdiContainer = true;
            proveedoresFrom.MdiParent = this;
            toolStripContainer.Width = this.Width;
            toolStripContainer.Height = this.Height;
            toolStripContainer.ContentPanel.Controls.Add(proveedoresFrom);
            proveedoresFrom.Show(_usuarioLogueado);
            
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiInfomacion miInformacion = new MiInfomacion();
            this.IsMdiContainer = true;
            miInformacion.MdiParent = this;
            toolStripContainer.Width = this.Width;
            toolStripContainer.Height = this.Height;
            toolStripContainer.ContentPanel.Controls.Add(miInformacion);
            miInformacion.Show(_usuarioLogueado);
            
        }
    }
}
