using Aplicacion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {

            try
            {
                var openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (openFile.SafeFileName.Split('.')[1].Equals("xlsx"))
                    {
                        using (var memory = new MemoryStream())
                        {
                            using (var fileStream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read))
                            {
                                fileStream.CopyTo(memory);
                                var carga = new ServicioExcelProductos();
                                var res = carga.LeerExcel(memory);
                                dataGridViewProductosCargados.DataSource = res;
                            }
                        }

                       
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarCarga_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Esta seguro de cargar los siguientes productos?", "Alterta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(DialogResult.OK == resultado)
            {

            }
        }
    }
}
