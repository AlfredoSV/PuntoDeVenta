using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.ProductosForms
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();

            dt.Columns.Add("Nombre", typeof(string));

            dt.Rows.Add(new string[] { "Alfredo" });
            dt.Rows.Add(new string[] { "Alfredo2" });
            /*DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "X";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = true;
            checkColumn.FillWeight = 10;

            dataGridViewProductos.Columns.Add(checkColumn);
            */
            dataGridViewProductos.DataSource = dt;



        }
    }
}
