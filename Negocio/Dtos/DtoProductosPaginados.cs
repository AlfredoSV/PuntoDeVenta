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
        private int _totalPaginas;

        public IEnumerable<DtoProducto> Productos { get => _productos; set => _productos = value; }
        public int Pagina { get => _pagina; set => _pagina = value; }
        public int TamanioPagina { get => _tamanioPagina; set => _tamanioPagina = value; }
        public int TotalProductos { get => _totalProductos; set => _totalProductos = value; }
        public int TotalPaginas { get => _totalPaginas; set => _totalPaginas = value; }

        public DtoProductosPaginados(IEnumerable<DtoProducto> productos, int pagina, int tamanioPagina, int totalProductos, int totalPaginas)
        {
            Productos = productos;
            Pagina = pagina;
            TamanioPagina = tamanioPagina;
            TotalProductos = totalProductos;
            TotalPaginas = totalPaginas;
        }
    }
}
