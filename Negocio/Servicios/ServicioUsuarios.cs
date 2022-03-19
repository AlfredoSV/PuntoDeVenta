using AccesoDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios
{
    public class ServicioUsuarios
    {
        private static ServicioUsuarios _instancia;
        private static RepositorioUsuarios _repositorioUsuarios;
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
        }

        public void GuardarNuevoUsuario(DtoUsuario dtoUsuario)
        {
            try
            {
                _repositorioUsuarios.GuardarUsuario(null);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
