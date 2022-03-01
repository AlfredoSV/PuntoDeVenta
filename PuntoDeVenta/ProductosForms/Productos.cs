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
            dt.Columns.Add("Id", typeof(Guid));

            dt.Rows.Add(new string[] { "Alfredo", Guid.NewGuid().ToString() });
            dt.Rows.Add(new string[] { "Alfredo2", Guid.NewGuid().ToString() });
            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            //checkColumn.Name = "X";
            //checkColumn.HeaderText = "Eli";

            buttons.Text = "Sales";

            buttons.UseColumnTextForButtonValue = true;
            buttons.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            // buttons.FlatStyle = FlatStyle.Standard;
            buttons.CellTemplate.Style.BackColor = Color.Red;
            buttons.DisplayIndex = 0;
            buttons.DataPropertyName = Guid.NewGuid().ToString();

            dataGridViewProductos.Columns.Add(buttons);

            dataGridViewProductos.DataSource = dt;



        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Columna:" + e.ColumnIndex.ToString());

            MessageBox.Show(dataGridViewProductos.Rows[e.RowIndex].Cells[2].Value.ToString());

        }
    }
}
