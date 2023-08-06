using AccesoDatos.Repositorios;
using Aplicacion.Dtos;
using Aplicacion.Enums;
using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.Security2023.Cryptography;

namespace Aplicacion.Servicios
{
    public class ServicioUsuarios
    {
        private static ServicioUsuarios _instancia;
        private readonly RepositorioUsuarios _repositorioUsuarios;
        private readonly RepositorioCatalogos _repositorioCatalogos;
        private readonly ServiceCryptography _serviceCryptography;
       
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
            _serviceCryptography = new ServiceCryptography();
        }

        public async Task GuardarNuevoUsuario(DtoUsuario dtoUsuario)
        {
            try
            {
                if (await _repositorioUsuarios.ConsultarSiExisteUsuario(dtoUsuario.NombreUsuario))
                    throw new ExcepcionComun("Aplicacion", $"Este nombre de usuario {dtoUsuario.NombreUsuario} no está disponible", "GuardarNuevoUsuario");

                Sucursal sucursal = (await _repositorioCatalogos.ConsultarSucursales()).ToList().Where(s => s.IdSucursal == dtoUsuario.Idsucursal).FirstOrDefault();
                Rol rol = (await _repositorioCatalogos.ConsultarRoles()).ToList().Where(r => r.IdRol == dtoUsuario.Idrol).FirstOrDefault();

                Guid userId = Guid.NewGuid();
                string password = _serviceCryptography.Encrypt(dtoUsuario.Contrasenia, userId.ToString());

                Usuario usuario = Usuario.CrearUsuario(userId, dtoUsuario.NombreUsuario, password, DateTime.Now, false, sucursal, rol);
                _repositorioUsuarios.GuardarUsuario(usuario);

            }
            catch (ExcepcionComun excepcionComun)
            {
                throw excepcionComun;
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public async Task<DtoUsuario> DetalleUsuario(Guid idUsuario)
        {
            Usuario usuario = null;
            DtoUsuario dtoUsuario = null;
            try
            {

                usuario = await _repositorioUsuarios.ConsultarDetalleUsuario(idUsuario);
                dtoUsuario = new DtoUsuario(usuario.IdUsuario, usuario.NombreUsuario,usuario.Contrsenia, usuario.FechayHoraAlta, usuario.Sucursal.IdSucursal, usuario.Rol.IdRol, usuario.Sucursal.Nombre, usuario.Rol.Nombre, usuario.Activo);

            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;

            }
            catch (Exception exception)
            {

                throw exception;

            }
            return dtoUsuario;
        }

        public async Task<UsuariosPaginados> ConsultarUsuariosPaginados(int estatus, DtoPropiedadesPaginacion dtoPropiedadesPaginacion)
        {
            var usuarios = new List<Usuario>();
            UsuariosPaginados dtoUsuariosPaginados;
            var totalUsuarios = 0;
            var totalPaginas = 0;
            var dtoUsuarios = new List<DtoUsuario>();

            try
            {
                usuarios = (await _repositorioUsuarios.ConsultarUsuarios()).ToList();

                if (estatus != (int)EstatusUsuarioBusqueda.Todos)
                    usuarios = (usuarios).Where(u => (u.Activo == (estatus == (int)EstatusUsuarioBusqueda.Activos))).ToList();

                if (!dtoPropiedadesPaginacion.BuscarFiltro.Equals(""))
                    usuarios = (usuarios).Where(u => u.NombreUsuario.Contains(dtoPropiedadesPaginacion.BuscarFiltro)).ToList();

                totalUsuarios = usuarios.Count;
                totalPaginas = (int)Math.Ceiling((double)totalUsuarios / dtoPropiedadesPaginacion.TamanioPagina);

                usuarios = usuarios.Skip(dtoPropiedadesPaginacion.Pagina * dtoPropiedadesPaginacion.TamanioPagina).Take(dtoPropiedadesPaginacion.TamanioPagina).ToList();
                usuarios.ForEach(u => dtoUsuarios.Add(new DtoUsuario(u.IdUsuario, u.NombreUsuario,u.Contrsenia, u.FechayHoraAlta, u.Sucursal.IdSucursal, u.Rol.IdRol, u.Sucursal.Nombre, u.Rol.Nombre, u.Activo)));

            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;


            }
            catch (Exception exception)
            {

                throw exception;

            }
            dtoUsuariosPaginados = new UsuariosPaginados(dtoUsuarios, dtoPropiedadesPaginacion.Pagina, dtoPropiedadesPaginacion.TamanioPagina, totalUsuarios, totalPaginas);

            return dtoUsuariosPaginados;

        }

        public async Task EliminarUsuarioPorId(Guid idUsuario,Guid usuarioLogueado)
        {
            try
            {
                if (idUsuario.Equals(usuarioLogueado))
                    throw new ExcepcionComun("Servicio", "No es posible eliminar el usuario con el que ahora mismo está logueado", "EliminarUsuarioPorId");
                await _repositorioUsuarios.EliminarUsuario(idUsuario);

            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;


            }
            catch (Exception exception)
            {

                throw exception;

            }

        }

        public async Task EditarUsuario(DtoUsuario dtoUsuario, Guid idUsuarioLogueado)
        {
            try
            {
                if (dtoUsuario.IdUsuario.Equals(idUsuarioLogueado))
                    throw new ExcepcionComun("Aplicación", "No es posible editar el usuario con el que actualmente esta logueado", "EditarUsuario");
                Guid userId = dtoUsuario.IdUsuario;
                string password = _serviceCryptography.Encrypt(dtoUsuario.Contrasenia, userId.ToString());

                var rol = (await _repositorioCatalogos.ConsultarRoles()).Where(r => r.IdRol == dtoUsuario.Idrol).FirstOrDefault();
                var sucursal = (await _repositorioCatalogos.ConsultarSucursales()).Where(s => s.IdSucursal == dtoUsuario.Idsucursal).FirstOrDefault();
                var usuario = Usuario.CrearUsuario(dtoUsuario.IdUsuario,
                    dtoUsuario.NombreUsuario, password, dtoUsuario.FechayHoraAlta, dtoUsuario.Activo, sucursal, rol
                    );
                await _repositorioUsuarios.ActualizarDatosUsuario(usuario);

            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;


            }
            catch (Exception exception)
            {

                throw exception;

            }
        }
    }
}
