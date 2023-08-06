using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorios
{
    public class RepositorioCatalogos
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

        public void AgregarConexionBD(string cadCon)
        {
            _cadCon = cadCon;
        }

        public async Task<IEnumerable<Proveedor>> ConsultarProveedores()
        {
            var provedores = new List<Proveedor>();
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
                            provedores.Add(Proveedor.Crear(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1),
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

        public async Task<IEnumerable<Sucursal>> ConsultarSucursales()
        {
            var sucursales = new List<Sucursal>();
            var sql = "select * from Sucursales;";
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
                            sucursales.Add(Sucursal.Crear(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1),sqlDataReader.GetDateTime(2)));
                        }
                    }


                    return sucursales;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<IEnumerable<Rol>> ConsultarRoles()
        {
            var roles = new List<Rol>();
            var sql = "select * from Roles;";
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
                            roles.Add(Rol.Crear(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetDateTime(3)));
                        }
                    }


                    return roles;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }


    }
}
