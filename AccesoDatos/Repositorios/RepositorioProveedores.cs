using System;
using System.Collections.Generic;
using System.Text;

using Dominio.Entidades;
using System.Data.SqlClient;

namespace AccesoDatos.Repositorios
{
    public class RepositorioProveedores
    {
        private static RepositorioProveedores _instancia;
        private static string _cadCon;


        public static RepositorioProveedores Instancia{
            get {

                if (_instancia == null)
                    _instancia = new RepositorioProveedores();

                return _instancia;
                
            }

            set { _instancia = value; }
        }
        public void AgregarConexionBD(string cadCon)
        {
            _cadCon = cadCon;
        }

        public async void EliminarProveedorePorId(Guid idProveedor)
        {
            var sql = @"DELETE * FROM Proveedores WHERE idProveedor = @idProveedor";
            SqlCommand sqlCommand;
          
            try
            {

                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();
                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("@idProveedor", idProveedor);
                    await sqlCommand.ExecuteNonQueryAsync();
                                     
                }
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }

        public Proveedor ConsultarDetalleProveedor(Guid idProveedor)
        {
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception exception)
            {

                throw;
            }
        }

        public void EditarProveedor(Proveedor proveedor)
        {
            try
            {

            }
            catch (Exception exception)
            {

                throw;
            }
        }
    }
}
