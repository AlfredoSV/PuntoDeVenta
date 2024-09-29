
using AccesoDatos.Repositorios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            int intentosUsuario;
            string password;
            Usuario usuario = await _repositorioUsuarios.ConsultarUsuarioPorNombreDeUsuario(nombreUsuario);

            if (usuario is null)
            {
                return false;
            }

            intentosUsuario = await _repositorioUsuarios.ConsultarIntentosUsuario(usuario.IdUsuario);
            password = _serviceCryptography.Descrypt(usuario.Contrsenia, usuario.IdUsuario.ToString());

            if (!password.Equals(contrasenia, StringComparison.InvariantCultureIgnoreCase))
            {
                _repositorioUsuarios.GuardarIntentoUsuario(UsuarioIntento.Crear(usuario.IdUsuario));
                return false;
            }

            return !(intentosUsuario >= 3 || !usuario.Activo);
        }

        public async Task<Usuario> ConsultarUsuario(string nombreUsuario) => await _repositorioUsuarios.ConsultarUsuarioPorNombreDeUsuario(nombreUsuario);

        public IEnumerable<PermisosModulo> ConsultarPermisosPorIdUsuario(Guid idUsuario) =>  _repositorioUsuarios.ConsultarPermisosPorIdUsuario(idUsuario);

    }
}
