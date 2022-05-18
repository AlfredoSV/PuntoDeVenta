using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public class DtoProductoSeleccionado
    {
        public Guid IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }

        public DtoProductoSeleccionado()
        { }
    }
}
