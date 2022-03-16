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

                for (int i = 1; i <= wsn.EndRowIndex; i++)
                {
                }

            }

            return listaElmen;

        }
    }
}
