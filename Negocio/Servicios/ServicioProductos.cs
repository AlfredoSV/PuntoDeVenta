using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Repositorios;
using System.Data.SqlClient;
using System.Linq;
using Aplicacion.Dtos;

namespace Aplicacion.Servicios
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


        private ServicioProductos()
        {
            _repositorioProductos = RepositorioProductos.Instacia;
            _repositorioProductos.AgregarConexionBD(ConexionString.StrConexionBdSql.DefaultConexionSqlServer);

        }


        public IEnumerable<DtoProducto> ConsultarProductosBD()
        {

            var productos = new List<DtoProducto>();
            try
            {
                _repositorioProductos.ConsultarProductos().ToList().
                ForEach(pro => productos.Add(new DtoProducto(pro.IdProducto, pro.Stock, pro.Nombre, pro.Descripcion, pro.Precio)));
            }
            catch (Exception exception)
            {

                throw exception;
            }


            return productos;
        }

        public bool GuardarNuevoProducto(int stock, string nombre, string descripcion, decimal precio, Guid idInventario, Guid idProveedor)
        {
            try
            {
                var nuevoProducto = Producto.CrearNuevoProducto(stock, nombre, descripcion, precio, idInventario, idProveedor);

                return _repositorioProductos.GuardarProducto(nuevoProducto);
            }
            catch (Exception exception)
            {

                throw exception;
            }


        }

    }
}
