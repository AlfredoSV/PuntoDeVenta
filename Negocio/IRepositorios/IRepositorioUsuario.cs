using System;
using System.Collections.Generic;
using System.Text;
using Negocio.Entidades;

namespace Negocio.IRepositorios
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Producto> ConsultarProductos();
    }
}
