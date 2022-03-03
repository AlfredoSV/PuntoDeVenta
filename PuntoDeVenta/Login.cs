﻿
using Dominio.Dtos;
using Aplicacion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Login : Form
    {
        private readonly ServicioAutenticacion _servicioAutenticacion;
        public Login()
        {
            _servicioAutenticacion = ServicioAutenticacion.Instacia;
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {

            var usuario = txtUsuario.Text.Trim();
            var contrasenia = txtContrasenia.Text.Trim();
            var inicioForm = new Inicio();
            var dtoUsuario = new DtoUsuario();

            if (!usuario.Equals("") && !contrasenia.Equals(""))
            {
                dtoUsuario.Contrasenia = contrasenia;
                dtoUsuario.Usuario = usuario;

                if (_servicioAutenticacion.ValidarUsuario(dtoUsuario))
                {
                    this.Hide();
                    inicioForm.Show();
                }

            }
            else
            {
                MessageBox.Show("Favor de ingresar usuario y/o contraseña", "Error");
            }



        }


        public void CerrarSesion()
        {
            this.Show();
            txtContrasenia.Text = "";
            txtUsuario.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
