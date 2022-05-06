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
    public partial class SeleccionProductoForm : Form
    {
        private static SeleccionProductoForm _instancia;
        private  Usuario _usuarioLogueado;

        public static SeleccionProductoForm Instancia
        {
            get {
                if(_instancia is null)
                    _instancia = new SeleccionProductoForm();
                return _instancia;
            }

            set
            {
                _instancia = value;
            }
        }

        public SeleccionProductoForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Usuario usuarioLogueado)
        {
            _usuarioLogueado = usuarioLogueado;
            this.ShowDialog();
        }

        private void btnSalirFormSeleccionarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
