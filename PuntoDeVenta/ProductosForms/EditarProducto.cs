﻿using System;
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
    public partial class EditarProducto : Form
    {
        private static EditarProducto _instancia;

        public static EditarProducto Instancia { get
            {

                if (_instancia == null)
                    _instancia = new EditarProducto();
                return _instancia;

            } private set { } }


        private  EditarProducto()
        {
            InitializeComponent();
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirEditarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
