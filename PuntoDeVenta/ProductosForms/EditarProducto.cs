using Aplicacion.Dtos;
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
using PuntoDeVenta.ClasesAuxiliares;
using Dominio;

namespace PuntoDeVenta.ProductosForms
{
    public partial class EditarProducto : Form
    {
        private static EditarProducto _instancia;
        private DtoProducto _dtoProducto;
        private ServicioProductos _servicioProductos;
        private ServicioCatalogos _servicioCatalogos;
        private Guid _idProducto;


        public static EditarProducto Instancia
        {
            get
            {

                if (_instancia == null)
                    _instancia = new EditarProducto();
                return _instancia;

            }
            private set { }
        }


        private EditarProducto()
        {
            _servicioProductos = ServicioProductos.Instacia;
            _servicioCatalogos = ServicioCatalogos.Instacia;
            InitializeComponent();
        }

        private async void EditarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarProveedores(await _servicioCatalogos.ConsultarProveedoresBD());

                _dtoProducto = (await _servicioProductos.ConsultarProductoPorId(_idProducto));

                txtNombreProductoEdi.Text = _dtoProducto.Nombre;


                //@"^(?:\d+\.?\d*)?$"

                txtPrecioProductoEdi.Text = String.Format("{0:0,0.0}", _dtoProducto.Precio);

                txtStockProductoEdi.Value = _dtoProducto.Stock;

                txtDescripcionProductoEdi.Text = _dtoProducto.Descripcion;

                comboProveedorProductoEdi.SelectedValue = _dtoProducto.IdProveedor;

            }
            catch (ExcepcionComun exception)
            {
                MessageBox.Show(exception.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void ShowDialog(Guid idProducto)
        {
            _idProducto = idProducto;
            base.ShowDialog();
        }

        private void btnSalirEditarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarProveedores(IEnumerable<Proveedor> provedores)
        {
            var items = new List<Item>();

            items.Add(new Item("--- Seleciona un proveedor. ---", Guid.Empty));
            foreach (var get in provedores)
            {
                items.Add(new Item(get.Nombre, get.IdProveedor));
            }

            comboProveedorProductoEdi.DisplayMember = "Name";
            comboProveedorProductoEdi.ValueMember = "Value";
            comboProveedorProductoEdi.DataSource = items;
        }

        private void btnGuardarProductoEditado_Click(object sender, EventArgs e)
        {
            var nombre = txtNombreProductoEdi.Text.Trim();
            var preciotxt = txtPrecioProductoEdi.Text.Trim().Trim('.').Trim(',').Trim() == "" ? "0.00" : txtPrecioProductoEdi.Text.Trim().Trim('.').Trim(',').Trim();
            var precio = Convert.ToDecimal(preciotxt.Replace(" ", ""));
            var descripcion = txtDescripcionProductoEdi.Text.Trim();
            var stock = (int)txtStockProductoEdi.Value;
            var idProveedor = ((Item)(comboProveedorProductoEdi.SelectedItem)).Value;
            var validacion = true;
            var mensajeValidacion = string.Empty;

            if (stock <= 0)
            {
                mensajeValidacion += "* Debe agregar por lo menos un producto al stock \n";
                validacion = false;
            }
            if (nombre.Equals(""))
            {
                mensajeValidacion += "* El productos debe terner un nombre \n";
                validacion = false;
            }
            if (precio <= 0.00m)
            {
                mensajeValidacion += "* El precio debe ser mayor a 0 \n";
                validacion = false;
            }

            if (idProveedor == Guid.Empty)
            {
                mensajeValidacion += "* Debe seleccionar un proveedor \n";
                validacion = false;
            }
            if (validacion)
            {
                try
                {
                    var dtoProducto = new DtoProducto(_dtoProducto.IdProducto, stock, nombre, descripcion, precio, idProveedor);


                }
                catch (ExcepcionComun exception)
                {
                    MessageBox.Show(exception.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(mensajeValidacion, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
