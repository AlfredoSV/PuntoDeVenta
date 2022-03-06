using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public class DtoProductosPaginados
    {
        private IEnumerable<DtoProducto> _productos;
        private int _pagina;
        private int _tamanioPagina;
        private int _totalProductos;

        public IEnumerable<DtoProducto> Productos { get => _productos; set => _productos = value; }
        public int Pagina { get => _pagina; set => _pagina = value; }
        public int TamanioPagina { get => _tamanioPagina; set => _tamanioPagina = value; }
        public int TotalProductos { get => _totalProductos; set => _totalProductos = value; }

        public DtoProductosPaginados(IEnumerable<DtoProducto> productos, int pagina, int tamanioPagina, int totalProductos)
        {
            Productos = productos;
            Pagina = pagina;
            TamanioPagina = tamanioPagina;
            TotalProductos = totalProductos;
        }
    }
}
