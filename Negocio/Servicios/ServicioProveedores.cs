using Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Repositorios;
using Dominio.Entidades;

namespace Aplicacion.Servicios
{
    public class ServicioProveedores
    {
        private static ServicioProveedores _instancia;
        private readonly RepositorioProveedores _repositorioProveedores;

        public ServicioProveedores()
        {
            _repositorioProveedores = RepositorioProveedores.Instancia;
        }

        public static ServicioProveedores Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ServicioProveedores();

                return _instancia;
            }
            set => _instancia = value;
        }

        
        public DtoProveedor ConsultarProveedoresPaginados()
        {

            return null;
        }

        public void EliminarProveedorPorId(Guid idProveedor)
        {
            _repositorioProveedores.EliminarProveedorePorId(idProveedor);
        }

        public DtoProveedor DetalleProveedore(Guid idProveedor)
        {
            var proveedor = _repositorioProveedores.ConsultarDetalleProveedor(idProveedor);

            return new DtoProveedor(proveedor.IdProveedor, proveedor.Nombre, proveedor.Descripcion, proveedor.FechayHoraAlta);
        }

        public void EditarProveedor(DtoProveedor dtoProveedor)
        {
            var proveedor = Proveedor.Crear(dtoProveedor.IdProveedor,dtoProveedor.Nombre,dtoProveedor.Descripcion,dtoProveedor.FechayHoraAlta);
            
            _repositorioProveedores.EditarProveedor(proveedor);
        }

    }
}
