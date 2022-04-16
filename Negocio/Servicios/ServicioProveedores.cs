using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios
{
    public class ServicioProveedores
    {
        private static ServicioProveedores _instancia;

        public static ServicioProveedores Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ServicioProveedores();

                return _instancia;
            }
            set => _instancia = value;
        }




    }
}
