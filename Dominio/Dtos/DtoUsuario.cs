using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Dtos
{
    public class DtoUsuario
    {
        private Guid _idUsuario;
        private string _usuario;
        private string _contrasenia;
        private DateTime _fechayHoraAlta;
        private Guid _idSucursal;
        private Guid _idRol;

        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public DateTime FechayHoraAlta { get => _fechayHoraAlta; set => _fechayHoraAlta = value; }
        public Guid IdSucursal { get => _idSucursal; set => _idSucursal = value; }
        public Guid IdRol { get => _idRol; set => _idRol = value; }
    }
}
