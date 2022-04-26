using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public class UsuariosPaginados
    {
        private IEnumerable<DtoUsuario> _usuarios;
        private int _pagina;
        private int _tamanioPagina;
        private int _totalUsuarios;
        private int _totalPaginas;

        public IEnumerable<DtoUsuario> Usuarios { get => _usuarios; set => _usuarios = value; }
        public int Pagina { get => _pagina; set => _pagina = value; }
        public int TamanioPagina { get => _tamanioPagina; set => _tamanioPagina = value; }
        public int TotalUsuarios { get => _totalUsuarios; set => _totalUsuarios = value; }
        public int TotalPaginas { get => _totalPaginas; set => _totalPaginas = value; }

        public UsuariosPaginados(IEnumerable<DtoUsuario> usuarios, int pagina, int tamanioPagina, int totalUsuarios, int totalPaginas)
        {
            Usuarios = usuarios;
            Pagina = pagina;
            TamanioPagina = tamanioPagina;
            TotalUsuarios = totalUsuarios;
            TotalPaginas = totalPaginas;
        }

        public void InicializarPagina(int pag = 1)
        {
            _pagina += pag;
        }

        public void RegresarPagina(int pag)
        {
            _pagina = pag -1;
        }
    }
}
