using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class PermisosModulo
    {
        private Guid _idAccionMod;
        private string _nombre;
        private string _descripcion;
        private Modulo _modulo;
        private Rol _rol;
        private DateTime _fechayHoraAlta;

        public Guid IdAccionMod { get => _idAccionMod; set => _idAccionMod = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public Rol Rol { get => _rol; set => _rol = value; }
        public DateTime FechayHoraAlta { get => _fechayHoraAlta; set => _fechayHoraAlta = value; }
        public Modulo Modulo { get => _modulo; set => _modulo = value; }
    }
}
