using System;

namespace Dominio.Entidades
{
    public class Sucursal
    {
        private Guid _idSucursal;
        private string _nombre;
        private DateTime _fechayHoraAlta;

        public Guid IdSucursal { get => _idSucursal; set => _idSucursal = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechayHoraAlta { get => _fechayHoraAlta; set => _fechayHoraAlta = value; }

        public Sucursal(Guid idSucursal, string nombre, DateTime fechayHoraAlta)
        {
            IdSucursal = idSucursal;
            Nombre = nombre;
            FechayHoraAlta = fechayHoraAlta;
        }

        public static Sucursal Crear(Guid idSucursal, string nombre, DateTime fechayHoraAlta)
        {
            return new Sucursal(idSucursal, nombre, fechayHoraAlta);
        }
    }
}