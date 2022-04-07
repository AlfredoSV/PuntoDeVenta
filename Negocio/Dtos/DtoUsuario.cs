using Dominio.Entidades;
using System;

namespace Aplicacion
{
    public class DtoUsuario
    {
        private Guid _idUsuario;
        private string _nombreUsuario;
        private string _contrasenia;
        private DateTime _fechayHoraAlta;
        private Guid _idsucursal;
        private Guid _idrol;
        private string _sucursal;
        private string _rol;
        private bool _activo;

        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public DateTime FechayHoraAlta { get => _fechayHoraAlta; set => _fechayHoraAlta = value; }
        public Guid Idsucursal { get => _idsucursal; set => _idsucursal = value; }
        public Guid Idrol { get => _idrol; set => _idrol = value; }
        public string Sucursal { get => _sucursal; set => _sucursal = value; }
        public string Rol { get => _rol; set => _rol = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        public DtoUsuario(Guid idUsuario, string nombreUsuario,string contrasenia, DateTime fechayHoraAlta, Guid idsucursal, Guid idrol, string sucursal, string rol, bool activo)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            FechayHoraAlta = fechayHoraAlta;
            Idsucursal = idsucursal;
            Idrol = idrol;
            Sucursal = sucursal;
            Rol = rol;
            Activo = activo;
            Contrasenia = contrasenia;
        }

        public DtoUsuario(string nombreUsuario, string contrsenia, Guid idsucursal, Guid idrol)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrsenia;
            Idsucursal = idsucursal;
            Idrol = idrol;
        }
        public DtoUsuario(Guid idUsuario,string nombreUsuario, string contrsenia, Guid idsucursal, Guid idrol,bool activo)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrsenia;
            Idsucursal = idsucursal;
            Idrol = idrol;
            Activo = activo;
        }
    }
}