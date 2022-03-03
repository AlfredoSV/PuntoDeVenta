using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Modulo
    {
        private Guid _idModulo;
        private string _nombre;
        private string _descripcion;
        private DateTime fechayHoraAlta;

        public Guid IdModulo { get => _idModulo; set => _idModulo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime FechayHoraAlta { get => fechayHoraAlta; set => fechayHoraAlta = value; }



    }
}
