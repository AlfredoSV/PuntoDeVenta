
using Dominio.Dtos;
using Dominio.Repositorios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios
{
    public class ServicioAutenticacion
    {
        private static ServicioAutenticacion _instacia;

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

        }
        public bool ValidarUsuario(DtoUsuario dtoUsuario)
        {
            return true;
        }
    }
}
