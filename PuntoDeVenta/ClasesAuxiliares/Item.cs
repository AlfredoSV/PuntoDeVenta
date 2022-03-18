using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    public class CargarCombo
    {
        private void CargarComboItems(IEnumerable<object> datos, string mensajeDefault, ComboBox comboOb,string campoNombre, string campoId)
        {
            var items = new List<Item>();

            items.Add(new Item($"--- {mensajeDefault}. ---", Guid.Empty));

            Type t = datos.FirstOrDefault().GetType();

            PropertyInfo[] propiedades = t.GetProperties();

            foreach (var get in propiedades)
            {
                items.Add(new Item( get.GetValue(datos).ToString(), Guid.Parse(get.GetValue(datos).ToString())));
            }

            comboOb.DisplayMember = "Name";
            comboOb.ValueMember = "Value";
            comboOb.DataSource = items;
        }
    }
}
