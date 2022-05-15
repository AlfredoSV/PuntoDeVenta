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

        public static void CargarComboItems(IEnumerable<object> datos, string mensajeDefault, ref ComboBox comboOb, string campoId, string campoNombre = "Nombre")
        {
            var items = new List<Item>();

            Type t = datos.FirstOrDefault().GetType();

            PropertyInfo[] propiedades = t.GetProperties();
            int i = 1;

            items.Add(new Item($"--- {mensajeDefault}. ---", Guid.Empty));           

            foreach (var get in propiedades)
            {
                Item it = null;

                foreach (var data in datos)
                {
                    if (get.Name == campoId)
                    {
                        it = new Item("", Guid.Parse(get.GetValue(data).ToString()));
                        items.Add(it);
                    }                       
                    else if (get.Name == campoNombre)
                    {
                        items[i].Name = get.GetValue(data).ToString();
                        i++;
                    }
                        

                    
                }
                                 
                
            }

            comboOb.DisplayMember = "Name";
            comboOb.ValueMember = "Value";
            comboOb.DataSource = items;
        }

    }

   
}
