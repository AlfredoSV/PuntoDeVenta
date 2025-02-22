﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacion.Dtos;
using Aplicacion.Servicios;
using Dominio.Entidades;
using PuntoDeVenta.ClasesAuxiliares;
using System.Linq;
using System.Text.RegularExpressions;
using System.Data;

namespace PuntoDeVenta.ProductosForms
{
    public partial class Productos : Form
    {
        private readonly ServicioProductos _servicioProductos;
        private readonly ServicioCatalogos _servicioCatalogos;
        private Usuario _usuarioLogueado;

        private const int PAGINA_POR_DEFECTO = 0;
        private const int TAMANIO_PAGINA_POR_DEFECTO = 10;
        private const string BUSCAR_FILTRO_POR_DEFECTO = "";

        public Productos()
        {
            _servicioProductos = ServicioProductos.Instacia;
            _servicioCatalogos = ServicioCatalogos.Instacia;
            InitializeComponent();

        }

        private async void Productos_Load(object sender, EventArgs e)
        {

            try
            {
                var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
                var productos = await _servicioProductos.ConsultarProductosPaginados(dtoPropiedadesPaginacion);
                LimpiarGrid();
                AgregarBotonesGrid();
                CargarProveedores(await _servicioCatalogos.ConsultarProveedoresBD());
                productos.Pagina += 1;
                ListarProductosGrid(productos);

            }
            catch (Exception exception)
            {
                MessageBox.Show("Sucedió un error no controlado, favor de contactar con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private async void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var columna = e.ColumnIndex.ToString();

           
            try
            {
                if (columna.Equals("0") || columna.Equals("1"))
                {
                    var idProducto = Guid.Parse(dataGridViewProductos.Rows[e.RowIndex].Cells[2].Value.ToString());

                    switch (columna)
                    {
                        case "0":
                            _servicioProductos.EliminarProductoPorId(idProducto);
                            break;
                        case "1":
                            var editarProductoForm = EditarProducto.Instancia;
                            editarProductoForm.ShowDialog(idProducto);
                            break;

                    }

                    var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
                    var productos = await _servicioProductos.ConsultarProductosPaginados(dtoPropiedadesPaginacion);
                    LimpiarGrid();
                    AgregarBotonesGrid();
                    CargarProveedores(await _servicioCatalogos.ConsultarProveedoresBD());
                    productos.Pagina += 1;
                    ListarProductosGrid(productos);

                }


            }
            catch (Exception exception)
            {
                MessageBox.Show("Sucedió un error no controlado, favor de contactar con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            var stock = (int)(txtStockProducto.Value);
            var nombre = txtNombreProducto.Text.Trim();
            var preciotxtEsCorrecto = Regex.IsMatch(txtPrecioProducto.Text, @"^(?:\d+\.?\d*)?$");
            Decimal precio;
            var descripcion = txtDescripcionProducto.Text.Trim();
            var proveedor = ((Item)(comboProveedorProducto.SelectedItem)).Value;

            var validacion = true;
            var mensajeValidacion = string.Empty;

            if (stock <= 0)
            {
                mensajeValidacion+= "* Debe agregar por lo menos un producto al stock \n";
                validacion = false;
            }
            if (nombre.Equals(""))
            {
                mensajeValidacion += "* El productos debe terner un nombre \n";
                validacion = false;
            }
            if (!preciotxtEsCorrecto)
            {

                mensajeValidacion += "* El precio debe ser mayor a 0 \n";
                validacion = false;
            }

            if (proveedor == Guid.Empty)
            {
                mensajeValidacion += "* Debe seleccionar un proveedor \n";
                validacion = false;
            }

            if (validacion)
            {
                precio = Convert.ToDecimal(txtPrecioProducto.Text);
                try
                {
                    _servicioProductos.GuardarNuevoProducto(stock, nombre, descripcion, precio, proveedor);
                    var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
                    var productos = await _servicioProductos.ConsultarProductosPaginados(dtoPropiedadesPaginacion);
                    LimpiarGrid();
                    AgregarBotonesGrid();
                    productos.Pagina += 1;
                    ListarProductosGrid(productos);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Sucedió un error no controlado, favor de contactar con el administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(mensajeValidacion, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }





        }

        public void Show(Usuario usuario)
        {
            _usuarioLogueado = usuario;
            //ActivarODesactivarFormularioAltaProdcuto(_usuarioLogueado.Permisos.Any(x => x.PermisoModulo == "Alta" && x.Modulo == "Productos"));
            base.Show();
        }

        private void btnLimpiarFormProducto_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtDescripcionProducto.Text = "";
            txtStockProducto.Value = 0;

        }

        private async void btnRecargarProductos_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, BUSCAR_FILTRO_POR_DEFECTO);
            var productos = await _servicioProductos.ConsultarProductosPaginados(dtoPropiedadesPaginacion);
            LimpiarGrid();
            AgregarBotonesGrid();
            productos.Pagina += 1;
            ListarProductosGrid(productos);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var txtFiltro = txtBuscar.Text.Trim();
            var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(PAGINA_POR_DEFECTO, TAMANIO_PAGINA_POR_DEFECTO, txtFiltro);
            var productos = await _servicioProductos.ConsultarProductosPaginados(dtoPropiedadesPaginacion);
            LimpiarGrid();
            AgregarBotonesGrid();
            productos.Pagina += 1;
            ListarProductosGrid(productos);



        }

        private async void btnRegresarPag_Click(object sender, EventArgs e)
        {

            var pagina = Int32.Parse(txtPagActual.Text);
            var buscarFiltro = txtBuscar.Text.Trim();
            if (txtPagActual.Text == txtPaginasTotalesProductos.Text)
                pagina -= 2;
            else
                pagina -= 1;
            var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(pagina, TAMANIO_PAGINA_POR_DEFECTO, buscarFiltro);
            var productos = await _servicioProductos.ConsultarProductosPaginados(dtoPropiedadesPaginacion);
            LimpiarGrid();
            AgregarBotonesGrid();
            productos.Pagina = Int32.Parse(txtPagActual.Text) - 1;
            ListarProductosGrid(productos);

        }

        private async void btnAvanzarPag_Click(object sender, EventArgs e)
        {
            var pagina = Int32.Parse(txtPagActual.Text);
            var buscarFiltro = txtBuscar.Text.Trim();
            var dtoPropiedadesPaginacion = new DtoPropiedadesPaginacion(pagina, TAMANIO_PAGINA_POR_DEFECTO, buscarFiltro);
            var productos = await _servicioProductos.ConsultarProductosPaginados(dtoPropiedadesPaginacion);
            LimpiarGrid();
            AgregarBotonesGrid();
            productos.Pagina += 1;
            ListarProductosGrid(productos);

        }

        private void btnCargarMasivaProducto_Click(object sender, EventArgs e)
        {
            var cargaMasicaForm = CargaMasiva.Instancia;
            cargaMasicaForm.ShowDialog();
        }




        #region Lógica presentación reútilizable
        private void AgregarBotonesGrid()
        {
            DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
            dataGridViewProductos.Columns.Add(btnBorrar);
            btnBorrar.Text = "Borrar";
            btnBorrar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            dataGridViewProductos.Columns.Add(btnEditar);
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;

        }
        private void LimpiarGrid()
        {
            dataGridViewProductos.Columns.Clear();
            dataGridViewProductos.DataSource = null;
            
        }
        private void CargarProveedores(IEnumerable<Proveedor> provedores)
        {
            var items = new List<Item>();

            items.Add(new Item("--- Seleciona un proveedor. ---", Guid.Empty));
            foreach (var get in provedores)
            {
                items.Add(new Item(get.Nombre, get.IdProveedor));
            }

            comboProveedorProducto.DisplayMember = "Name";
            comboProveedorProducto.ValueMember = "Value";
            comboProveedorProducto.DataSource = items;
        }
        private void ListarProductosGrid(DtoProductosPaginados dtoProductosPaginados)
        {
            try
            {

                var dataTableProductos = new DataTable();
                DataRow dtrowProducto;

                dataTableProductos.Columns.Add("Id", typeof(Guid));
                dataTableProductos.Columns.Add("Nombre", typeof(string));
                dataTableProductos.Columns.Add("Stock", typeof(int));
                dataTableProductos.Columns.Add("Descripción", typeof(string));
                dataTableProductos.Columns.Add("Precio", typeof(double));

                foreach (var prod in dtoProductosPaginados.Productos)
                {
                    dtrowProducto = dataTableProductos.NewRow();

                    dtrowProducto["Id"] = prod.IdProducto;
                    dtrowProducto["Nombre"] = prod.Nombre;
                    dtrowProducto["Stock"] = prod.Stock;
                    dtrowProducto["Descripción"] = prod.Descripcion;
                    dtrowProducto["Precio"] = prod.Precio;

                    dataTableProductos.Rows.Add(dtrowProducto);

                }

                dataGridViewProductos.DataSource = dataTableProductos;

                txtPagActual.Text = dtoProductosPaginados.Pagina.ToString();
                txtPaginasTotalesProductos.Text = dtoProductosPaginados.TotalPaginas.ToString();

                btnAvanzarPag.Enabled = true;
                btnRegresarPag.Enabled = true;

                if (txtPagActual.Text.Equals(dtoProductosPaginados.TotalPaginas.ToString()) && !txtPagActual.Text.Equals("1"))
                {
                    btnAvanzarPag.Enabled = false;
                }
                if (txtPagActual.Text.Equals("1") && dtoProductosPaginados.TotalPaginas == 1)
                {

                    btnAvanzarPag.Enabled = false;

                }
                if (txtPagActual.Text.Equals("1"))
                {
                    btnRegresarPag.Enabled = false;
                }
                if (dtoProductosPaginados.TotalPaginas.ToString().Equals("0"))
                {

                    btnAvanzarPag.Enabled = false;
                    btnRegresarPag.Enabled = false;
                }

            }
            catch (Exception exception)
            {

                throw exception;
            }
        }

        private void ActivarODesactivarFormularioAltaProdcuto(bool activo)
        {
            btnGuardarProducto.Enabled = activo;
            btnCargarMasivaProducto.Enabled = activo;
            btnLimpiarFormProducto.Enabled = activo;
            txtDescripcionProducto.Enabled = activo;
            comboProveedorProducto.Enabled = activo;
            txtNombreProducto.Enabled = activo;
            txtPrecioProducto.Enabled = activo;
            txtStockProducto.Enabled = activo;
            lblAviso.Visible = !activo;
        }


        #endregion Lógica presentación reútilizable

       
    }

}
