using System;
using System.Collections.Generic;
using System.Text;
using Negocio.Entidades;
using AccesoDatos.Repositorios;
using System.Data.SqlClient;
using System.Linq;


namespace Negocio.Servicios
{
    public class ServicioProductos
    {
        private static ServicioProductos _instacia;
        private static RepositorioProductos _repositorioProductos;
        public static ServicioProductos Instacia
        {
            get
            {
                if (_instacia == null)
                    _instacia = new ServicioProductos();

                return _instacia;

            }
            set => _instacia = value;
        }


        private ServicioProductos() { }


        public IEnumerable<Producto> ConsultarProductosBD()
        {
            _repositorioProductos = RepositorioProductos.Instacia;
            _repositorioProductos.AgregarConexionBD("Server=DESKTOP-GUSKUDA;Database=PuntoVenta;Trusted_Connection=True;");

            var productos = new List<Producto>();

            _repositorioProductos.ConsultarProductos().ToList().
                ForEach(pro => productos.Add(Producto.Crear
                (pro.IdProducto, pro.Stock, pro.Nombre, pro.Descripcion, pro.Precio,
                pro.IdInventario, pro.IdProveedor)));

            return productos;
        }
    }
}
