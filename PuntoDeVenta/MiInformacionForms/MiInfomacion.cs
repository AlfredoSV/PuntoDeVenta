using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.MiInformacionForms
{
    public partial class MiInfomacion : Form
    {
        private Usuario _usuarioLogueado;
        public MiInfomacion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var inicio = new Inicio();
            inicio.Show(_usuarioLogueado);
            this.Close();
        }

        public void Show(Usuario usuarioLog)
        {
            _usuarioLogueado = usuarioLog;
            lblUsuario.Text = _usuarioLogueado.NombreUsuario;
            lblRol.Text = _usuarioLogueado.Permisos.First().NombreRol;
            lblSucursal.Text = "Suc";
            lblFechaAlta.Text = _usuarioLogueado.FechayHoraAlta.ToString();
            base.Show();
        }

        private void MiInfomacion_Load(object sender, EventArgs e)
        {

        }
    }
}
