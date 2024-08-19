using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

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

        public async Task<Usuario> ConsultarUsuarioPorNombreDeUsuario(string nombreUsuario)
        {

            string sql = @"select usu.*,rol.*,suc.* from Usuarios usu inner join Roles rol on usu.idRol = rol.idRol inner join 
                        Sucursales suc on suc.idSucursal = usu.idSucursal where  usu.usuario = @nombreUsuario";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            Usuario usuario = null;
            Rol rol = null;
            Sucursal sucursal = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();
                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();

                        rol = Rol.Crear(
                            sqlDataReader.GetGuid(5),
                            sqlDataReader.GetString(8),
                            sqlDataReader.GetString(9),
                            sqlDataReader.GetDateTime(10));

                        sucursal = Sucursal.Crear(
                            sqlDataReader.GetGuid(11),
                            sqlDataReader.GetString(12),
                            sqlDataReader.GetDateTime(13));

                        usuario = Usuario.CrearUsuario(
                            sqlDataReader.GetGuid(0),
                            sqlDataReader.GetString(1),
                            sqlDataReader.GetString(2),
                            sqlDataReader.GetDateTime(3),
                            sqlDataReader.GetBoolean(6), sucursal, rol);

                    }

                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return usuario;
        }

        public async Task<Usuario> ConsultarDetalleUsuario(Guid idUsuario)
        {
            string sql = @"select usu.*,rol.*,suc.* from Usuarios usu inner join Roles rol on usu.idRol = rol.idRol inner join 
                        Sucursales suc on suc.idSucursal = usu.idSucursal where usu.idUsuario = @idUsuario";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            Usuario usuario = null;
            Rol rol = null;
            Sucursal sucursal = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();


                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            rol = Rol.Crear(
                                sqlDataReader.GetGuid(5), sqlDataReader.GetString(8),
                                sqlDataReader.GetString(9),
                                sqlDataReader.GetDateTime(10));

                            sucursal = Sucursal.Crear(
                                sqlDataReader.GetGuid(11), sqlDataReader.GetString(12), sqlDataReader.GetDateTime(13));

                            usuario = Usuario.CrearUsuario(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                                sqlDataReader.GetDateTime(3), sqlDataReader.GetBoolean(6), sucursal, rol);


                        }

                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return usuario;
        }

        public async Task<IEnumerable<Usuario>> ConsultarUsuarios()
        {

            string sql = @"select usu.*,rol.*,suc.* from Usuarios usu inner join Roles rol on usu.idRol = rol.idRol inner join 
                        Sucursales suc on suc.idSucursal = usu.idSucursal";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            Usuario usuario;
            List<Usuario> usuarios = new List<Usuario>();
            Rol rol = null;
            Sucursal sucursal = null;

            try
            {
                using (SqlConnection conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            rol = Rol.Crear(sqlDataReader.GetGuid(4), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));

                            sucursal = Sucursal.Crear(sqlDataReader.GetGuid(11), sqlDataReader.GetString(12), sqlDataReader.GetDateTime(13));
                            usuario = Usuario.CrearUsuario(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                                sqlDataReader.GetDateTime(3), sqlDataReader.GetBoolean(6), sucursal, rol);

                            usuarios.
                                Add(usuario);
                        }

                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return usuarios;
        }

        public async Task<IEnumerable<UsuarioIntento>> ConsultarIntentosUsuario(Guid idUsuario)
        {
            string sql = @"SELECT * FROM UsuariosIntentos where idUsuario = @idUsuario;";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            UsuarioIntento usuarioIntento;
            List<UsuarioIntento> usuarioIntentos = new List<UsuarioIntento>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();

                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("idUsuario", idUsuario);
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {

                            usuarioIntento = UsuarioIntento.Crear(sqlDataReader.GetGuid(0), sqlDataReader.GetGuid(1),
                                sqlDataReader.GetDateTime(2));

                            usuarioIntentos.
                                Add(usuarioIntento);
                        }

                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return usuarioIntentos;
        }

        public IEnumerable<PermisosModulo> ConsultarPermisosPorIdUsuario(Guid idUsuario)
        {

            string sql = @"SELECT usu.idUsuario,usu.usuario,rol.nombre,
            opmod.nombre,modl.nombre FROM Usuarios usu inner join Roles rol on usu.idRol = rol.idRol
            inner join RolOperacion rolop on rol.idRol = rolop.idRol inner join OperacionesModulos opmod
            on rolop.idOperaMod = opmod.idOperaMod inner join Modulos modl on opmod.idModulo = opmod.idModulo where usu.idUsuario = @idUsuario ;";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            List<PermisosModulo> permisosModulo = new List<PermisosModulo>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();
                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("idUsuario", idUsuario);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            permisosModulo.Add(PermisosModulo.Crear(sqlDataReader.GetGuid(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetString(4)));
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
            string sql = @"INSERT INTO [dbo].[Usuarios]
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
                using (SqlConnection conexion = new SqlConnection(_cadCon))
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

        public void GuardarIntentoUsuario(UsuarioIntento usuarioIntento)
        {
            var sql = @"INSERT INTO [dbo].[UsuariosIntentos]
           ([idUsuarioIntento]
           ,[idUsuario]
           ,[fechayHoraIntento])
           VALUES
           (@idUsuarioIntento,
           @idUsuario,
           @fechayHoraIntento)";
            SqlCommand sqlCommand;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();
                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("@idUsuario", usuarioIntento.IdUsuario);
                    sqlCommand.Parameters.AddWithValue("@idUsuarioIntento", Guid.NewGuid());
                    sqlCommand.Parameters.AddWithValue("@fechayHoraIntento", DateTime.Now);

                    sqlCommand.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<bool> ConsultarSiExisteUsuario(string nombreUsuario)
        {
            string sql = @"select convert(bit,isnull((SELECT top 1 1 FROM USUARIOS WHERE usuario = @nombreUsuario),0) )";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand;
            bool res = false;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {
                    conexion.Open();
                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("nombreUsuario", nombreUsuario);

                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        await sqlDataReader.ReadAsync();
                        res = sqlDataReader.GetBoolean(0);
                    }

                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return res;
        }

        public async Task<bool> ActualizarDatosUsuario(Usuario usuario)
        {
            string sql = @"UPDATE [dbo].[Usuarios]
                       SET 
                          [usuario] = @usuario
                          ,[contrasenia] = @contrasenia
                          ,[idSucursal] = @idSucursal
                          ,[idRol] = @idRol
                          ,[activo] = @activo
                     WHERE [idUsuario] = @idUsuario";
            SqlCommand sqlCommand;
            bool res = false;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {

                    conexion.Open();
                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("usuario", usuario.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("contrasenia", usuario.Contrsenia);
                    sqlCommand.Parameters.AddWithValue("idSucursal", usuario.Sucursal.IdSucursal);
                    sqlCommand.Parameters.AddWithValue("idRol", usuario.Rol.IdRol);
                    sqlCommand.Parameters.AddWithValue("activo", usuario.Activo);
                    sqlCommand.Parameters.AddWithValue("idUsuario", usuario.IdUsuario);
                    await sqlCommand.ExecuteNonQueryAsync();

                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return res;
        }

        public async Task<bool> EliminarUsuario(Guid idUsuario)
        {
            string sql = @"delete from usuarios where idUsuario = @idUsuario";
            SqlCommand sqlCommand;
            bool res = false;

            try
            {
                using (var conexion = new SqlConnection(_cadCon))
                {

                    conexion.Open();
                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                    await sqlCommand.ExecuteNonQueryAsync();

                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return res;
        }


    }
}
