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
        private readonly Login _login;

        public Inicio()
        {

            InitializeComponent();
        }


        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


        }



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            _login.CerrarSesion();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                var ventas = new Productos();
                ventas.Show();
                this.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
