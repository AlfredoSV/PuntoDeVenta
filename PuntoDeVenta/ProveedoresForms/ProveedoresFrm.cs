using Aplicacion.Servicios;
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

namespace PuntoDeVenta.ProveedoresForms
{
    public partial class ProveedoresFrm : Form
    {
        private Usuario _usuarioLogueado;
        private readonly ServicioProveedores _servicioProveedores;

        public ProveedoresFrm()
        {
            _servicioProveedores = ServicioProveedores.Instancia;
            InitializeComponent();
        }

        private void btnSalirProveedores_Click(object sender, EventArgs e)
        {
            var inicioFrm = new Inicio();
            inicioFrm.Show(_usuarioLogueado);
            this.Dispose();
            this.Close();
        }

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;
            base.Show();
            
        }

        private void btnLimpiarFormFormProveedor_Click(object sender, EventArgs e)
        {
            txtNombreProveedor.Text = string.Empty;
            txtDescripcionProveedor.Text = string.Empty;
            txtBuscar.Text = string.Empty;
            LimpiarGrid();
        }

        private void LimpiarGrid()
        {
            dataGridViewProveedores.Columns.Clear();
            dataGridViewProveedores.DataSource = null;

        }
    }
}
