using System;

namespace Negocio.Entidades
{
    public class Rol
    {
        private Guid _idRol;
        private string _nombre;
        private string _descripcion;
        private DateTime _fechayHoraAlta;

        public Guid IdRol { get => _idRol; set => _idRol = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime FechayHoraAlta { get => _fechayHoraAlta; set => _fechayHoraAlta = value; }

        public Rol(Guid idRol, string nombre, string descripcion, DateTime fechayHoraAlta)
        {
            IdRol = idRol;
            Nombre = nombre;
            Descripcion = descripcion;
            FechayHoraAlta = fechayHoraAlta;
        }

        public static Rol CrearRol(Guid idRol, string nombre, string descripcion, DateTime fechayHoraAlta)
        {
            return new Rol(idRol, nombre, descripcion, fechayHoraAlta);
        }
    }
}