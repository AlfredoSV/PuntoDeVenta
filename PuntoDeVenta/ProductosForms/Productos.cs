using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Servicios;

namespace PuntoDeVenta.ProductosForms
{
    public partial class Productos : Form
    {
        private readonly ServicioProductos _servicioProductos;
        public Productos()
        {
            _servicioProductos = ServicioProductos.Instacia;
            InitializeComponent();
        }


        private void Productos_Load(object sender, EventArgs e)
        {


            var productos = _servicioProductos.ConsultarProductosBD();
            dataGridViewProductos.DataSource = productos;


        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Columna:" + e.ColumnIndex.ToString());

            MessageBox.Show(dataGridViewProductos.Rows[e.RowIndex].Cells[2].Value.ToString());

        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            var inicioForm = new Inicio();
            inicioForm.Show();
            this.Close();
        }
    }
}
