

using Aplicacion.Servicios;
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
    public partial class Login : Form
    {
        private readonly ServicioAutenticacion _servicioAutenticacion;
        public Login()
        {
            _servicioAutenticacion = ServicioAutenticacion.Instacia;
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {

            var usuario = txtUsuario.Text.Trim();
            var contrasenia = txtContrasenia.Text.Trim();
            var inicioForm = new Inicio();


            if (!usuario.Equals("") && !contrasenia.Equals(""))
            {


                if (_servicioAutenticacion.ValidarUsuario(usuario, contrasenia))
                {
                    this.Hide();
                    inicioForm.Show(_servicioAutenticacion.ConsultarUsuario(usuario, contrasenia));
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña son incorrectos", "Error");
                }

            }
            else
            {
                MessageBox.Show("Favor de ingresar usuario y/o contraseña", "Error");
            }



        }


        public void CerrarSesion()
        {
            this.Show();
            txtContrasenia.Text = "";
            txtUsuario.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
