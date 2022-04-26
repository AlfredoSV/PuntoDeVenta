using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Repositorios;
using System.Data.SqlClient;
using System.Linq;
using Aplicacion.Dtos;
using System.Threading.Tasks;
using Dominio;

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


        public async Task<DtoProductosPaginados> ConsultarProductosPaginadosBD(DtoPropiedadesPaginacion dtoBuscarProductos)
        {

            var productos = new List<DtoProducto>();
            DtoProductosPaginados dtoProductosPaginados;
            var totalProductos = 0;
            var totalPaginas = 0;

            try
            {
                var prodNoPag = await _repositorioProductos.ConsultarProductos(dtoBuscarProductos.BuscarFiltro);
                prodNoPag.ToList().ForEach(pro => productos.Add(new DtoProducto(pro.IdProducto, pro.Stock, pro.Nombre, pro.Descripcion, pro.Precio,pro.IdInventario,pro.IdProveedor)));
                totalProductos = _repositorioProductos.ConsultarProductosTotal(dtoBuscarProductos.BuscarFiltro);
                productos = productos.Skip<DtoProducto>(dtoBuscarProductos.Pagina * dtoBuscarProductos.TamanioPagina).Take<DtoProducto>(dtoBuscarProductos.TamanioPagina).ToList();
                totalPaginas = (int)Math.Ceiling((decimal)((decimal)totalProductos / (decimal)dtoBuscarProductos.TamanioPagina));
            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;

            }
            catch (Exception exception)
            {

                throw exception;

            }

            dtoProductosPaginados = new DtoProductosPaginados(productos, dtoBuscarProductos.Pagina, dtoBuscarProductos.TamanioPagina, totalProductos,totalPaginas);

            return dtoProductosPaginados;
        }

        public async Task<IEnumerable<DtoProducto>> ConsultarProductosParVenta(string buscar)
        {

            var dtoProductos = new List<DtoProducto>();
            var productos = new List<Producto>();

            try
            {
                productos = (await _repositorioProductos.ConsultarProductos(buscar)).ToList();
                productos.ToList().ForEach(pro => dtoProductos.Add(new DtoProducto(pro.IdProducto, pro.Stock, pro.Nombre, pro.Descripcion, pro.Precio, pro.IdInventario, pro.IdProveedor)));
            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;

            }
            catch (Exception exception)
            {

                throw exception;

            }

            
            return dtoProductos;
        }


        public void GuardarNuevoProducto(int stock, string nombre, string descripcion, decimal precio ,Guid idProveedor)
        {
            try
            {
                var nuevoProducto = Producto.CrearNuevoProducto(stock, nombre, descripcion, precio, idProveedor);

                _repositorioProductos.GuardarProducto(nuevoProducto);
            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;

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
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;

            }
            catch (Exception exception)
            {

                throw exception;

            }
        }

        public async Task<DtoProducto> ConsultarProductoPorId(Guid idProducto)
        {
            try
            {
                
                var producto = (await _repositorioProductos.ConsultarProductos(string.Empty)).Where(p => p.IdProducto == idProducto).FirstOrDefault();

                return (new DtoProducto(producto.IdProducto, producto.Stock, producto.Nombre, producto.Descripcion, producto.Precio, producto.IdInventario, producto.IdProveedor));

            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;

            }
            catch (Exception exception)
            {

                throw exception;

            }
        }

        public async void GuardarProductoEditado(DtoProducto dtoProducto)
        {
            try
            {

                await (_repositorioProductos.EditarProducto(Producto.Crear(dtoProducto.IdProducto, dtoProducto.Stock, dtoProducto.Nombre, dtoProducto.Descripcion, dtoProducto.Precio, dtoProducto.IdInventario, dtoProducto.IdProveedor)));

            }
            catch (ExcepcionComun excepcionComun)
            {

                throw excepcionComun;

            }
            catch (Exception exception)
            {

                throw exception;

            }

        }
    }
}
