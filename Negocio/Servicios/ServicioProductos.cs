﻿using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Dominio.Repositorios;
using System.Data.SqlClient;
using System.Linq;
using Dominio.Dtos;

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


        public IEnumerable<Producto> ConsultarProductosBD()
        {

            var productos = new List<Producto>();
            try
            {
                _repositorioProductos.ConsultarProductos().ToList().
                ForEach(pro => productos.Add(Producto.Crear
                (pro.IdProducto, pro.Stock, pro.Nombre, pro.Descripcion, pro.Precio,
                pro.IdInventario, pro.IdProveedor)));
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
                var dtoProducto = new DtoProducto(nuevoProducto.IdProducto, nuevoProducto.Stock, nuevoProducto.Nombre,
                    nuevoProducto.Descripcion, nuevoProducto.Precio, nuevoProducto.IdInventario, nuevoProducto.IdProveedor);
                return _repositorioProductos.GuardarProducto(dtoProducto);
            }
            catch (Exception exception)
            {

                throw exception;
            }


        }

    }
}
