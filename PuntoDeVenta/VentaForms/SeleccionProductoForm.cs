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
    public partial class SeleccionProductoForm : Form
    {
        private static SeleccionProductoForm _instancia;
        private  Usuario _usuarioLogueado;
        private Guid _idProducto;
        private readonly ServicioProductos _servicioProductos;
        private DtoProducto _dtoProducto;

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
            _servicioProductos = ServicioProductos.Instacia;
            InitializeComponent();
        }

        public void ShowDialog(Usuario usuarioLogueado,Guid idProducto)
        {
            _usuarioLogueado = usuarioLogueado;
            _idProducto = idProducto;
            this.ShowDialog();
         
        }

        private void btnSalirFormSeleccionarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SeleccionProductoForm_Load(object sender, EventArgs e)
        {
            try
            {
                _dtoProducto = await _servicioProductos.ConsultarProductoPorId(_idProducto);

                txtNombre.Text = _dtoProducto.Nombre;
                txtPrecio.Text = Math.Round(_dtoProducto.Precio,2).ToString();
                nupCantidad.Minimum = 1;
                nupCantidad.Maximum = _dtoProducto.Stock;

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
    }
}
