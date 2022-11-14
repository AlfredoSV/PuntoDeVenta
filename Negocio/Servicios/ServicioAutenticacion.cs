
using AccesoDatos.Repositorios;
using Dominio.Repositorios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Aplicacion.Servicios
{
    public class ServicioAutenticacion
    {
        private static ServicioAutenticacion _instacia;
        private RepositorioUsuarios _repositorioUsuarios;

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
        }
        public async Task<bool> ValidarUsuario(string nombreUsuario, string contrasenia)
        {

            var usuario = await _repositorioUsuarios.ConsultarUsuarioPorNombreDeUsuario(nombreUsuario);
            IEnumerable<UsuarioIntento> intentosUsuario;

            if (usuario != null)
            {
                //Validar contraseña
                if (usuario.Contrsenia.Equals(contrasenia))
                {
                    intentosUsuario = await _repositorioUsuarios.ConsultarIntentosUsuario(usuario.IdUsuario);

                    if (intentosUsuario.Count() >= 3)
                        return false;
                    else if(!usuario.Contrsenia.Equals(contrasenia)))
                        _repositorioUsuarios.GuardarIntentoUsuario(UsuarioIntento.
                            Crear(usuario.IdUsuario));



                }
                else
                    return false;

            }
            
            return usuario != null;
        }

        public async Task<Usuario>  ConsultarUsuario(string nombreUsuario)
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
