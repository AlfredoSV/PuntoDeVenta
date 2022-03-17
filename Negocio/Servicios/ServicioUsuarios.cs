using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios
{
    public class ServicioUsuarios
    {
        private static ServicioUsuarios _instancia;

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


        public void GuardarNuevoUsuario()
        {
            try
            {

            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
