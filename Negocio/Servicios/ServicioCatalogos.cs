using Aplicacion.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public  class ServicioCatalogos
    {
        private static ServicioCatalogos _instacia;
     

        public static ServicioCatalogos Instacia
        {
            get
            {
                if (_instacia == null)
                    _instacia = new ServicioCatalogos();

                return _instacia;

            }
            set => _instacia = value;
        }


        public ServicioCatalogos() { }


        public async Task<CatProveedores> ConsultarProveedoresBD()
        {
            return null;
        }
    }
}
