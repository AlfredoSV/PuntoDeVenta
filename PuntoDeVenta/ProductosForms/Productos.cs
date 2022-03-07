using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.Dtos;
using Aplicacion.Servicios;
using Dominio.Entidades;

namespace PuntoDeVenta.ProductosForms
{
    public partial class Productos : Form
    {
        private readonly ServicioProductos _servicioProductos;
        private Usuario _usuarioLogueado;

        public Productos()
        {
            _servicioProductos = ServicioProductos.Instacia;

            InitializeComponent();

           

        }
        private async void Productos_Load(object sender, EventArgs e)
        {
            
            try
            {
                LimpiarGrid();
                AgregarBotonesGrid();
               
                var productos = await _servicioProductos.ConsultarProductosPaginadosBD(new DtoBuscarProductosPaginados(0, 7, ""));

                ListarProductosGrid(productos);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                SalirDeFormulario();
                
            }

        }
        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Columna:" + e.ColumnIndex.ToString());

            MessageBox.Show(dataGridViewProductos.Rows[e.RowIndex].Cells[2].Value.ToString());

        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            SalirDeFormulario();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            //Validación

            /*var stock = (int)(txtStockProducto.Value);
            var nombre = txtNombreProducto.Text.Trim();
            var precio = Convert.ToDecimal(txtPrecioProducto.Text.Trim());
            var descripcion = txtDescripcionProducto.Text.Trim();
            var proveedor = comboProveedorProducto.SelectedItem;


            try
            {
                _servicioProductos.GuardarNuevoProducto(stock, nombre, descripcion, precio, proveedor,);
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;
            base.Show();
        }

        private void btnLimpiarFormProducto_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtDescripcionProducto.Text = "";
            txtStockProducto.Value = 0;
        }

        private async void btnRecargarProductos_Click(object sender, EventArgs e)
        {
            LimpiarGrid();
            AgregarBotonesGrid();
            var productos = await _servicioProductos.ConsultarProductosPaginadosBD(new DtoBuscarProductosPaginados(0, 7, ""));
            ListarProductosGrid(productos);
        }


       
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var pagina = 0;
            var tamanioPagina = 7;
            var txtFiltro = txtBuscar.Text.Trim();

            var dtoBuscarProductosPaginados = new DtoBuscarProductosPaginados(pagina, tamanioPagina, txtFiltro);

            LimpiarGrid();
            AgregarBotonesGrid();

            var productos = await _servicioProductos.ConsultarProductosPaginadosBD(dtoBuscarProductosPaginados);

            ListarProductosGrid(productos);

        }

        #region Lógica presentación

        private void SalirDeFormulario()
        {
            var inicioForm = new Inicio();
            inicioForm.Show(_usuarioLogueado);
            this.Close();
        }
        private void AgregarBotonesGrid()
        {
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            dataGridViewProductos.Columns.Add(btnBorrar);
            btnBorrar.Text = "Borrar";
            btnBorrar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            dataGridViewProductos.Columns.Add(btnEditar);
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;

        }

        private void LimpiarGrid()
        {
            dataGridViewProductos.DataSource = null;
            dataGridViewProductos.Columns.Clear();
        }

        private void ListarProductosGrid(DtoProductosPaginados dtoProductosPaginados)
        {
            try
            {

                dataGridViewProductos.DataSource = dtoProductosPaginados.Productos;

                numericPaginas.Maximum = dtoProductosPaginados.TotalPaginas;
                numericPaginas.Minimum = 0;
                if (dtoProductosPaginados.TotalPaginas > 0)
                    numericPaginas.Minimum = 1;
                txtPaginasTotalesProductos.Text = dtoProductosPaginados.TotalPaginas.ToString();

            }
            catch (Exception exception)
            {

                throw exception;
            }
        }

        #endregion

       
    }
}
