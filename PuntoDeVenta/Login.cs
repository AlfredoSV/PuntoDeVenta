

using Aplicacion.Servicios;
using Dominio;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Login : Form
    {
        private static Login _instancia;
        private readonly ServicioAutenticacion _servicioAutenticacion;

        public static Login Instancia
        {
            get
            {

                if (_instancia == null)
                    _instancia = new Login();

                return _instancia;

            }
        }

        public Login()
        {
            _servicioAutenticacion = ServicioAutenticacion.Instacia;
            InitializeComponent();
        }


        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            await Ingresar();
        }


        public void CerrarSesion()
        {
            this.Show();
            txtContrasenia.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private async void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                await Ingresar();
            }          
        }

        private async void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                await Ingresar();
            }
        }

        public new void Show()
        {
            txtContrasenia.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            base.Show();
        }

        private async Task Ingresar()
        {
            try
            {
                Init inicioForm = new Init();
                string usuario = txtUsuario.Text.Trim();
                string contrasenia = txtContrasenia.Text.Trim();          

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasenia))
                {
                    MessageBox.Show("Favor de ingresar usuario y/o contraseña", "Alterta");
                    return;
                }

                if (!await _servicioAutenticacion.ValidarUsuario(usuario, contrasenia))
                {
                    MessageBox.Show("El usuario y/o contraseña son incorrectos o el usuario no se ecuentra activo", "Error");
                    return;
                }

                this.Hide();
                inicioForm.Show(await _servicioAutenticacion.ConsultarUsuario(usuario));

            }
            catch (ExcepcionComun excepcionComun)
            {
                MessageBox.Show(excepcionComun.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Sucedió un error no controlado, favor de contactar con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            var registroUsuario = new RegistroUsuario();
            registroUsuario.ShowDialog();
        }
    }
}
