using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ExcepcionComun : Exception
    {
        private string _detalle;
        private string _capa;
        private string _metodo;

        public string Detalle { get => _detalle;}
        public string Capa { get => _capa; }
        public string Metodo { get => _metodo; }

        public ExcepcionComun(string capa,string detalle,string metodo) : base(detalle)
        {
            _capa = capa;
            _detalle = detalle;
            _metodo = metodo;

        }
    }
}
