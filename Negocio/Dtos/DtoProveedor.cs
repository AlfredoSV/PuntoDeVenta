using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public class DtoProveedor
    {
        Guid _idProveedor;
        string _nombre;
        string _descripcion;
        DateTime _fechayHoraAlta;

        public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime FechayHoraAlta { get => _fechayHoraAlta; set => _fechayHoraAlta = value; }

        public DtoProveedor(Guid idProveedor, string nombre, string descripcion, DateTime fechayHoraAlta)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Descripcion = descripcion;
            FechayHoraAlta = fechayHoraAlta;
        }
    }
}
