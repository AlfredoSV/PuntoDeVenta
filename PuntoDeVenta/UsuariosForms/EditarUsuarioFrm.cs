using Aplicacion;
using Aplicacion.Servicios;
using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PuntoDeVenta.ClasesAuxiliares;
using Aplicacion.Enums;
using System.Linq;

namespace PuntoDeVenta.UsuariosForms
{
    public partial class EditarUsuarioFrm : Form
    {
        private static EditarUsuarioFrm _instancia;
        private Guid _idUsuario;
        private Usuario _usuarioLogueado;
        private readonly ServicioUsuarios _servicioUsuarios;
        private readonly ServicioCatalogos _servicioCatalogos;

        public static EditarUsuarioFrm Instancia
        {
            get
            {

                if (_instancia == null)
                    _instancia = new EditarUsuarioFrm();

                return _instancia;
            }
            set => _instancia = value;
        }

       
        public EditarUsuarioFrm()
        {
            _servicioUsuarios = ServicioUsuarios.Instancia;
            _servicioCatalogos = ServicioCatalogos.Instacia;
            InitializeComponent();
        }

        private async void EditarUsuarioFrm_Load(object sender, EventArgs e)
        {
            DtoUsuario dtoUsuario;
            try
            {
              
                dtoUsuario = await _servicioUsuarios.DetalleUsuario(_idUsuario);             
                txtUsuario.Text = dtoUsuario.NombreUsuario;
                txtContrasenia.Text = dtoUsuario.Contrasenia;
                CargarSucursales(await _servicioCatalogos.ConsultarSucursalesBD(),dtoUsuario.Idsucursal);
                CargarRoles(await _servicioCatalogos.ConsultarRolesBD(),dtoUsuario.Idrol);
                CargarEstatus(dtoUsuario.Activo);
            }
            catch (ExcepcionComun excepcionComun)
            {
                MessageBox.Show(excepcionComun.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        public void ShowDialog(Guid idUsuario, Usuario usuarioLogueado)
        {
            _usuarioLogueado = usuarioLogueado;
            _idUsuario = idUsuario;
            this.ShowDialog();
        }

        private void btnSalirEditarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarEstatus(bool activo)
        {
            var items = new List<Item>();
            if (activo)
            {
                items.Add(new Item("Activo", (int)EstatusUsuarioBusqueda.Activos));
                items.Add(new Item("Inactivo", (int)EstatusUsuarioBusqueda.Inactivos));
              
            }
            else
            {
                items.Add(new Item("Inactivo", (int)EstatusUsuarioBusqueda.Inactivos));
                items.Add(new Item("Activo", (int)EstatusUsuarioBusqueda.Activos));
           
            }


            comboEstatusBusqueda.DisplayMember = "Name";
            comboEstatusBusqueda.ValueMember = "Value";
            comboEstatusBusqueda.DataSource = items;
        }

        private void CargarSucursales(IEnumerable<Sucursal> sucursales,Guid idSucursal)
        {
            var items = new List<Item>();
            var sucuUsuario = sucursales.Where(s => s.IdSucursal == idSucursal).FirstOrDefault();
            items.Add(new Item(sucuUsuario.Nombre, sucuUsuario.IdSucursal));

            foreach (var get in sucursales)
            {
                if(get.IdSucursal != idSucursal)
                    items.Add(new Item(get.Nombre, get.IdSucursal));
            }

            comboBoxSucursales.DisplayMember = "Name";
            comboBoxSucursales.ValueMember = "Value";
            comboBoxSucursales.DataSource = items;
        }

        private void CargarRoles(IEnumerable<Rol> roles,Guid idRol)
        {
            var items = new List<Item>();
            var rolUsuario = roles.Where(r => r.IdRol == idRol).FirstOrDefault();
            items.Add(new Item(rolUsuario.Nombre, rolUsuario.IdRol));
            foreach (var get in roles)
            {
                if (get.IdRol != idRol)
                    items.Add(new Item(get.Nombre, get.IdRol));
            }

            comboBoxRoles.DisplayMember = "Name";
            comboBoxRoles.ValueMember = "Value";
            comboBoxRoles.DataSource = items;
        }

        private async void btnGuardarUsuarioEditado_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text.Trim();
            var contrasenia = txtContrasenia.Text.Trim();
            var idRol = ((Item)(comboBoxRoles.SelectedItem)).Value;
            var idSucursal = ((Item)(comboBoxSucursales.SelectedItem)).Value;
            var activo = Convert.ToBoolean(((Item)(comboEstatusBusqueda.SelectedItem)).ValueInt);
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
                mensajeValidacion += "* Favor de ingresar una contraseña \n";
                validacion = false;
            }

            if (validacion)
            {
                try
                {
                    dtoUsuario = new DtoUsuario(_idUsuario,usuario, contrasenia, idSucursal, idRol,activo);
                    await _servicioUsuarios.EditarUsuario(dtoUsuario, _usuarioLogueado.IdUsuario);
                    MessageBox.Show("El usuario se edito de forma correcta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


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
    }
}
