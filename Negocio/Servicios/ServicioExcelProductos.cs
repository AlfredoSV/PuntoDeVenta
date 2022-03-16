using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Dominio.Entidades;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;

namespace Aplicacion.Servicios
{
    public class ServicioExcelProductos
    {
        public IEnumerable<Producto> LeerExcel(MemoryStream archivo)
        {
            var listaElmen = new List<Producto>();
            using (var sp = new SLDocument(archivo))
            {
                var wsn = sp.GetWorksheetStatistics();

                if ((wsn.EndColumnIndex > 4))
                {
                    for (int i = 2; i < 3; i++)
                    {

                        var producto = Producto.CrearNuevoProducto(Int32.Parse(sp.GetCellValueAsString(i, 1)),
                            sp.GetCellValueAsString(i, 2), sp.GetCellValueAsString(i, 3),decimal.Parse(sp.GetCellValueAsString(i, 4)),
                            Guid.Parse(sp.GetCellValueAsString(i, 5)));
                        listaElmen.Add(producto);
                    }

                }
                



            }

            return listaElmen;

        }
    }
}
