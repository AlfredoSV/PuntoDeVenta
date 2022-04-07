using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.UsuariosForms
{
    public partial class EditarUsuarioFrm : Form
    {
        private static EditarUsuarioFrm _instancia;
        private Guid _idUsuario;

        public static EditarUsuarioFrm Instancia
        {
            get
            {

                if (_instancia == null)
                    _instancia = new EditarUsuarioFrm();

                return _instancia;
            }
            set => _instancia = value;
        }

       
        public EditarUsuarioFrm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Guid idUsuario)
        {
            _idUsuario = idUsuario;
            this.ShowDialog();
        }

        private void btnSalirEditarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
