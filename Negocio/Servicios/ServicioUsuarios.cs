using AccesoDatos.Repositorios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.Servicios
{
    public class ServicioUsuarios
    {
        private static ServicioUsuarios _instancia;
        private readonly RepositorioUsuarios _repositorioUsuarios;
        private readonly RepositorioCatalogos _repositorioCatalogos;
        public static ServicioUsuarios Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ServicioUsuarios();
                return _instancia;
            }
            set { }
        }


        public ServicioUsuarios()
        {
            _repositorioUsuarios = RepositorioUsuarios.Instacia;
            _repositorioCatalogos = RepositorioCatalogos.Instacia;
        }

        public async void GuardarNuevoUsuario(DtoUsuario dtoUsuario)
        {
            try
            {
                var sucursal = (await _repositorioCatalogos.ConsultarSucursales()).ToList().Where(s => s.IdSucursal == dtoUsuario.Idsucursal).FirstOrDefault();
                var rol = (await _repositorioCatalogos.ConsultarRoles()).ToList().Where(r => r.IdRol == dtoUsuario.Idrol).FirstOrDefault();
                var usuario = Usuario.CrearUsuario(Guid.NewGuid(), dtoUsuario.NombreUsuario, dtoUsuario.Contrsenia, DateTime.Now, false,sucursal, rol);
                _repositorioUsuarios.GuardarUsuario(usuario);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
