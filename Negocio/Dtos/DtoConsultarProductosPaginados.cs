using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public class DtoBuscarProductosPaginados
    {

        private int _pagina;
        private int _tamanioPagina;
        private string _buscarFiltro;

        public int Pagina { get => _pagina; set => _pagina = value; }
        public int TamanioPagina { get => _tamanioPagina; set => _tamanioPagina = value; }
        public string BuscarFiltro { get => _buscarFiltro; set => _buscarFiltro = value; }

        public DtoBuscarProductosPaginados(int pagina, int tamanioPagina, string buscarFiltro)
        {
            Pagina = pagina;
            TamanioPagina = tamanioPagina;
            BuscarFiltro = buscarFiltro;
        }


    }
}
