using System;
using System.Collections.Generic;
using System.Text;
using Negocio.Entidades;
using Negocio.IRepositorios;
using System.Data.SqlClient;

namespace AccesoDatos.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private string _cadCon;
        public RepositorioUsuario(string cadCon)
        {
            _cadCon = cadCon;
        }
        public IEnumerable<Producto> ConsultarProductos()
        {
            var productos = new List<Producto>();
            var sql = "Select * from productos";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);

                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            productos.Add(Producto.Crear(sqlDataReader.GetGuid(1), sqlDataReader.GetInt32(2),
                                sqlDataReader.GetString(3), sqlDataReader.GetString(4),
                                sqlDataReader.GetDecimal(6), sqlDataReader.GetGuid(7), sqlDataReader.GetGuid(8)));
                        }
                    }


                    return productos;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
