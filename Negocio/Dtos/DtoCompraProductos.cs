using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public class DtoCompraProductos
    {
        public Guid IdCompra { get; set; }
        public DtoProductoSeleccionado Productos {get; set;}
        public decimal Total { get; set; }
        public int TotalProductos { get; set; }
    }
}
