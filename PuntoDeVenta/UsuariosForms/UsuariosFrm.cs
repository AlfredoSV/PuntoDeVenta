using Aplicacion.Enums;
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
using Aplicacion;
using Dominio;
using Aplicacion.Dtos;

namespace PuntoDeVenta.UsuariosForms
{
    public partial class UsuariosFrm : Form
    {
        private Usuario _usuarioLogueado;
        private ServicioUsuarios _servicioUsuarios;
        private ServicioCatalogos _servicioCatalogos;


        private const int PAGINA_POR_DEFECTO = 0;
        private const int TAMANIO_PAGINA_POR_DEFECTO = 10;
        private const string BUSCAR_FILTRO_POR_DEFECTO = "";

        public UsuariosFrm()
        {
            _servicioUsuarios = ServicioUsuarios.Instancia;
            _servicioCatalogos = ServicioCatalogos.Instacia;
            InitializeComponent();
        }

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;
            base.Show();
        }

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            var inicioFrm = new Inicio();
            inicioFrm.Show(_usuarioLogueado);
            this.Dispose();
            this.Close();
        }

        private async void UsuariosFrm_Load(object sender, EventArgs e)
        {
            int comboEstatus = (int)EstatusUsuarioBusqueda.Todos;
            List<DtoUsuario> usuarios;

            try
            {
                var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
                LimpiarGrid();
                AgregarBotonesGrid();
                CargarEstatus();
                CargarSucursales(await _servicioCatalogos.ConsultarSucursalesBD());
                CargarRoles(await _servicioCatalogos.ConsultarRolesBD());

                usuarios = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus,dtoPropiedadesPaginacion)).ToList();

                dataGridViewUsuarios.DataSource = usuarios;

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

        private void AgregarBotonesGrid()
        {
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            dataGridViewUsuarios.Columns.Add(btnBorrar);
            btnBorrar.Text = "Borrar";
            btnBorrar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            dataGridViewUsuarios.Columns.Add(btnEditar);
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;

        }
        private void LimpiarGrid()
        {
            dataGridViewUsuarios.Columns.Clear();
            dataGridViewUsuarios.DataSource = null;

        }

        private void btnRecargarUsuarios_Click(object sender, EventArgs e)
        {
            LimpiarGrid();
            AgregarBotonesGrid();

        }


        private void CargarEstatus()
        {
            var items = new List<Item>();


            items.Add(new Item("Todos", (int)EstatusUsuarioBusqueda.Todos));
            items.Add(new Item("Inactivos", (int)EstatusUsuarioBusqueda.Inactivos));
            items.Add(new Item("Activos", (int)EstatusUsuarioBusqueda.Activos));

            comboEstatusBusqueda.DisplayMember = "Name";
            comboEstatusBusqueda.ValueMember = "Value";
            comboEstatusBusqueda.DataSource = items;
        }

        private void CargarSucursales(IEnumerable<Sucursal> sucursales)
        {
            var items = new List<Item>();

            items.Add(new Item("--- Seleciona un sucursal. ---", Guid.Empty));
            foreach (var get in sucursales)
            {
                items.Add(new Item(get.Nombre, get.IdSucursal));
            }

            comboBoxSucursales.DisplayMember = "Name";
            comboBoxSucursales.ValueMember = "Value";
            comboBoxSucursales.DataSource = items;
        }

        private void CargarRoles(IEnumerable<Rol> sucursales)
        {
            var items = new List<Item>();

            items.Add(new Item("--- Seleciona un Rol. ---", Guid.Empty));
            foreach (var get in sucursales)
            {
                items.Add(new Item(get.Nombre, get.IdRol));
            }

            comboBoxRoles.DisplayMember = "Name";
            comboBoxRoles.ValueMember = "Value";
            comboBoxRoles.DataSource = items;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            
            int comboEstatus = (int)EstatusUsuarioBusqueda.Todos;
            List<DtoUsuario> usuarios;
            var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);


            try
            {
                LimpiarGrid();
                AgregarBotonesGrid();

                comboEstatus = ((Item)(comboEstatusBusqueda.SelectedItem)).ValueInt;

                usuarios = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus,dtoPropiedadesPaginacion)).ToList();
           
                dataGridViewUsuarios.DataSource = usuarios;

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

        private async void comboEstatusBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboEstatus = (int)EstatusUsuarioBusqueda.Todos;
            List<DtoUsuario> usuarios;
            var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);

            try
            {
                LimpiarGrid();
                AgregarBotonesGrid();

                comboEstatus = ((Item)(comboEstatusBusqueda.SelectedItem)).ValueInt;

                usuarios = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus,dtoPropiedadesPaginacion)).ToList();

                dataGridViewUsuarios.DataSource = usuarios;

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

        private async void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text.Trim();
            var contrasenia = txtContrasenia.Text.Trim();
            var idRol = ((Item)(comboBoxRoles.SelectedItem)).Value;
            var idSucursal = ((Item)(comboBoxSucursales.SelectedItem)).Value;
            DtoUsuario dtoUsuario;

            var validacion = true;
            var mensajeValidacion = string.Empty;

            if (usuario.Equals(""))
            {
                mensajeValidacion += "* Favor de ingresar un usuario \n";
                validacion = false;
            }
            if (contrasenia.Equals(""))
            {
                mensajeValidacion += "* Favor de ingresar una contrasenia \n";
                validacion = false;
            }
            if (idRol == Guid.Empty)
            {
                mensajeValidacion += "* Favor de seleccionar un Rol \n";
                validacion = false;
            }
            if (idSucursal == Guid.Empty)
            {
                mensajeValidacion += "* Favor de seleccionar una sucursal \n";
                validacion = false;
            }

            if (validacion)
            {
                try
                {
                    dtoUsuario = new DtoUsuario(usuario, contrasenia, idSucursal, idRol);
                    await _servicioUsuarios.GuardarNuevoUsuario(dtoUsuario);
                    

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

        private void btnLimpiarFormUsuario_Click(object sender, EventArgs e)
        {
            txtContrasenia.Text = string.Empty;
            txtUsuario.Text = string.Empty;

        }

        private async void dataGridViewUsuarios_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            var columna = e.ColumnIndex.ToString();
            List<DtoUsuario> usuarios;
            int comboEstatus = (int)EstatusUsuarioBusqueda.Todos;
            var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);


            try
            {
                if (columna.Equals("0") || columna.Equals("1"))
                {
                    var idUsuario = Guid.Parse(dataGridViewUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString());

                    switch (columna)
                    {
                        case "0":
                            _servicioUsuarios.EliminarUsuarioPorId(idUsuario);
                            break;
                        case "1":
                            //var editarProductoForm = EditarProducto.Instancia;
                            //editarProductoForm.ShowDialog(idProducto);
                            break;

                    }

                    //var dtoBuscarProductosPaginados = new DtoBuscarProductosPaginados(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
                    //var productos = await _servicioProductos.ConsultarProductosPaginadosBD(dtoBuscarProductosPaginados);
                    LimpiarGrid();
                    AgregarBotonesGrid();
                    //CargarProveedores(await _servicioCatalogos.ConsultarProveedoresBD());
                    //productos.Pagina += 1;
                    //ListarProductosGrid(productos);
                    usuarios = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus,dtoPropiedadesPaginacion)).ToList();
                    dataGridViewUsuarios.DataSource = usuarios;

                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
