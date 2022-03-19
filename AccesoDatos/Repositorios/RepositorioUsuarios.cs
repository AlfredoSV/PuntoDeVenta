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
                        Sucursales suc on suc.idSucursal = usu.idSucursal where  usu.usuario = @nombreUsuario and usu.contrasenia = @contrasenia and activo = 1";
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


                        rol = Rol.Crear(sqlDataReader.GetGuid(4), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));

                        sucursal = Sucursal.Crear(sqlDataReader.GetGuid(11), sqlDataReader.GetString(12), sqlDataReader.GetDateTime(13));

                        usuario = Usuario.CrearUsuario(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                            sqlDataReader.GetDateTime(3), sqlDataReader.GetBoolean(6), sucursal, rol);

                    }



                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return usuario;
        }

        public IEnumerable<PermisosModulo> ConsultarPermisosPorIdUsuario(Guid idUsuario)
        {

            var sql = @"SELECT usu.idUsuario,usu.usuario,rol.nombre,
            opmod.nombre,modl.nombre FROM Usuarios usu inner join Roles rol on usu.idRol = rol.idRol
            inner join RolOperacion rolop on rol.idRol = rolop.idRol inner join OperacionesModulos opmod
            on rolop.idOperaMod = opmod.idOperaMod inner join Modulos modl on opmod.idModulo = opmod.idModulo where usu.idUsuario = @idUsuario ;";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            var permisosModulo = new List<PermisosModulo>();

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
                            permisosModulo.Add(PermisosModulo.Crear(sqlDataReader.GetGuid(0),sqlDataReader.GetString(1),sqlDataReader.GetString(2),sqlDataReader.GetString(3),sqlDataReader.GetString(4)));
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
    
        public void GuardarUsuario(Usuario usuario)
        {
            var sql = @"INSERT INTO [dbo].[Usuarios]
           ([idUsuario]
           ,[usuario]
           ,[contrasenia]
           ,[fechayHoraAlta]
           ,[idSucursal]
           ,[idRol]
           ,[activo])
     VALUES
           (@idUsuario
           ,@usuario
           ,@contrasenia
           ,@fechayHoraAlta
           ,@idSucursal
           ,@idRol
           ,@activo)";
            SqlCommand sqlCommand;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);

                    sqlCommand.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                    sqlCommand.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("@contrasenia", usuario.Contrsenia);
                    sqlCommand.Parameters.AddWithValue("@fechayHoraAlta", usuario.FechayHoraAlta);
                    sqlCommand.Parameters.AddWithValue("@idSucursal", usuario.Sucursal.IdSucursal);
                    sqlCommand.Parameters.AddWithValue("@idRol", usuario.Rol.IdRol);
                    sqlCommand.Parameters.AddWithValue("@activo", usuario.Activo);

                    sqlCommand.ExecuteNonQuery();


                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    
    }
}
