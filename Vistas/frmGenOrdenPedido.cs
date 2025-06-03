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
    public partial class frmGenOrdenPedido : Form
    {
        private static frmGenOrdenPedido _instance = null;
        private ClienteBusDTO clienteFiltro;
        private BindingSource bsCliente;
        private ClienteRepositorio<ClienteOrdenPedidoDTO> repoCliente;

        private OrdenPedidoRepositorio repoOrdenPedido;
        private BindingSource bsProducto;
        private ProductosBusDTO productoFiltro;

        private ProductoRepositorio<ProductoOrdenPedidoDTO> productoRepositorio;

        private List<DetOrdenPedido> listDetOP;
        private BindingSource bslistDetOP;

        private decimal importeTotal = 0m;
   
        private int codEmpleado = 0;
        private int codCliente = 0;

        public frmGenOrdenPedido(Form form, string cadenaConexion)
        {
            InitializeComponent();
            
            bsCliente = new BindingSource();
            repoCliente = new ClienteRepositorio<ClienteOrdenPedidoDTO>(cadenaConexion);
            clienteFiltro = new ClienteBusDTO();

            bsProducto = new BindingSource();
            repoOrdenPedido = new OrdenPedidoRepositorio(cadenaConexion);
            productoFiltro = new ProductosBusDTO();

            productoRepositorio = new ProductoRepositorio<ProductoOrdenPedidoDTO>(cadenaConexion);

            bslistDetOP = new BindingSource();
            listDetOP = new List<DetOrdenPedido>();

            BuscarCliente();
            BuscarProducto();
            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
            txtBusNroDoc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtCantidad.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
           
        }

        public static frmGenOrdenPedido GetInstance(Form form, string cadenaConexion,int codEmpleado)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmGenOrdenPedido(form, cadenaConexion);

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

        private void BuscarCliente()
        {
            try
            {
                clienteFiltro.Nro_Doc = txtBusNroDoc.Text.Trim();

                //Solo buscamos a clientes que no son inhabilitados
                clienteFiltro.FMant = 'G';

                dgvClientes.DataSource = null;

                if (clienteFiltro.Nro_Doc.Length > 0 && clienteFiltro.Nro_Doc.Length < 8)
                {
                    Alerta.Notificacion("Ingrese un DNI válido", MessageBoxIcon.Information);
                    return;
                }

                List<ClienteOrdenPedidoDTO> clientes = repoCliente.BuscarCliente(clienteFiltro);
               
                if (clientes.Count == 0) {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    return;
                }

                bsCliente.DataSource = clientes;
                dgvClientes.DataSource = bsCliente;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar cliente: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void BuscarProducto()
        {
            try
            {
                productoFiltro.Descripcion = txtBusDescProducto.Text.Trim();
                //Solo muestra productos con stock disponible
                productoFiltro.FMod = 2;

                List<ProductoOrdenPedidoDTO> productos = productoRepositorio.BuscarProducto(productoFiltro);

                if (productos.Count == 0)
                    Alerta.Notificacion("No existen productos con el nombre ingresado", MessageBoxIcon.Information);

                bsProducto.DataSource = productos;
                dgvProducto.DataSource = bsProducto;

            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar Producto: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnSeleccCliente_Click(object sender, EventArgs e)
        {
            if (bsCliente != null && bsCliente.Count > 0)
            {
                ClienteOrdenPedidoDTO cliente = (ClienteOrdenPedidoDTO)bsCliente.Current;
                txtNroDocOP.Text = cliente.Nro_Doc.Trim();
                txtRazonSocialOP.Text = cliente.NombresCompletos.Trim();
                codCliente = cliente.CodCliente;
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            txtNroDocOP.Text = "";
            txtRazonSocialOP.Text = "";
            txtImpTotalOP.Text = "";
            listDetOP.Clear();

            bsProducto.DataSource = null;
            dgvProducto.DataSource = null;

            bsCliente.DataSource = null;
            dgvClientes.DataSource = null;

            dgvDetOP.DataSource = null;
            txtNroOrdPOP.Text = "";
           

        }

        private void btnSeleccProducto_Click(object sender, EventArgs e)
        {
            if (bsProducto != null && bsProducto.Count > 0)
            {
                try
                {
                    ProductoOrdenPedidoDTO producto = (ProductoOrdenPedidoDTO)bsProducto.Current;

                    int cantidad = 0;


                    if (!String.IsNullOrEmpty(txtNroOrdPOP.Text))
                    {
                        Alerta.Notificacion("No se puede agregar , ya que la orden de pedido esta generada", MessageBoxIcon.Warning);
                        return;
                    }

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

                    if (cantidad > producto.Stock)
                    {
                        Alerta.Notificacion("La cantidad supera el stock del producto", MessageBoxIcon.Warning);
                        return;
                    }

                    DetOrdenPedido detalle=listDetOP.Find(p => p.CodProducto == producto.CodProducto);
                    if (detalle != null) {
                        Alerta.Notificacion("El producto ya existe", MessageBoxIcon.Warning);
                        return;
                    }

                    DetOrdenPedido ordenPedido = new DetOrdenPedido();
                    ordenPedido.CodProducto = producto.CodProducto;
                    ordenPedido.Descripcion = producto.Descripcion;
                    ordenPedido.PrecioVenta = producto.PrecioVenta;
                    ordenPedido.Cantidad = cantidad; //producto.Stock;
                    ordenPedido.ValorVenta = ordenPedido.PrecioVenta * ordenPedido.Cantidad;
                    ordenPedido.Nro_Detalle = listDetOP.Count + 1;

                    listDetOP.Add(ordenPedido);

                    bslistDetOP.DataSource = listDetOP;
                    dgvDetOP.DataSource = null;
                    dgvDetOP.DataSource = bslistDetOP;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool rpta=Alerta.Confirmacion("¡Estás seguro que deseas cancelar la generación de la orden de pedido?");
            if (rpta)
                LimpiarCampos();
        }

        private void btnRetirarProducto_Click(object sender, EventArgs e)
        {
            if (txtNroOrdPOP.Text.Length > 0) {
                Alerta.Notificacion("No se puede retirar el producto ya que se creo la orden de pedido Nro.: "+ txtNroOrdPOP.Text, MessageBoxIcon.Warning);
                return;
            }

            if (bslistDetOP != null && bslistDetOP.Count > 0)
            {
                try
                {
                    DetOrdenPedido detalle = (DetOrdenPedido)bslistDetOP.Current;

                    //Retira elemento de la lista
                    listDetOP.RemoveAll(p => p.CodProducto == detalle.CodProducto);

                    bslistDetOP.DataSource = listDetOP;
                    dgvDetOP.DataSource = null;
                    dgvDetOP.DataSource = bslistDetOP;

                    CalcularTotales();

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

        private void btnGenerarOrdenPedido_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (!String.IsNullOrEmpty(txtNroOrdPOP.Text))
                msg += "*No se puede generar un orden de pedido,favor de cambiar el estado a preventa o anule la orden \n";

            if (txtNroDocOP.Text.Length == 0)
                msg += "*Tiene que haber seleccionado un cliente\n";
            if (listDetOP.Count==0)
                msg += "*Tiene que haber seleccionado un producto\n";


            if (msg.Length > 0) {
                Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                return;
            }

            RespuestaDTO response = new RespuestaDTO();

            try
            {
                //Insertamos Orden Pedido
                response = repoOrdenPedido.MantOrdenPedido(new OrdenPedidoMantDTO()
                {
                    ImporteTotal=importeTotal,
                    CodEstadoOrdenPedido=1,
                    CodEmpleadoCrea=codEmpleado,
                    CodCliente = codCliente,
                    Fmant =1
                });

                if (response.CodRes != 1)
                    throw new Exception(response.MsgRespuesta);

                int NroOrden= Convert.ToInt32(response.MsgRespuesta);

                foreach (var det in listDetOP)
                {
                    det.Nro_Orden = NroOrden;
                    response =repoOrdenPedido.InsDetaOrdenPedido(det);
                    if (response.CodRes != 1)
                        throw new Exception(response.MsgRespuesta);
                }

                Alerta.Notificacion("Se registro la Orden de Pedido Nro: "+ NroOrden+".\n" +
                    "Favor de cambiar el estado a preventa para seguir con el flujo de cobranza" , MessageBoxIcon.Information);

                txtNroOrdPOP.Text = NroOrden.ToString();

            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Ocurrio un error al generar la orden de pedido :\n"+ ex.Message, MessageBoxIcon.Error);
            }

        }

        private void CalcularTotales() {
            importeTotal = listDetOP.Sum(p => p.ValorVenta);
            txtImpTotalOP.Text = importeTotal.ToString("0.00");

        }

        private void btnPreventa_Click(object sender, EventArgs e)
        {
            if (txtNroOrdPOP.Text.Length == 0)
            {
                Alerta.Notificacion("No hay un Nro. de orden de pedido que se haya generado", MessageBoxIcon.Warning);
                return;
            }

            var rpta= Alerta.Confirmacion("¿Estás seguro que deseas cambiar el estado? ,ten en cuenta que esta acción luego no se podra modificar ");

            if (!rpta)
                return;

            RespuestaDTO response = new RespuestaDTO();

            try
            {
                response = repoOrdenPedido.MantOrdenPedido(new OrdenPedidoMantDTO()
                {
                    Nro_Orden = Convert.ToInt32(txtNroOrdPOP.Text.Trim()),
                    CodEstadoOrdenPedido = 2,
                    Fmant = 2

                });


                if (response.CodRes == 0) {
                    Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Warning);
                    return;
                }
                    
                Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Ocurrio un error al cambiar el estado a preventa:\n"+ ex.Message , MessageBoxIcon.Error);
            }
        }



        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (txtNroOrdPOP.Text.Length == 0)
            {
                Alerta.Notificacion("No hay un Nro. de orden de pedido que se haya generado", MessageBoxIcon.Warning);
                return;
            }

            var rpta = Alerta.Confirmacion("¿Estás seguro que deseas cambiar el estado? ,ten en cuenta que esta acción luego no se podra modificar ");

            if (!rpta)
                return;

            RespuestaDTO response = new RespuestaDTO();

            try
            {
                response = repoOrdenPedido.MantOrdenPedido(new OrdenPedidoMantDTO()
                {
                    Nro_Orden = Convert.ToInt32(txtNroOrdPOP.Text.Trim()),
                    CodEstadoOrdenPedido = 3,
                    Fmant = 2,
                    CodEmpleadoModi = codEmpleado

                });

                if (response.CodRes == 0)
                {
                    Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Warning);
                    return;
                }

                Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Ocurrio un error al anular el orden de pedido:\n"+ex.Message, MessageBoxIcon.Error);
            }
        }


    
    }
}
