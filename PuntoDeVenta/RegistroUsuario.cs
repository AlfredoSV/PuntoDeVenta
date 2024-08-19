using Aplicacion.Servicios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
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
            IEnumerable<Sucursal> branches = await _servicioCatalogos.ConsultarSucursalesBD();
            IEnumerable<Rol> roles = await _servicioCatalogos.ConsultarRolesBD();

            if(!(branches.Any() && roles.Any()))
          {
                MessageBox.Show("No se cargarón sucursales y/o roles, favor de consultar con sistemas.","Warning");
                btnRealizarSol.Enabled = false;
                return;
            }

            btnRealizarSol.Enabled = true;
            ItemComboBox.CargarComboItems(comBSucursal, branches, "--- Seleciona un sucursal. ---", "IdSucursal");
            ItemComboBox.CargarComboItems(comBRol, roles, "--- Seleciona un role. ---", "IdRol");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private async void btnRealizarSol_Click(object sender, EventArgs e)
        {
            
            string userName = txtUsuario.Text.Trim();
            string pass = txtContrasenia.Text.Trim();
            Guid idRol = ((Item)(comBRol.SelectedItem)).Value;
            Guid idSucursal = ((Item)(comBSucursal.SelectedItem)).Value;
            DtoUsuario dtoUsuario;

            bool isAValidRequest = true;
            string mensajeValidacion = string.Empty;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrWhiteSpace(pass))
            {              
                mensajeValidacion += "* Favor de ingresar un usuario \n";
                isAValidRequest = false;
            }
            if (String.IsNullOrEmpty(userName) || string.IsNullOrWhiteSpace(pass))
            {
                mensajeValidacion += "* Favor de ingresar una contrasenia \n";
                isAValidRequest = false;
            }
            if (idRol.Equals(Guid.Empty))
            {
                mensajeValidacion += "* Favor de seleccionar un Rol \n";
                isAValidRequest = false;
            }
            if (idSucursal.Equals(Guid.Empty))
            {
                mensajeValidacion += "* Favor de seleccionar una sucursal \n";
                isAValidRequest = false;
            }

            if (isAValidRequest)
            {
                try
                {
                    dtoUsuario = new DtoUsuario(userName, pass, idSucursal, idRol);
                    await _servicioUsuarios.GuardarNuevoUsuario(dtoUsuario);
                    this.Close();

                }
                catch (ExcepcionComun exception)
                {
                    MessageBox.Show(exception.Detalle, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Sucedió un error no controlado, favor de contactar con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show(mensajeValidacion, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

    }
}
