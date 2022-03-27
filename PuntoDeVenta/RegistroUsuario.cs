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
using PuntoDeVenta.ClasesAuxiliares;
using System.Windows.Forms;
using Aplicacion;
using Dominio;

namespace PuntoDeVenta
{
    public partial class RegistroUsuario : Form
    {
        private ServicioUsuarios _servicioUsuarios;
        private ServicioCatalogos _servicioCatalogos;
        public RegistroUsuario()
        {
            _servicioUsuarios = ServicioUsuarios.Instancia;
            _servicioCatalogos = ServicioCatalogos.Instacia;
            InitializeComponent();
        }

        private async void RegistroUsuario_Load(object sender, EventArgs e)
        {
            CargarSucursales(await _servicioCatalogos.ConsultarSucursalesBD());
            CargarRoles(await _servicioCatalogos.ConsultarRolesBD());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private async void btnRealizarSol_Click(object sender, EventArgs e)
        {
            
            var usuario = txtUsuario.Text.Trim();
            var contrasenia = txtContrasenia.Text.Trim();
            var idRol = ((Item)(comBRol.SelectedItem)).Value;
            var idSucursal = ((Item)(comBSucursal.SelectedItem)).Value;
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
                    this.Close();

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

        private void CargarSucursales(IEnumerable<Sucursal> sucursales)
        {
            var items = new List<Item>();

            items.Add(new Item("--- Seleciona un sucursal. ---", Guid.Empty));
            foreach (var get in sucursales)
            {
                items.Add(new Item(get.Nombre, get.IdSucursal));
            }

            comBSucursal.DisplayMember = "Name";
            comBSucursal.ValueMember = "Value";
            comBSucursal.DataSource = items;
        }

        private void CargarRoles(IEnumerable<Rol> sucursales)
        {
            var items = new List<Item>();

            items.Add(new Item("--- Seleciona un Rol. ---", Guid.Empty));
            foreach (var get in sucursales)
            {
                items.Add(new Item(get.Nombre, get.IdRol));
            }

            comBRol.DisplayMember = "Name";
            comBRol.ValueMember = "Value";
            comBRol.DataSource = items;
        }


    }
}
