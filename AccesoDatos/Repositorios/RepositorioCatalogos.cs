using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorios
{
    public  class RepositorioCatalogos
    {
        private static RepositorioCatalogos _instacia;
        private static string _cadCon;

        public static RepositorioCatalogos Instacia
        {
            get
            {
                if (_instacia == null)
                    _instacia = new RepositorioCatalogos();

                return _instacia;

            }
            set => _instacia = value;
        }

        private RepositorioCatalogos() { }


        public async Task<IEnumerable<CatProveedores>> ConsultarProductos(string buscar)
        {
            var provedores = new List<CatProveedores>();
            var sql = "select * from Proveedores;";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);
        
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            provedores.Add(CatProveedores.Crear(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1),
                                sqlDataReader.GetString(2), sqlDataReader.GetDateTime(3)));
                        }
                    }


                    return provedores;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }


    }
}
