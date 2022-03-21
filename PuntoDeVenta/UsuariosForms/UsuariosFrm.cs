﻿using Aplicacion.Enums;
using Aplicacion.Servicios;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta.ClasesAuxiliares;


namespace PuntoDeVenta.UsuariosForms
{
    public partial class UsuariosFrm : Form
    {
        private Usuario _usuarioLogueado;
        private ServicioUsuarios _servicioUsuarios;

        public UsuariosFrm()
        {
            _servicioUsuarios = ServicioUsuarios.Instancia;
            InitializeComponent();
        }

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;
            base.Show();
        }

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            var inicioFrm = new Inicio();
            inicioFrm.Show(_usuarioLogueado);
            this.Dispose();
            this.Close();
        }

        private async void UsuariosFrm_Load(object sender, EventArgs e)
        {
            AgregarBotonesGrid();
            CargarEstatus();
            dataGridViewUsuarios.DataSource = (await _servicioUsuarios.ConsultarUsuariosPaginados((int)EstatusUsuarioBusqueda.Todos)).ToList();
        }

        private void AgregarBotonesGrid()
        {
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            dataGridViewUsuarios.Columns.Add(btnBorrar);
            btnBorrar.Text = "Borrar";
            btnBorrar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            dataGridViewUsuarios.Columns.Add(btnEditar);
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;

        }
        private void LimpiarGrid()
        {
            dataGridViewUsuarios.Columns.Clear();
            dataGridViewUsuarios.DataSource = null;

        }

        private void btnRecargarUsuarios_Click(object sender, EventArgs e)
        {
            LimpiarGrid();
            AgregarBotonesGrid();

        }

        private void CargarEstatus()
        {
            var items = new List<Item>();

            
            items.Add(new Item("Todos", -1));
            items.Add(new Item("Inactivos", 0));
            items.Add(new Item("Activos", 1));

            comboEstatusBusqueda.DisplayMember = "Name";
            comboEstatusBusqueda.ValueMember = "Value";
            comboEstatusBusqueda.DataSource = items;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var comEstatus = ((Item)(comboEstatusBusqueda.SelectedItem)).ValueInt;

            dataGridViewUsuarios.DataSource = (await _servicioUsuarios.ConsultarUsuariosPaginados((int)comEstatus)).ToList();


        }
    }
}
