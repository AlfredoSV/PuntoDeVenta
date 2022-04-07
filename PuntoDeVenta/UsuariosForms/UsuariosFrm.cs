using Aplicacion.Enums;
using Aplicacion.Servicios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
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
        private const int TAMANIO_PAGINA_POR_DEFECTO = 2;
        private const string BUSCAR_FILTRO_POR_DEFECTO = "";

        public UsuariosFrm()
        {
            _servicioUsuarios = ServicioUsuarios.Instancia;
            _servicioCatalogos = ServicioCatalogos.Instacia;
            InitializeComponent();
        }

        #region Eventos
        private async void UsuariosFrm_Load(object sender, EventArgs e)
        {
            int comboEstatus = (int)EstatusUsuarioBusqueda.Todos;
            UsuariosPaginados usuariosPaginados;
            DtoPropiedadesPaginacion dtoPropiedadesPaginacion;

            try
            {
                dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
                usuariosPaginados = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus, dtoPropiedadesPaginacion));
                usuariosPaginados.InicializarPagina();
                LimpiarGrid();
                AgregarBotonesGrid();
                CargarEstatus();
                CargarSucursales(await _servicioCatalogos.ConsultarSucursalesBD());
                CargarRoles(await _servicioCatalogos.ConsultarRolesBD());               
                ListarUsuariosGrid(usuariosPaginados);

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

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            var inicioFrm = new Inicio();
            inicioFrm.Show(_usuarioLogueado);
            this.Dispose();
            this.Close();
        }
              
        private async void btnRecargarUsuarios_Click(object sender, EventArgs e)
        {
            int comboEstatus = (int)EstatusUsuarioBusqueda.Todos;
            UsuariosPaginados usuariosPaginados;
            DtoPropiedadesPaginacion dtoPropiedadesPaginacion;
            try
            {
                dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
                usuariosPaginados = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus, dtoPropiedadesPaginacion));
                usuariosPaginados.InicializarPagina();
                txtBuscar.Text = "";
                LimpiarGrid();
                AgregarBotonesGrid();
                comboEstatusBusqueda.DataSource = null;
                comboEstatusBusqueda.Items.Clear();                
                CargarEstatus();
                               
                ListarUsuariosGrid(usuariosPaginados);

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

        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            int comboEstatus;
            UsuariosPaginados usuariosPaginados;
            string buscar = txtBuscar.Text;
            DtoPropiedadesPaginacion dtoPropiedadesPaginacion;

            try
            {
                dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, buscar);
                comboEstatus = ((Item)(comboEstatusBusqueda.SelectedItem)).ValueInt;
                usuariosPaginados = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus, dtoPropiedadesPaginacion));
                usuariosPaginados.InicializarPagina();
                LimpiarGrid();
                AgregarBotonesGrid();            
                ListarUsuariosGrid(usuariosPaginados);

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

        private async void comboEstatusBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboEstatus = (int)EstatusUsuarioBusqueda.Todos;
            UsuariosPaginados usuariosPaginados;
            string buscar = txtBuscar.Text;
            DtoPropiedadesPaginacion dtoPropiedadesPaginacion;

            try
            {
                dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, buscar);
                if (comboEstatusBusqueda.SelectedItem != null)
                    comboEstatus = ((Item)(comboEstatusBusqueda.SelectedItem)).ValueInt;
                usuariosPaginados = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus, dtoPropiedadesPaginacion));
                usuariosPaginados.InicializarPagina();
                LimpiarGrid();
                AgregarBotonesGrid();              
                ListarUsuariosGrid(usuariosPaginados);

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
                catch (ExcepcionComun excepcionComun)
                {
                    MessageBox.Show(excepcionComun.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            UsuariosPaginados usuariosPaginados;
            int comboEstatus = (int)EstatusUsuarioBusqueda.Todos;
            DtoPropiedadesPaginacion dtoPropiedadesPaginacion;
            Guid idUsuario;

            try
            {
                
                if (columna.Equals("0") || columna.Equals("1"))
                {
                    idUsuario = Guid.Parse(dataGridViewUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString());
                    dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);

                    switch (columna)
                    {
                        case "0":
                            _servicioUsuarios.EliminarUsuarioPorId(idUsuario);
                            break;
                        case "1":
                            var editarUsuarioForm = EditarUsuarioFrm.Instancia;
                            editarUsuarioForm.ShowDialog(idUsuario);
                            break;

                    }

                    //var dtoBuscarProductosPaginados = new DtoBuscarProductosPaginados(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
                    //var productos = await _servicioProductos.ConsultarProductosPaginadosBD(dtoBuscarProductosPaginados);
                    LimpiarGrid();
                    AgregarBotonesGrid();
                    //CargarProveedores(await _servicioCatalogos.ConsultarProveedoresBD());
                    //productos.Pagina += 1;
                    //ListarProductosGrid(productos);
                    usuariosPaginados = (await _servicioUsuarios.ConsultarUsuariosPaginados(comboEstatus,dtoPropiedadesPaginacion));
                    dataGridViewUsuarios.DataSource = usuariosPaginados.Usuarios;

                }


            }catch (ExcepcionComun excepcionComun)
            {
                MessageBox.Show(excepcionComun.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void btnAvanzarPag_Click(object sender, EventArgs e)
        {
            try
            {
                var pagina = Int32.Parse(txtPagActual.Text);
                var buscarFiltro = txtBuscar.Text.Trim();

                var estatus = ((Item)(comboEstatusBusqueda.SelectedItem)).ValueInt;
                var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(pagina, TAMANIO_PAGINA_POR_DEFECTO, buscarFiltro);
                var usuarios = await _servicioUsuarios.ConsultarUsuariosPaginados(estatus, dtoPropiedadesPaginacion);
                LimpiarGrid();
                AgregarBotonesGrid();
                usuarios.Pagina += 1;
                ListarUsuariosGrid(usuarios);

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

        private async void btnRegresarPag_Click(object sender, EventArgs e)
        {
            try
            {

                var pagina = Int32.Parse(txtPagActual.Text);
                var buscarFiltro = txtBuscar.Text.Trim();
                var estatus = ((Item)(comboEstatusBusqueda.SelectedItem)).ValueInt;
                if (txtPagActual.Text == txtPaginasTotalesProductos.Text)
                    pagina -= 2;
                else
                    pagina -= 1;
                var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(pagina, TAMANIO_PAGINA_POR_DEFECTO, buscarFiltro);
                var usuarios = await _servicioUsuarios.ConsultarUsuariosPaginados(estatus, dtoPropiedadesPaginacion);
                LimpiarGrid();
                AgregarBotonesGrid();
                usuarios.Pagina = Int32.Parse(txtPagActual.Text) - 1;
                ListarUsuariosGrid(usuarios);
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

        #endregion Eventos

        #region Sobrecargas

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;
            base.Show();
        }

        #endregion Sobrecargas

        #region Lógica presentación reútilizable
        private void ListarUsuariosGrid(UsuariosPaginados usuariosPaginados)
        {
            try
            {

                dataGridViewUsuarios.DataSource = usuariosPaginados.Usuarios;
                txtPagActual.Text = usuariosPaginados.Pagina.ToString();
                txtPaginasTotalesProductos.Text = usuariosPaginados.TotalPaginas.ToString();

                btnAvanzarPag.Enabled = true;
                btnRegresarPag.Enabled = true;

                if (txtPagActual.Text.Equals(usuariosPaginados.TotalPaginas.ToString()) && !txtPagActual.Text.Equals("1"))
                {
                    btnAvanzarPag.Enabled = false;
                }
                if (txtPagActual.Text.Equals("1") && usuariosPaginados.TotalPaginas == 1)
                {

                    btnAvanzarPag.Enabled = false;

                }
                if (txtPagActual.Text.Equals("1"))
                {
                    btnRegresarPag.Enabled = false;
                }
                if (usuariosPaginados.TotalPaginas.ToString().Equals("0"))
                {

                    btnAvanzarPag.Enabled = false;
                    btnRegresarPag.Enabled = false;
                }

            }
            catch (ExcepcionComun excepcionComun)
            {
                MessageBox.Show(excepcionComun.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {

                throw exception;
            }
        }

        private void LimpiarGrid()
        {
            dataGridViewUsuarios.Columns.Clear();
            dataGridViewUsuarios.DataSource = null;

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

        #endregion Lógica presentación reútilizable

    }
}
