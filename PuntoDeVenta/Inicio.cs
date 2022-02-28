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
        private readonly Login _login;
        public Inicio(Login login)
        {
            _login = login;
            InitializeComponent();
        }


        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            _login.CerrarSesion();

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var altaProducto = new AltaProducto();
            altaProducto.MdiParent = this;
            altaProducto.Show();
        }
    }
}
