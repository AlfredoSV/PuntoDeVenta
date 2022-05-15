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
        private DtoProducto _dtoProducto;
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
                productos = await _servicioProductos.ConsultarProductosPaginados(dtoPropiedadesPaginacion);
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

        private async void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var idProducto = Guid.Parse(dataGridViewProductos.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());

                _dtoProducto = await _servicioProductos.ConsultarProductoPorId(idProducto);

                txtNombre.Text = _dtoProducto.Nombre;
                txtPrecio.Text = Math.Round(_dtoProducto.Precio, 2).ToString();

                if (_dtoProducto.Stock < 1)
                {
                    nupCantidad.Minimum = 0;
                    nupCantidad.Maximum = 0;
                    btnAceptar.Enabled = false;
                    MessageBox.Show("Este productos ya no cuenta con registros en el stock, favor de vérificar su almacen.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    nupCantidad.Minimum = 1;
                    nupCantidad.Maximum = _dtoProducto.Stock;
                    btnAceptar.Enabled = true;
                    MessageBox.Show("Favor de seleccionar la cantidad de productos a comprar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

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

        private void RealizarVentaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var dataTableProductosCarrito = new DataTable();
            DataRow dtrowProducto;

            dataTableProductosCarrito.Columns.Add("Nombre", typeof(string));
            dataTableProductosCarrito.Columns.Add("Seleccionados", typeof(int));
            dataTableProductosCarrito.Columns.Add("Subtotal", typeof(decimal));


            dtrowProducto = dataTableProductosCarrito.NewRow();

            dtrowProducto["Nombre"] = _dtoProducto.Nombre;
            dtrowProducto["Seleccionados"] = nupCantidad.Value;
            dtrowProducto["Subtotal"] = _dtoProducto.Precio*(decimal)nupCantidad.Value;

            dataTableProductosCarrito.Rows.Add(dtrowProducto);


            dataGridViewProductosCarrito.DataSource = dataTableProductosCarrito;


        }
    }
}
