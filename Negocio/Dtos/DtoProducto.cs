using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public class DtoProducto
    {

        private Guid _idProducto;
        private int _stock;
        private string _nombre;
        private string _descripcion;
        private decimal _precio;
        private Guid _idProveedor;
        private Guid _idInventario;

        public Guid IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public Guid IdInventario { get => _idInventario; set => _idInventario = value; }

        public DtoProducto(Guid idProducto, int stock, string nombre, string descripcion, decimal precio)
        {
            IdProducto = idProducto;
            Stock = stock;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    

        public DtoProducto(Guid idProducto, int stock, string nombre, string descripcion, decimal precio,Guid idInventario,Guid idProveedor)
        {
            IdProducto = idProducto;
            Stock = stock;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            IdProveedor = idProveedor;
            _idInventario = idInventario;
        }
    }
}
