
using AccesoDatos.Repositorios;
using Dominio.Repositorios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Framework.Security2023.Cryptography;

namespace Aplicacion.Servicios
{
    public class ServicioAutenticacion
    {
        private static ServicioAutenticacion _instacia;
        private RepositorioUsuarios _repositorioUsuarios;
        private readonly ServiceCryptography _serviceCryptography;

        public static ServicioAutenticacion Instacia
        {
            get
            {
                if (_instacia == null)
                    _instacia = new ServicioAutenticacion();

                return _instacia;

            }
            set => _instacia = value;
        }


        private ServicioAutenticacion()
        {
            _repositorioUsuarios = RepositorioUsuarios.Instacia;
            _repositorioUsuarios.AgregarConexionBD(ConexionString.StrConexionBdSql.DefaultConexionSqlServer);
            _serviceCryptography = new ServiceCryptography();
        }

        public async Task<bool> ValidarUsuario(string nombreUsuario, string contrasenia)
        {

            Usuario usuario = await _repositorioUsuarios.ConsultarUsuarioPorNombreDeUsuario(nombreUsuario);
            IEnumerable<UsuarioIntento> intentosUsuario;

            if (usuario != null)
            {
                intentosUsuario = await _repositorioUsuarios.ConsultarIntentosUsuario(usuario.IdUsuario);
                Guid userId = usuario.IdUsuario;
                string password = _serviceCryptography.Descrypt(usuario.Contrsenia, userId.ToString()).Trim();

                if (!password.Equals(contrasenia))
                {
                    _repositorioUsuarios.GuardarIntentoUsuario(UsuarioIntento.
                        Crear(usuario.IdUsuario));

                    return false;
                }
                else if (intentosUsuario.Count() >= 3)
                    return false;
                else if (!usuario.Activo)
                    return false;
    
                return true;
                  
            }

            return usuario != null;
        }

        public async Task<Usuario> ConsultarUsuario(string nombreUsuario)
        {
            var usuario = await _repositorioUsuarios.ConsultarUsuarioPorNombreDeUsuario(nombreUsuario);
            return usuario;
        }

        public IEnumerable<PermisosModulo> ConsultarPermisosPorIdUsuario(Guid idUsuario)
        {
            return _repositorioUsuarios.ConsultarPermisosPorIdUsuario(idUsuario);
        }
    }
}
