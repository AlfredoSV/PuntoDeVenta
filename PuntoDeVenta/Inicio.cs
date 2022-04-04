
using Aplicacion.Servicios;
using Dominio.Entidades;
using PuntoDeVenta.MiInformacionForms;
using PuntoDeVenta.ProductosForms;
using PuntoDeVenta.ProveedoresForms;
using PuntoDeVenta.UsuariosForms;
using PuntoDeVenta.VentaForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PuntoDeVenta
{
    public partial class Inicio : Form
    {
        private ServicioAutenticacion _servicioAutenticacion;
        private Usuario _usuarioLogueado;
        
        
        public Inicio()
        {
            _servicioAutenticacion = ServicioAutenticacion.Instacia;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            try
            {
                _usuarioLogueado.AsignarPermisos(_servicioAutenticacion.ConsultarPermisosPorIdUsuario(_usuarioLogueado.IdUsuario));

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {

            var productos = new Productos();
            productos.Show(_usuarioLogueado);
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Login.Instancia.Show();            
            this.Close();
            this.Dispose();
        }

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;
            lblFechaHoy.Text = DateTime.Now.ToString();
            lblSaludo.Text = $"Bienvenido, {usuario.NombreUsuario}";
            base.Show();
        }

        private void btnMiInformacion_Click(object sender, EventArgs e)
        {
            var miInformacion = new MiInfomacion();
            miInformacion.Show(_usuarioLogueado);
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (_usuarioLogueado.Rol.Nombre.Equals("Admin"))
            {
                var usuarios = new UsuariosFrm();
                usuarios.Show(_usuarioLogueado);
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No tiene los permisos necesarios para acceder a este permiso","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            var proveedoresFrom = new ProveedoresFrm();
            proveedoresFrom.Show(_usuarioLogueado);
            this.Close();
            this.Dispose();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            var ventaForm = new RealizarVentaForm();
            ventaForm.Show(_usuarioLogueado);
            
            this.Dispose();
        }
    }
}
