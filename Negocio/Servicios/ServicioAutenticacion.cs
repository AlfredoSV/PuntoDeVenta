
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicios
{
    public class ServicioAutenticacion
    {
        private readonly ConexionString _conDefault;
        public ServicioAutenticacion()
        {
            _conDefault = new ConexionString();
        }

        public ConexionString ConDefault => _conDefault;

        public void ValidarUsuario()
        {
            //_repositorioUsuario.ConsultarUsuario();
        }
    }
}
