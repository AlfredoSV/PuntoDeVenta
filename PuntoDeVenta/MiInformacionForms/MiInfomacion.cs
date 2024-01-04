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


        public void Show(Usuario usuarioLog)
        {
            _usuarioLogueado = usuarioLog;
           
            base.Show();
        }

        private void MiInfomacion_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _usuarioLogueado.NombreUsuario;
            lblRol.Text = _usuarioLogueado.Rol.Nombre;
            lblSucursal.Text = _usuarioLogueado.Sucursal.Nombre;
            lblFechaAlta.Text = _usuarioLogueado.FechayHoraAlta.ToString();
        }
    }
}
