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
    public partial class frmRegisVenta : Form
    {
        private static frmRegisVenta _instance = null;
        private OrdenPedidoBusDTO ordPedidoFiltro;
        private BindingSource bsOrdenPedido;

        private ParametroRepositorio repoParametro;
        private OrdenPedidoRepositorio repoOrdenPedido;
        private VentasRepositorio repoVentas;

        private List<DetOrdenPedido> listDetOP;
        private BindingSource bslistDetOP;

        private List<Parametro> listTipoCompro;
        private BindingSource bsTipoCompro;

        public int  codEmpleado { get; set; }

        private frmRegisVenta(Form form, string cadenaConexion)
        {
            InitializeComponent();
            ordPedidoFiltro = new OrdenPedidoBusDTO();
            bsOrdenPedido = new BindingSource();

            repoParametro = new ParametroRepositorio(cadenaConexion);
            repoOrdenPedido = new OrdenPedidoRepositorio(cadenaConexion);
            repoVentas = new VentasRepositorio(cadenaConexion);

            listDetOP = new List<DetOrdenPedido>();
            bslistDetOP = new BindingSource();
            listTipoCompro = new List<Parametro>();
            bsTipoCompro = new BindingSource();

            BuscarOrdenPedido();
            ValidacionesEventos();
        }


        private void ValidacionesEventos()
        {
            txtBusNroOP.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtBusNroDoc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
        }

        public static frmRegisVenta GetInstance(Form form, string cadenaConexion , int codEmpleado)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmRegisVenta(form, cadenaConexion);
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
                
            }
            else
                _instance.BringToFront();

            _instance.PanelPrincipal();
            _instance.LimpiarCampos();
            _instance.codEmpleado = codEmpleado;
            return _instance;
        }

        private void PanelPrincipal()
        {
            panelBus.Visible = true;
            panelBus.Dock = DockStyle.Fill;
            panelDetOP.Visible = false;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            //Panel Busqueda
            txtBusNroDoc.Text = "";
            txtBusNroOP.Text = "";

            //Panel Mantenimiento
            txtImpTotalOP.Text = "";
           
            CargarCombo("TipoComprobante", cmbTipoComprobante, bsTipoCompro, listTipoCompro);
            listDetOP.Clear();
            dgvDetOP.DataSource = null;

        }

        private void PanelMant()
        {
            panelBus.Visible = false;
            panelDetOP.Visible = true;

        }

        private void CargarCombo(string CodPrm, ComboBox cmb, BindingSource bs, List<Parametro> parametros,int Fmod = 1)
        {
            Parametro prm = new Parametro();
            prm.CodPrm = CodPrm;
            prm.Fmod = Fmod;

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

       

        private void BuscarOrdenPedido()
        {
            try
            {
                int nroOrdenPedido = Int32.TryParse(txtBusNroOP.Text.Trim(), out _) ? Convert.ToInt32(txtBusNroOP.Text.Trim()) : 0;
                string nroDoc = Int32.TryParse(txtBusNroDoc.Text.Trim(), out _) ? txtBusNroDoc.Text.Trim() : "";

                //Limpiamos grilla
                bsOrdenPedido.DataSource = null;

                if (nroDoc.Length > 0 && nroDoc.Length < 8)
                {
                    Alerta.Notificacion("Ingrese un DNI válido", MessageBoxIcon.Information);
                    return;
                }

                ordPedidoFiltro.Nro_Orden = nroOrdenPedido;
                ordPedidoFiltro.Nro_Doc = nroDoc;
                ordPedidoFiltro.Fmod = 1;
                List<OrdenPedidoDTO> ordenPedidos = repoOrdenPedido.ObtenerOrdenPedido(ordPedidoFiltro);
                if (ordenPedidos.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    return;
                }
                    
                bsOrdenPedido.DataSource = ordenPedidos;
                dgvOrdenPedido.DataSource = bsOrdenPedido;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar ordenes de pedido:\n" + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarOP_Click(object sender, EventArgs e)
        {
            BuscarOrdenPedido();
        }

        private void btnGenerarOrdenPedido_Click(object sender, EventArgs e)
        {
            if (bsOrdenPedido != null && bsOrdenPedido.Count > 0)
            {
                try
                {
                    OrdenPedidoDTO item = (OrdenPedidoDTO)bsOrdenPedido.Current;

                    PanelMant();

                    //Pintar datos de orden de pedido
                    txtNroDocOP.Text = item.Nro_Doc;
                    txtNroOrdPOP.Text = item.Nro_Orden.ToString();
                    txtRazonSocialOP.Text = item.NombresCompletos;
                    txtImpTotalOP.Text = item.ImporteTotal.ToString();

                    //CargarCombo("TipoComprobante", cmbTipoComprobante, bsTipoCompro, listTipoCompro, 1);

                    listDetOP = repoOrdenPedido.ObtenerDetOrdenPedido(item.Nro_Orden);
                    bslistDetOP.DataSource = listDetOP;
                    dgvDetOP.DataSource = bslistDetOP;

                }
                catch (Exception ex)
                {
                    Alerta.Notificacion("Error al seleccionar la orden de pedido:\n"+ex.Message, MessageBoxIcon.Error);
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
            PanelPrincipal();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var rpta=Alerta.Confirmacion("¿Seguro que deseas confirmar la venta?");
            if (!rpta)
                return;

            RespuestaDTO response = new RespuestaDTO();
            try
            {

                response = repoVentas.GenVentas(new VentasMantDTO()
                {
                    Nro_Orden = Convert.ToInt32(txtNroOrdPOP.Text),
                    ImporteTotal = Convert.ToDecimal(txtImpTotalOP.Text),
                    Tipo_Comp = Convert.ToInt32(cmbTipoComprobante.SelectedValue),
                    CodEmpleado = codEmpleado
                }) ;

                if (response.CodRes == 0) {
                    Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Warning);
                    return;
                }

                Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Information);

                LimpiarCampos();
                BuscarOrdenPedido();
                PanelPrincipal();
               
            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Error al generar la venta:\n" + ex.Message, MessageBoxIcon.Error);
            }
            

        }
    }
}
