using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class PermisosModulo
    {
        private Guid _idUsuario;
        private string _usuario;
        private string _nombreRol;
        private string _permisoModulo;
        private string _modulo;

        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string NombreRol { get => _nombreRol; set => _nombreRol = value; }
        public string PermisoModulo { get => _permisoModulo; set => _permisoModulo = value; }
        public string Modulo { get => _modulo; set => _modulo = value; }

        private PermisosModulo(Guid idUsuario, string usuario, string nombreRol, string permisoModulo, string modulo)
        {
            IdUsuario = idUsuario;
            Usuario = usuario;
            NombreRol = nombreRol;
            PermisoModulo = permisoModulo;
            Modulo = modulo;
        }

        public static PermisosModulo Crear(Guid idUsuario, string usuario, string nombreRol, string permisoModulo, string modulo)
        {
            return new PermisosModulo( idUsuario,  usuario,  nombreRol,  permisoModulo,  modulo);
        }
    }
}
