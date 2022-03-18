using AccesoDatos.Repositorios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public  class ServicioCatalogos
    {
        private static ServicioCatalogos _instacia;
        private static RepositorioCatalogos _repositorioCatalogos;


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


        public ServicioCatalogos() {
            _repositorioCatalogos = RepositorioCatalogos.Instacia;
            _repositorioCatalogos.AgregarConexionBD(ConexionString.StrConexionBdSql.DefaultConexionSqlServer);
        }


        public async Task<IEnumerable<Proveedor>> ConsultarProveedoresBD()
        {
            return await _repositorioCatalogos.ConsultarProveedores();
        }
    }
}
