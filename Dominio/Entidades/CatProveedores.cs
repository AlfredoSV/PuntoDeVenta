﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public  class CatProveedores
    {
        Guid _idProveedor;
        string _nombre;
        string _descripcion;
        DateTime _fechayHoraAlta;

        public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime FechayHoraAlta { get => _fechayHoraAlta; set => _fechayHoraAlta = value; }

        public CatProveedores(Guid idProveedor, string nombre, string descripcion, DateTime fechayHoraAlta)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Descripcion = descripcion;
            FechayHoraAlta = fechayHoraAlta;
        }

        public static CatProveedores Crear(Guid idProveedor, string nombre, string descripcion, DateTime fechayHoraAlt)
        {

            return new CatProveedores(idProveedor, nombre, descripcion, fechayHoraAlt);

        }
    }
}
