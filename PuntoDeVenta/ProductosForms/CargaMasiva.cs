using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.ProductosForms
{
    public partial class CargaMasiva : Form
    {
        private static CargaMasiva _instancia;

        public static CargaMasiva Instancia
        {
            get
            {

                if (_instancia == null)
                    _instancia = new CargaMasiva();
                return _instancia;

            }
            private set { }
        }


        private CargaMasiva()
        {
            InitializeComponent();
        }

        private void btnSalirCargaMasiva_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
