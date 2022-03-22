using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Repositorios;
using System.Data.SqlClient;
using System.Linq;
using Aplicacion.Dtos;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class ServicioProductos
    {
        private static ServicioProductos _instacia;
        private readonly  RepositorioProductos _repositorioProductos;

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


        public async Task<DtoProductosPaginados> ConsultarProductosPaginadosBD(DtoBuscarProductosPaginados dtoBuscarProductos)
        {

            var productos = new List<DtoProducto>();
            DtoProductosPaginados dtoProductosPaginados;
            var totalProductos = 0;
            var totalPaginas = 0;

            try
            {
                var prodNoPag = await _repositorioProductos.ConsultarProductos(dtoBuscarProductos.BuscarFiltro);
                prodNoPag.ToList().ForEach(pro => productos.Add(new DtoProducto(pro.IdProducto, pro.Stock, pro.Nombre, pro.Descripcion, pro.Precio)));
                totalProductos = _repositorioProductos.ConsultarProductosTotal(dtoBuscarProductos.BuscarFiltro);
                productos = productos.Skip<DtoProducto>(dtoBuscarProductos.Pagina * dtoBuscarProductos.TamanioPagina).Take<DtoProducto>(dtoBuscarProductos.TamanioPagina).ToList();
                totalPaginas = (int)Math.Ceiling((decimal)((decimal)totalProductos / (decimal)dtoBuscarProductos.TamanioPagina));
            }
            catch (Exception exception)
            {

                throw exception;
            }

            dtoProductosPaginados = new DtoProductosPaginados(productos, dtoBuscarProductos.Pagina, dtoBuscarProductos.TamanioPagina, totalProductos,totalPaginas);

            return dtoProductosPaginados;
        }

        public void GuardarNuevoProducto(int stock, string nombre, string descripcion, decimal precio ,Guid idProveedor)
        {
            try
            {
                var nuevoProducto = Producto.CrearNuevoProducto(stock, nombre, descripcion, precio, idProveedor);

                _repositorioProductos.GuardarProducto(nuevoProducto);
            }
            catch (Exception exception)
            {

                throw exception;
            }


        }

        public async void EliminarProductoPorId(Guid id)
        {
            try
            {
              
                await _repositorioProductos.EliminarProductoPorId(id);
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }

        public async Task<DtoProducto> ConsultarProductoPorId(Guid idProducto)
        {
            var producto = (await _repositorioProductos.ConsultarProductos(string.Empty)).Where(p=> p.IdProducto == idProducto).FirstOrDefault();

            return (new DtoProducto(producto.IdProducto,producto.Stock,producto.Nombre,producto.Descripcion,producto.Precio,producto.IdProveedor));
        }

    }
}
