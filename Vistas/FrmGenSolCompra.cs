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
    public partial class FrmGenSolCompra : Form
    {

        private static FrmGenSolCompra _instance = null;

        private ProductosBusDTO productoFiltro;


        private SolCompraRepositorio<SolCompraDTO> repoSolCompra;
        private ProveedorRepositorio repoProveedor;
        private ProductoRepositorio<ProductoSolCompraDTO> repoProducto;

        private BindingSource bsProveedores;
        private BindingSource bsProducto;
        private BindingSource bsDetSolCompra;

        private List<DetSolCompraDTO> _listDetSolCompra;

        private int codEmpleado = 0;
        private int codProveedor = 0;
        private decimal importeTotal = 0m;


        

        public FrmGenSolCompra(Form form, string cadenaConexion)
        {
            InitializeComponent();

            bsProveedores = new BindingSource();
            bsProducto = new BindingSource();
            bsDetSolCompra = new BindingSource();

            productoFiltro = new ProductosBusDTO();
      
            _listDetSolCompra = new List<DetSolCompraDTO>();

            repoSolCompra = new SolCompraRepositorio<SolCompraDTO>(cadenaConexion);
            repoProveedor = new ProveedorRepositorio(cadenaConexion);
            repoProducto = new ProductoRepositorio<ProductoSolCompraDTO>(cadenaConexion);
            ValidacionesEventos();
        }


        private void ValidacionesEventos()
        {
            txtBusRazonSocial.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            txtCantidad.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;

        }

        public static FrmGenSolCompra GetInstance(Form form, string cadenaConexion, int codEmpleado)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmGenSolCompra(form, cadenaConexion);

                //_instance.NroDocEmpleado = codEmpleado;
                _instance.codEmpleado = codEmpleado;
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
                _instance.BringToFront();

            _instance.LimpiarCampos();

            return _instance;
        }


       

        private void LimpiarCampos()
        {
            txtRUCSC.Text = "";
            txtRazonSocialSC.Text = "";
            txtImpTotalSC.Text = "";
            txtImpTotalSC.Text = "";

            _listDetSolCompra.Clear();


            bsDetSolCompra.DataSource = null;
            dgvDetSC.DataSource = null;

            bsProducto.DataSource = null;
            dgvProducto.DataSource = null;

            bsProveedores.DataSource = null;
            dgvProveedores.DataSource = null;

            txtCodSolCompraSC.Text = "";


        }

        private void btnBuscarProveedor_Click(object sender, System.EventArgs e)
        {
            BuscarProveedor();
        }

        private void BuscarProveedor()
        {
            string razonSocial = txtBusRazonSocial.Text.Trim();

            try
            {
                //1-> Solo proveedores habilitado se busca
                List<Proveedor> proveedores = repoProveedor.BuscarProveedor("",razonSocial,1);

                if (proveedores.Count == 0)
                {
                    bsProveedores.DataSource = null;
                    dgvProveedores.DataSource = bsProveedores;

                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    return;
                }
                    

                bsProveedores.DataSource = proveedores;
                dgvProveedores.DataSource = bsProveedores;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar proveedor: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnSeleccCliente_Click(object sender, EventArgs e)
        {
            if (bsProveedores != null && bsProveedores.Count > 0)
            {
                Proveedor proveedor = (Proveedor)bsProveedores.Current;
                txtRazonSocialSC.Text = proveedor.RazonSocial.Trim();
                txtRUCSC.Text = proveedor.RucProveedor.Trim();
                codProveedor = proveedor.CodProveedor;

                BuscarProducto();

            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

            if (codProveedor == 0)
            {
                Alerta.Notificacion("Tiene primero que seleccionar un proveedor", MessageBoxIcon.Warning);
                return;
            }

            BuscarProducto();
        }

        private void BuscarProducto()
        {
            try
            {
                productoFiltro.Descripcion = txtBusDescProducto.Text.Trim();
                productoFiltro.CodProductoCategoria = 0;
                productoFiltro.CodProveedor = codProveedor;
                //Filtra productos con stock menor al mínimo de stock
                productoFiltro.FMod = 1;


                List<ProductoSolCompraDTO> productos = repoProducto.BuscarProducto(productoFiltro);
                if (productos.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    bsProducto.DataSource = null;
                    dgvProducto.DataSource = bsProducto;
                    return;
                }
                    

                bsProducto.DataSource = productos;
                dgvProducto.DataSource = bsProducto;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar Producto: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (bsProducto != null && bsProducto.Count > 0)
            {
                try
                {
                    ProductoSolCompraDTO producto = (ProductoSolCompraDTO)bsProducto.Current;

                    //Validaciones previas antes de agregar a la grilla
                    int cantidad = 0;




                    if (!Int32.TryParse(txtCantidad.Text, out cantidad))
                    {
                        Alerta.Notificacion("La cantidad debe ser númerica", MessageBoxIcon.Warning);
                        return;
                    }

                    if (cantidad == 0)
                    {
                        Alerta.Notificacion("Debe indicar una cantidad!", MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtCodSolCompraSC.Text.Length > 0)
                    {
                        Alerta.Notificacion("No se puede agregar un producto , ya que la solicitud de compra ha sido creada", MessageBoxIcon.Warning);
                        return;
                    }

                    //Proceso de Agregar a la grilla
                    DetSolCompraDTO detalle = _listDetSolCompra.Find(p => p.CodProducto == producto.CodProducto);
                    if (detalle != null)
                    {
                        Alerta.Notificacion("El producto ya existe", MessageBoxIcon.Warning);
                        return;
                    }

                    DetSolCompraDTO detSolCompra = new DetSolCompraDTO();
                    detSolCompra.CodProducto = producto.CodProducto;
                    detSolCompra.DscProducto = producto.Descripcion;
                    detSolCompra.PrecioCompra = producto.PrecioCompra;
                    detSolCompra.Cantidad = cantidad; //producto.Stock;
                    detSolCompra.ValorCompra = detSolCompra.PrecioCompra * detSolCompra.Cantidad;
                    detSolCompra.CodDetSolCompra = _listDetSolCompra.Count + 1;

                    _listDetSolCompra.Add(detSolCompra);

                    bsDetSolCompra.DataSource = _listDetSolCompra;
                    dgvDetSC.DataSource = null;
                    dgvDetSC.DataSource = bsDetSolCompra;

                    CalcularTotales();

                    txtCantidad.Text = "1";
                }
                catch (Exception ex)
                {

                    Alerta.Notificacion(ex.Message, MessageBoxIcon.Error);
                }
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }


        private void CalcularTotales()
        {
            importeTotal = _listDetSolCompra.Sum(p => p.ValorCompra);
            txtImpTotalSC.Text = importeTotal.ToString("0.00");
        }

        private void btnRetirarProducto_Click(object sender, EventArgs e)
        {

            if (_listDetSolCompra.Count==0)
            {
                Alerta.Notificacion("No existen datos para retirar", MessageBoxIcon.Warning);
                return;
            }

            if (!String.IsNullOrEmpty(txtCodSolCompraSC.Text))
            {
                Alerta.Notificacion("No se puede retirar el producto ya que se creo la solicitud de Compra Cod.: " + txtCodSolCompraSC.Text, MessageBoxIcon.Warning);
                return;
            }

            if (bsDetSolCompra != null && bsDetSolCompra.Count > 0)
            {
                try
                {
                    DetSolCompraDTO detalle = new DetSolCompraDTO();
                    detalle = (DetSolCompraDTO)bsDetSolCompra.Current;

                    //Retira elemento de la lista
                    _listDetSolCompra.RemoveAll(p => p.CodProducto == detalle.CodProducto);

                    bsDetSolCompra.DataSource = _listDetSolCompra;
                    dgvDetSC.DataSource = null;
                    dgvDetSC.DataSource = bsDetSolCompra;

                    CalcularTotales();

                }
                catch (IndexOutOfRangeException) {

                    Alerta.Notificacion("Tiene que seleccionar un registro del detalle para poder retirar el producto", MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {

                    Alerta.Notificacion(ex.Message, MessageBoxIcon.Error);
                }
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();


        }

        private void btnGenerarOrdenPedido_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (String.IsNullOrEmpty(txtRazonSocialSC.Text))
                msg += "*Tiene que haber seleccionado un proveedor\n";
            if (_listDetSolCompra.Count == 0)
                msg += "*Tiene que haber seleccionado un producto\n";
            if(txtCodSolCompraSC.Text.Length>0)
                msg += "*Ya ha sido generado la solicitud de compra, favor de limpiar la actual para generar una nueva\n";



            if (msg.Length > 0)
            {
                Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                return;
            }

            RespuestaDTO response = new RespuestaDTO();
            try
            {
                //Insertamos Solicitud de Compra
                response = repoSolCompra.MantSolCompra(new SolCompra()
                {
                    CodSolCompra = 0,
                    CodProveedor = codProveedor,
                    ImporteTotalEsperado = Convert.ToDecimal(txtImpTotalSC.Text.Trim()),
                    CodEmpleadoCrea = codEmpleado
                });

                if (response.CodRes != 1) {
                    Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Warning);
                    return;
                }
                
                int CodSolCompraGen = Convert.ToInt32(response.MsgRespuesta);

                foreach (var det in _listDetSolCompra)
                {
                    det.CodSolCompra = CodSolCompraGen;

                    response = repoSolCompra.InsertDetSolCompra(det);

                    if (response.CodRes != 1)
                        throw new Exception(response.MsgRespuesta);
                }

                Alerta.Notificacion("Se registro la solicitud de Compra: " + CodSolCompraGen, MessageBoxIcon.Information);

                txtCodSolCompraSC.Text = CodSolCompraGen.ToString();
            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Ocurrio un error al generar la orden de pedido :\n" + ex.Message, MessageBoxIcon.Error);
            }
        }

    }
}
