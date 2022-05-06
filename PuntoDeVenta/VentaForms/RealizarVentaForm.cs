using Aplicacion.Dtos;
using Aplicacion.Servicios;
using Dominio;
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
        private readonly ServicioProductos _servicioProductos;

        private const int PAGINA_POR_DEFECTO = 0;
        private const int TAMANIO_PAGINA_POR_DEFECTO = 10;
        private const string BUSCAR_FILTRO_POR_DEFECTO = "";
        public RealizarVentaForm()
        {
            _servicioProductos = ServicioProductos.Instacia;
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

        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {

            var txtFiltro = txtBuscarProducto.Text.Trim();
            var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, txtFiltro);
            DtoProductosPaginados productos;

            try
            {
                productos = await _servicioProductos.ConsultarProductosPaginadosBD(dtoPropiedadesPaginacion);
                LimpiarGrid();
                AgregarBotonesGrid();
                ListarProductosGrid(productos);
            }
            catch (ExcepcionComun excepcionComun)
            {
                MessageBox.Show(excepcionComun.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ListarProductosGrid(DtoProductosPaginados dtoProductosPaginados)
        {

            var dataTableProductos = new DataTable();
            DataRow dtrowProducto;

            try
            {

                dataTableProductos.Columns.Add("Id", typeof(Guid));
                dataTableProductos.Columns.Add("Nombre", typeof(string));
                dataTableProductos.Columns.Add("Stock", typeof(int));
                dataTableProductos.Columns.Add("Descripción", typeof(string));
                dataTableProductos.Columns.Add("Precio", typeof(double));

                foreach (var prod in dtoProductosPaginados.Productos)
                {
                    dtrowProducto = dataTableProductos.NewRow();

                    dtrowProducto["Id"] = prod.IdProducto;
                    dtrowProducto["Nombre"] = prod.Nombre;
                    dtrowProducto["Stock"] = prod.Stock;
                    dtrowProducto["Descripción"] = prod.Descripcion;
                    dtrowProducto["Precio"] = prod.Precio;

                    dataTableProductos.Rows.Add(dtrowProducto);

                }

                dataGridViewProductos.DataSource = dataTableProductos;


            }
            catch (ExcepcionComun excepcionComun)
            {
                MessageBox.Show(excepcionComun.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AgregarBotonesGrid()
        {
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            dataGridViewProductos.Columns.Add(btnBorrar);
            btnBorrar.Text = "Agregar";
            btnBorrar.UseColumnTextForButtonValue = true;


        }
        private void LimpiarGrid()
        {
            dataGridViewProductos.Columns.Clear();
            dataGridViewProductos.DataSource = null;

        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridViewProductos.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value.ToString());

            var seleccionarProducto = SeleccionProductoForm.Instancia;

            seleccionarProducto.ShowDialog(_usuarioLogueado);

        
        }
    }
}
