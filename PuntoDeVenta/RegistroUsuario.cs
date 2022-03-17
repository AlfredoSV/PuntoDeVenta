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
    public partial class RegistroUsuario : Form
    {
        private ServicioUsuarios _servicioUsuarios;
        public RegistroUsuario()
        {
            _servicioUsuarios = ServicioUsuarios.Instancia;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnRealizarSol_Click(object sender, EventArgs e)
        {
            _servicioUsuarios.GuardarNuevoUsuario();

        }
    }
}
