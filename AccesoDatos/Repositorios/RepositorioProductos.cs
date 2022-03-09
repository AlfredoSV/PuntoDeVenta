using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;

using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Dominio.Repositorios
{
    public class RepositorioProductos
    {

        private static RepositorioProductos _instacia;
        private static string _cadCon;

        public static RepositorioProductos Instacia
        {
            get
            {
                if (_instacia == null)
                    _instacia = new RepositorioProductos();

                return _instacia;

            }
            set => _instacia = value;
        }

        private RepositorioProductos() { }

        public void AgregarConexionBD(string cadCon)
        {
            _cadCon = cadCon;
        }

        public async  Task<IEnumerable<Producto>> ConsultarProductos(string buscar)
        {
            var productos = new List<Producto>();
            var sql = "ConsultarProductos";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("buscar", buscar);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            productos.Add(Producto.Crear(sqlDataReader.GetGuid(0), sqlDataReader.GetInt32(1),
                                sqlDataReader.GetString(2), sqlDataReader.GetString(3),
                                sqlDataReader.GetDecimal(4), sqlDataReader.GetGuid(5), sqlDataReader.GetGuid(6)));
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

        public int ConsultarProductosTotal(string buscar)
        {
            var productos = new List<Producto>();
            var sql = "ConsultarProductosTotal";
            
            SqlCommand sqlCommand;
            var total = 0;
            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("buscar", buscar);
                    sqlCommand.Parameters.AddWithValue("total", total);
                    sqlCommand.Parameters["total"].Direction = ParameterDirection.Output;
                    sqlCommand.ExecuteNonQuery();

                    total = Convert.ToInt32(sqlCommand.Parameters["total"].Value);

                    return total;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public bool GuardarProducto(Producto dtoProducto)
        {

            var sql = "Insert into productos values(@idProducto,@stock,@nombre,@descripcion,@precio,'1FDD9D61-DFA7-4520-A01A-54370F8A5CBE',@idProveedor)";

            SqlCommand sqlCommand;
            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("idProducto", dtoProducto.IdProducto);
                    sqlCommand.Parameters.AddWithValue("stock", dtoProducto.Stock);
                    sqlCommand.Parameters.AddWithValue("nombre", dtoProducto.Nombre);
                    sqlCommand.Parameters.AddWithValue("descripcion", dtoProducto.Descripcion);
                    sqlCommand.Parameters.AddWithValue("precio", dtoProducto.Precio);
                    sqlCommand.Parameters.AddWithValue("idProveedor", dtoProducto.IdProveedor);

                    return sqlCommand.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
