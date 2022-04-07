using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Dominio;
using Dominio.Entidades;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;

namespace Aplicacion.Servicios
{
    public class ServicioExcelProductos
    {
        private static ServicioExcelProductos _instancia;

        public static ServicioExcelProductos Instancia
        {
            get
            {

                if (_instancia == null)
                    _instancia = new ServicioExcelProductos();
                return _instancia;
            }
            set => _instancia = value;
        }

        public IEnumerable<Producto> LeerExcelProductos(MemoryStream archivo)
        {
            var listaElmen = new List<Producto>();
            var sp = new SLDocument(archivo);


            var wsn = sp.GetWorksheetStatistics();


            var resValidacionColumnas = ValidarColumnasFormato(ref sp);

            if (!resValidacionColumnas)
                throw new ExcepcionComun("Aplicación", "El documento no tiene el formato correcto", "LeerExcelProductos");

            if ((wsn.EndColumnIndex > 4))
            {
                for (int i = 2; i < wsn.NumberOfRows; i++)
                {


                    var producto = Producto.CrearNuevoProducto(Int32.Parse(sp.GetCellValueAsString(i, 1)),
                        sp.GetCellValueAsString(i, 2), sp.GetCellValueAsString(i, 3), decimal.Parse(sp.GetCellValueAsString(i, 4)),
                        Guid.Parse(sp.GetCellValueAsString(i, 5)));
                    listaElmen.Add(producto);
                }

            }

            return listaElmen;

        }

        public bool ValidarColumnasFormato(ref SLDocument sLDocument)
        {
            var sLWorksheetStatistics = sLDocument.GetWorksheetStatistics();
            var listaColumnas = new List<string>() { "Stock", "Nombre", "Descripcion", "Precio", "Inventario", "Proveedor" };

            if (sLWorksheetStatistics.NumberOfColumns != 7)
                return false;

            for (int i = 1; i <= 7; i++)
            {
                var columna = sLDocument.GetCellValueAsString(1, i);
                if (!listaColumnas.Contains(columna))
                    return false;
            }



            return true;
        }
    }
}
