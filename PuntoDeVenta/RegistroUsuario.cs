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
            CargarProveedores(await _servicioCatalogos.ConsultarSucursalesBD());
            CargarRoles(await _servicioCatalogos.ConsultarRolesBD());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnRealizarSol_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var contrasenia = txtContrasenia.Text;
            var idRol = ((Item)(comBRol.SelectedItem)).Value;
            var idSucursal = ((Item)(comBSucursal.SelectedItem)).Value;
            var dtoUsuario = new DtoUsuario(usuario,contrasenia,idSucursal,idRol);
            _servicioUsuarios.GuardarNuevoUsuario(dtoUsuario);

        }

        private void CargarProveedores(IEnumerable<Sucursal> sucursales)
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
