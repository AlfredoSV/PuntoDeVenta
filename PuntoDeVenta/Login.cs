using Negocio.IServicios;
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
        public readonly IServicioAutenticacion _servicioAutenticacion;
        public Login(IServicioAutenticacion servicioAutenticacion)
        {
            _servicioAutenticacion = servicioAutenticacion;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            _servicioAutenticacion.ValidarUsuario();
            var usuario = txtUsuario.Text.Trim();
            var contrasenia = txtContrasenia.Text.Trim();
            var inicioForm = new Inicio(this);
            var validacion = true;

            if (!usuario.Equals("") && !contrasenia.Equals(""))
            {
                if (validacion)
                {
                    this.Hide();
                    inicioForm.Show();
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
    }
}
