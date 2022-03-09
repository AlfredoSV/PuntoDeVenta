using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ClasesAuxiliares
{

    public class Item
    {
        public string Name { get; private set; }
        public Guid Value { get; private set; }
        public Item(string _name, Guid _value)
        {
            Name = _name; Value = _value;
        }
    }
}
