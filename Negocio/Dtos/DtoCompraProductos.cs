using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public class DtoCompraProductos
    {
        public Guid IdCompra { get; private set; }
        public IEnumerable<DtoProductoSeleccionado> Productos {get; set;}
        public decimal Total { get; set; }
        public int TotalProductos { get; set; }

        public DtoCompraProductos()
        {
            Productos = new List<DtoProductoSeleccionado>();
        }
    }
}
