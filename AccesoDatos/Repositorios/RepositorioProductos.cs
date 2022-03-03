using System;
using System.Collections.Generic;
using System.Text;
using Negocio.Entidades;

using System.Data.SqlClient;

namespace AccesoDatos.Repositorios
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
        public IEnumerable<DtoProducto> ConsultarProductos()
        {
            var productos = new List<DtoProducto>();
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
                            productos.Add(new DtoProducto(sqlDataReader.GetGuid(0), sqlDataReader.GetInt32(1),
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

        public bool GuardarProducto(DtoProducto dtoProducto)
        {

            var sql = "Insert into productos values(@idProducto,@stock,@nombre,@descripcion,@precio,@idInventario,@idProveedor)";

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
                    sqlCommand.Parameters.AddWithValue("idInventario", dtoProducto.IdInventario);
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
