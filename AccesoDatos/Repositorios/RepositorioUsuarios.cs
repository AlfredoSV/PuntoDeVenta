using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos.Repositorios
{
    public class RepositorioUsuarios
    {

        private static RepositorioUsuarios _instacia;
        private static string _cadCon;

        public static RepositorioUsuarios Instacia
        {
            get
            {
                if (_instacia == null)
                    _instacia = new RepositorioUsuarios();

                return _instacia;

            }
            set => _instacia = value;
        }

        public void AgregarConexionBD(string cadCon)
        {
            _cadCon = cadCon;
        }
        private RepositorioUsuarios() { }

        public Usuario ConsultarUsuarioPorCredenciales(string nombreUsuario, string contrasenia)
        {

            var sql = @"select usu.*,rol.*,suc.* from Usuarios usu inner join Roles rol on usu.idRol = rol.idRol inner join 
                        Sucursales suc on suc.idSucursal = usu.idSucursal where  usu.usuario = @nombreUsuario and usu.contrasenia = @contrasenia";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            Usuario usuario = null;
            Rol rol = null;
            Sucursal sucursal = null;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);

                    sqlCommand.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
                    sqlCommand.Parameters.AddWithValue("contrasenia", contrasenia);


                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();


                        rol = Rol.CrearRol(sqlDataReader.GetGuid(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetDateTime(9));

                        sucursal = Sucursal.Create(sqlDataReader.GetGuid(10), sqlDataReader.GetString(11), sqlDataReader.GetDateTime(12));

                        usuario = Usuario.CrearUsuario(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                            sqlDataReader.GetDateTime(3), sucursal, rol);

                    }



                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return usuario;
        }

        public PermisosModulo ConsultarPermisosPorIdUsuario(Guid idUsuario)
        {

            var sql = @"SELECT accm.*,ro.*,modu.* FROM Modulos modu inner join AccionesModulos accm on modu.idModulo = accm.idModulo inner join
                Roles ro on ro.idRol = accm.idRol inner join Usuarios usu on usu.idRol = ro.idRol
                where idUsuario = @idUsuario";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            PermisosModulo permisosModulo = null;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);

                    sqlCommand.Parameters.AddWithValue("idUsuario", idUsuario);

                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {

                        }

                    }



                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return permisosModulo;

        }
    }
}
