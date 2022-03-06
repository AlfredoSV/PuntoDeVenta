using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Entidades
{
    public class Producto
    {
        private Guid _idProducto;
        private int _stock;
        private string _nombre;
        private string _descripcion;
        private decimal _precio;
        private Guid _idInventario;
        private Guid _idProveedor;

        public Guid IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public Guid IdInventario { get => _idInventario; set => _idInventario = value; }
        public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }

        public Producto(Guid idProducto, int stock, string nombre, string descripcion, decimal precio, Guid idInventario, Guid idProveedor)
        {
            IdProducto = idProducto;
            Stock = stock;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            IdInventario = idInventario;
            IdProveedor = idProveedor;
        }

        public static Producto Crear(Guid idProducto, int stock, string nombre, string descripcion, decimal precio, Guid idInventario, Guid idProveedor)
        {
            return new Producto(idProducto, stock, nombre, descripcion, precio, idInventario, idProveedor);
        }
        public static Producto CrearNuevoProducto(int stock, string nombre, string descripcion, decimal precio, Guid idInventario, Guid idProveedor)
        {
            return new Producto(Guid.NewGuid(), stock, nombre, descripcion, precio, idInventario, idProveedor);
        }
    }
}
