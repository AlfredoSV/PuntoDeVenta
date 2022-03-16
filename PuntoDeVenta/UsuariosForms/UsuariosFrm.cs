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

namespace PuntoDeVenta.UsuariosForms
{
    public partial class UsuariosFrm : Form
    {
        private Usuario _usuarioLogueado;

        public UsuariosFrm()
        {
            InitializeComponent();
        }

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;
            base.Show();
        }

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            var inicioFrm = new Inicio();
            inicioFrm.Show(_usuarioLogueado);
            this.Dispose();
            this.Close();
        }
    }
}
