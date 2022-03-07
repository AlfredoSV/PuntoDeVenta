
using Aplicacion.Servicios;
using Dominio.Entidades;
using PuntoDeVenta.ProductosForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PuntoDeVenta
{
    public partial class Inicio : Form
    {
        private ServicioAutenticacion _servicioAutenticacion;
        private Usuario _usuarioLogueado;
        private PermisosModulo _permisoModulo;
        public Inicio()
        {
            _servicioAutenticacion = ServicioAutenticacion.Instacia;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            try
            {
                _permisoModulo = _servicioAutenticacion.ConsultarPermisosPorIdUsuario(_usuarioLogueado.IdUsuario);

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
            Application.ExitThread();
        }

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;

            lblFechaHoy.Text = DateTime.Now.ToString();
            lblSaludo.Text = $"Bienvenido, {usuario.NombreUsuario}";
            base.Show();
        }


    }
}
