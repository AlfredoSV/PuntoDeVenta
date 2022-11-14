using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.ClasesAuxiliares
{

    public class Item
    {
        public string Name { get; set; }
        public Guid Value { get; set; }
        public int ValueInt { get; set; }
        public Item(string _name, Guid _value)
        {
            Name = _name; Value = _value;
        }
        public Item(string _name, int _value)
        {
            Name = _name; ValueInt = _value;
        }


    }

    public static class ItemComboBox{
        public static void CargarComboItems(this ComboBox comboOb, IEnumerable<object> datos, string mensajeDefault,
            string campoId, string campoNombre = "Nombre")
        {
            var items = new List<Item>();

            Type t = datos.FirstOrDefault().GetType();

            PropertyInfo[] propiedades = t.GetProperties();
            int i = 1;

            items.Add(new Item($"--- {mensajeDefault}. ---", Guid.Empty));

            foreach (var prop in propiedades)
            {
                Item it = null;

                datos.ToList().ForEach((object dato)=>
                {
                    if (prop.Name == campoId)
                    {
                        it = new Item("", Guid.Parse(prop.GetValue(dato).ToString()));
                        items.Add(it);
                    }
                    else if (prop.Name == campoNombre)
                    {
                        items[i].Name = prop.GetValue(dato).ToString();
                        i++;
                    }
                });

            }
            comboOb.DisplayMember = "Name";
            comboOb.ValueMember = "Value";
            comboOb.DataSource = items;
        }
    }


}
