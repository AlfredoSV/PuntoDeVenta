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

namespace PuntoDeVenta.VentaForms
{
    public partial class RealizarVentaForm : Form
    {
        private Usuario _usuarioLogueado;
        public RealizarVentaForm()
        {
            InitializeComponent();
        }

        public void Show(Usuario usuarioLogueado)
        {
            _usuarioLogueado = usuarioLogueado;
            this.Show();

        }

        private void btnSalirFormVentas_Click(object sender, EventArgs e)
        {
            var inicio = new Inicio();
            inicio.Show(_usuarioLogueado);
            this.Dispose();
        }
    }
}
