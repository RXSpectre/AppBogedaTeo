using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppBogedaTeo.Vistas
{
    public partial class frmMantProductos : Form
    {

        private static frmMantProductos _instance = null;

        private ParametroRepositorio repoParametro;
        private ProductoRepositorio<ProductosDTO> repoProducto;
        private BindingSource bsProducto;

        //Bs y list para mantenimiento
        private BindingSource bsComboMCateProducto;
        private BindingSource bsComboMProveedores;
        private List<Parametro> listMCategoriasProductos;
        private List<Parametro> listMProveedores;

        //BS y list para Busquedas
        private BindingSource bsComboBCateProducto;
        private BindingSource bsComboBProveedores;
        private List<Parametro> listBCategoriasProductos;
        private List<Parametro> listBProveedores;

        private ProductosBusDTO productoFiltro;

        private int codProductoSel = 0;

        private frmMantProductos(Form form, string cadenaConexion)
        {
            InitializeComponent();

            bsProducto = new BindingSource();
            bsComboMCateProducto = new BindingSource();
            bsComboMProveedores = new BindingSource();
            listMCategoriasProductos = new List<Parametro>();
            listMProveedores = new List<Parametro>();

            bsComboBCateProducto = new BindingSource();
            bsComboBProveedores = new BindingSource();
            listBCategoriasProductos = new List<Parametro>();
            listBProveedores = new List<Parametro>();

            productoFiltro = new ProductosBusDTO();


            repoParametro = new ParametroRepositorio(cadenaConexion);
            repoProducto = new ProductoRepositorio<ProductosDTO>(cadenaConexion);
            ValidacionesEventos();
        }



        private void ValidacionesEventos()
        {
            txtMantPrecioCompra.KeyPress += ValidacionesDeEventos.txtSoloDecimales_KeyPress;
            txtMantPrecioVenta.KeyPress += ValidacionesDeEventos.txtSoloDecimales_KeyPress;
            txtMantPrecioCompra.Leave += ValidacionesDeEventos.txtSoloDecimales_Leave;
            txtMantPrecioVenta.Leave += ValidacionesDeEventos.txtSoloDecimales_Leave;

            txtMantLimiteStock.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtMantStock.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
        }


        public static frmMantProductos GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmMantProductos(form, cadenaConexion);

                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
                _instance.BringToFront();

            _instance.PanelPrincipal();

            return _instance;
        }

        private void PanelPrincipal()
        {
            panelBusCliente.Visible = true;
            panelBusCliente.Dock = DockStyle.Fill;
            panelMantCliente.Visible = false;
            LimpiarCampos();
        }

        private void PanelMant()
        {
            panelMantCliente.Visible = false;
            panelMantCliente.Visible = true;
            //Cargar combo proveedores y categorias productos Mantenimiento
            CargarCombo("Proveedores", cmbMantProveedor, bsComboMProveedores, listMProveedores, 1);
            CargarCombo("ProductoCategoria", cmbMantCategoria, bsComboMCateProducto, listMCategoriasProductos, 1);
        }

        private void LimpiarCampos()
        {
            //Panel Busqueda
            txtBusDescripcion.Text = "";
            

            //Panel Mantenimiento
            txtMantDescripcion.Text = "";
            txtMantPrecioVenta.Text = "";
            txtMantLimiteStock.Text = "";
            txtMantPrecioCompra.Text = "";
            txtMantStock.Text = "";
        

            //Cargar combo proveedores y categorias productos Busqueda
            CargarCombo("Proveedores", cmbBusProveedores, bsComboBProveedores, listBProveedores);
            CargarCombo("ProductoCategoria", cmbBuscCategoria, bsComboBCateProducto, listBCategoriasProductos);
         

        }


        private void CargarCombo(string CodPrm, ComboBox cmb, BindingSource bs, List<Parametro> parametros , int fmod = 0)
        {
            Parametro prm = new Parametro();
            prm.CodPrm = CodPrm;
            prm.Fmod = fmod;

            try
            {
                parametros = repoParametro.ObtenerParametro(prm);
                bs.DataSource = parametros;
                cmb.DataSource = bs;
                cmb.DisplayMember = "Descripcion";
                cmb.ValueMember = "Codigo";

                cmb.SelectedValue = parametros.FirstOrDefault().Codigo;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Ocurrio un error al cargar el combos: " + ex.Message, MessageBoxIcon.Warning);
            }
        }


        private void BuscarProducto()
        {
            try
            {
                productoFiltro.Descripcion = txtBusDescripcion.Text.Trim();
                productoFiltro.CodProductoCategoria = Convert.ToInt32(cmbBuscCategoria.SelectedValue);
                productoFiltro.CodProveedor = Convert.ToInt32(cmbBusProveedores.SelectedValue);

                List<ProductosDTO> productos = repoProducto.BuscarProducto(productoFiltro);
                if (productos.Count == 0)
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);

                bsProducto.DataSource = productos;
                dgvProductos.DataSource = bsProducto;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar productos: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (bsProducto != null && bsProducto.Count > 0)
            {
                PanelMant();
                btnActualizar.Visible = true;
                btnCrearCliente.Visible = false;

                ProductosDTO producto = (ProductosDTO)bsProducto.Current;


                codProductoSel = producto.CodProducto;
                //Establecemos los datos del panel de mantenimiento
                txtMantDescripcion.Text = producto.Descripcion;
                txtMantPrecioCompra.Text = producto.PrecioCompra.ToString();
                txtMantPrecioVenta.Text = producto.PrecioVenta.ToString();
                txtMantStock.Text = producto.Stock.ToString();
                txtMantLimiteStock.Text = producto.LimiteStock.ToString();

                cmbMantCategoria.SelectedValue = producto.CodProductoCategoria;
                cmbMantProveedor.SelectedValue = producto.CodProveedor;


                lblMant.Text = "Actualizar Producto";
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PanelMant();
           
        

            LimpiarCampos();
            lblMant.Text = "Crear Producto";

            btnActualizar.Visible = false;
            btnCrearCliente.Visible = true;
        }


        private void MantProducto(string fMant)
        {
            string descripcion = txtMantDescripcion.Text.Trim();
            string precioCompra = txtMantPrecioCompra.Text.Trim();
            string precioVenta = txtMantPrecioVenta.Text.Trim();
            string stock = txtMantStock.Text.Trim();
            string limiteStock = txtMantLimiteStock.Text.Trim();


            string msg = "";


            //Validar campos vacios
            if (String.IsNullOrEmpty(descripcion))
                msg = "*El campo descripción es obligatorio \n";

            if (String.IsNullOrEmpty(precioCompra))
                msg += "*El campo precio compra es obligatorio \n";

            if (String.IsNullOrEmpty(precioVenta))
                msg += "*El campo precio venta es obligatorio \n";

            if (String.IsNullOrEmpty(stock))
                msg += "*El campo stock es obligatorio \n";

            if (String.IsNullOrEmpty(limiteStock))
                msg += "*El campo limite de stock es obligatorio \n";

            //Validar tipos de datos

            if (decimal.TryParse(descripcion, out _))
                msg += "*El campo descripción no debe ser un valor númerico  \n";

            if (!Int32.TryParse(stock, out _))
                msg += "*El campo stock tiene que ser un valor entero válido  \n";

            if (!Int32.TryParse(limiteStock, out _))
                msg += "*El campo mínimo de stock tiene que ser un valor entero válido  \n";

            if (!decimal.TryParse(precioCompra,out _))
                msg += "*El campo precio compra tiene que ser un valor decimal válido  \n";

            if (!decimal.TryParse(precioVenta, out _))
                msg += "*El campo precio venta tiene que ser un valor decimal válido  \n";

            if (msg.Length > 0)
            {
                Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                return;
            }

            Productos productos = new Productos();


            productos.CodProducto = fMant == "R" ? 0 : codProductoSel;
            productos.Descripcion = descripcion;
            productos.PrecioVenta = Convert.ToDecimal(precioVenta);
            productos.PrecioCompra = Convert.ToDecimal(precioCompra);

            productos.Stock = Convert.ToInt32(stock);
            productos.LimiteStock = Convert.ToInt32(limiteStock);

            productos.CodProductoCategoria = ((Parametro)bsComboMCateProducto.Current).Codigo;
            productos.CodProveedor = ((Parametro)bsComboMProveedores.Current).Codigo;
          

            try
            {
                RespuestaDTO res = repoProducto.MantProducto(productos);

                if (res.CodRes == 1)
                {
                    Alerta.Notificacion(res.MsgRespuesta, MessageBoxIcon.Information);
                    PanelPrincipal();
                    LimpiarCampos();
                    BuscarProducto();
                }
                else
                {
                    Alerta.Notificacion(res.MsgRespuesta, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Error en el mantenimiento de producto : " + ex.Message, MessageBoxIcon.Warning);
            }

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            MantProducto("R");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MantProducto("A");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal();
            LimpiarCampos();
        }
    }
}
