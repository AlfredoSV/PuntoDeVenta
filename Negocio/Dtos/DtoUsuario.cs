using Dominio.Entidades;
using System;

namespace Aplicacion
{
    public class DtoUsuario
    {
        private Guid _idUsuario;
        private string _nombreUsuario;
        private string _contrsenia;
        private DateTime _fechayHoraAlta;
        private Guid _idsucursal;
        private Guid _idrol;

        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contrsenia { get => _contrsenia; set => _contrsenia = value; }
        public DateTime FechayHoraAlta { get => _fechayHoraAlta; set => _fechayHoraAlta = value; }
        public Guid Idsucursal { get => _idsucursal; set => _idsucursal = value; }
        public Guid Idrol { get => _idrol; set => _idrol = value; }

        public DtoUsuario(Guid idUsuario, string nombreUsuario, string contrsenia, DateTime fechayHoraAlta, Guid idsucursal, Guid idrol)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contrsenia = contrsenia;
            FechayHoraAlta = fechayHoraAlta;
            Idsucursal = idsucursal;
            Idrol = idrol;
        }

        public DtoUsuario(string nombreUsuario, string contrsenia, Guid idsucursal, Guid idrol)
        {
            NombreUsuario = nombreUsuario;
            Contrsenia = contrsenia;
            Idsucursal = idsucursal;
            Idrol = idrol;
        }
    }
}