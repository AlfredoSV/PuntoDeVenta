using Negocio.IServicios;
using System;
using System.Collections.Generic;
using System.Text;
using Negocio.IRepositorios;

namespace Negocio.Servicios
{
    public class ServicioAutenticacion : IServicioAutenticacion
    {
        private readonly IRepositorioUsuario _repositorioUsuario;
        public ServicioAutenticacion(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }
        public void ValidarUsuario()
        {
            //_repositorioUsuario.ConsultarUsuario();
        }
    }
}
