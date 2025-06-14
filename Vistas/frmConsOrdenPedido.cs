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
    public partial class frmConsOrdenPedido : Form
    {

        private static frmConsOrdenPedido _instance = null;
        private OrdenPedidoBusDTO ordPedidoFiltro;
        private BindingSource bsOrdenPedido;
        private BindingSource bsDetOrdenPedido;

        private ParametroRepositorio repoParametro;
        private OrdenPedidoRepositorio repoOrdenPedido;

        private List<Parametro> lisPrm;
        private BindingSource bsEstadoOP;
        private List<DetOrdenPedido> listDetOP;


        public int codEmpleado { get; set; }

        public frmConsOrdenPedido(Form form, string cadenaConexion)
        {
            InitializeComponent();

            ordPedidoFiltro = new OrdenPedidoBusDTO();
            bsOrdenPedido = new BindingSource();
            listDetOP = new List<DetOrdenPedido>();
            lisPrm = new List<Parametro>();


            bsEstadoOP = new BindingSource();
            bsDetOrdenPedido = new BindingSource();
          

            repoParametro = new ParametroRepositorio(cadenaConexion);
            repoOrdenPedido = new OrdenPedidoRepositorio(cadenaConexion);


           
            CargarCombo("EstadoOrdenPedido", cmbEstadoOP, bsEstadoOP, lisPrm);

            LimpiarCampos();
            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
            txtNroOP.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtRazonSocial.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
        }

        public static frmConsOrdenPedido GetInstance(Form form, string cadenaConexion, int codEmpleado)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmConsOrdenPedido(form, cadenaConexion);
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;

            }
            else
                _instance.BringToFront();

            _instance.codEmpleado = codEmpleado;

            return _instance;
        }

        private void CargarCombo(string CodPrm, ComboBox cmb, BindingSource bs, List<Parametro> parametros)
        {
            Parametro prm = new Parametro();
            prm.CodPrm = CodPrm;

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
                Alerta.Notificacion("Ocurrio un error al cargar los combos: \n" + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void BuscarOrdenPedido()
        {
            try
            {
                if (dtFechaInicio.Value.Date > dtFechaFinal.Value.Date)
                {
                    Alerta.Notificacion("El rango de fechas es inválido", MessageBoxIcon.Warning);
                    return;
                }

                int nroOrdenPedido = Int32.TryParse(txtNroOP.Text.Trim(), out _) ? Convert.ToInt32(txtNroOP.Text.Trim()) : 0;
                string razonSocial = txtRazonSocial.Text.Trim();
                string fechaInicio = dtFechaInicio.Value.ToString("yyyyMMdd");
                string fechaFinal = dtFechaFinal.Value.ToString("yyyyMMdd");

                ordPedidoFiltro.Nro_Orden = nroOrdenPedido;
                ordPedidoFiltro.NombresCompletos = razonSocial;
                ordPedidoFiltro.CodEstadoOrdenPedido = Convert.ToInt32(cmbEstadoOP.SelectedValue);
                ordPedidoFiltro.FechaInicio = fechaInicio;
                ordPedidoFiltro.FechaFinal = fechaFinal;
                ordPedidoFiltro.Fmod = 2;

                List<OrdenPedidoDTO> ordenPedidos = repoOrdenPedido.ObtenerOrdenPedido(ordPedidoFiltro);

                if (ordenPedidos.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    bsOrdenPedido.DataSource = null;
                    dgvOrdenPedido.DataSource = bsOrdenPedido;
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

        private void btnBuscarHPC_Click(object sender, EventArgs e)
        {
            BuscarOrdenPedido();
        }

        private void btnPreventa_Click(object sender, EventArgs e)
        {
            ActualizarOrdenPedido(2, 2);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            ActualizarOrdenPedido(3, 2);
        }


        private void ActualizarOrdenPedido(int codEstadoOP,int fMant) {

            if (bsOrdenPedido != null && bsOrdenPedido.Count > 0)
            {
                RespuestaDTO respuesta = new RespuestaDTO();
                OrdenPedidoDTO item = (OrdenPedidoDTO)bsOrdenPedido.Current;

                if (item.CodEstadoOrdenPedido != 1)
                {
                    Alerta.Notificacion("El estado del orden de pedido debe ser creado para realizar esta acción", MessageBoxIcon.Warning);
                    return;
                }

                var rpta = Alerta.Confirmacion("Realizaras un acción que luego no se podra modificar, estás seguro?");

                if (!rpta)
                    return;

               
                respuesta = repoOrdenPedido.MantOrdenPedido(new OrdenPedidoMantDTO() { 
                    Nro_Orden = item.Nro_Orden,
                    CodEstadoOrdenPedido = codEstadoOP,
                    Fmant = fMant,
                    CodEmpleadoModi = codEmpleado
                });

                if (respuesta.CodRes == 1)
                    Alerta.Notificacion(respuesta.MsgRespuesta, MessageBoxIcon.Information);
                else
                    Alerta.Notificacion(respuesta.MsgRespuesta, MessageBoxIcon.Warning);

                BuscarOrdenPedido();
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }


        private void PanelMant()
        {
            panelBus.Visible = false;
            panelDetalle.Visible = true;
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (bsOrdenPedido != null && bsOrdenPedido.Count > 0)
            {
                try
                {
                    OrdenPedidoDTO item = (OrdenPedidoDTO)bsOrdenPedido.Current;

                    PanelMant();

                    //Pintar datos de orden de pedido
                    txtDetNroOrdenPedido.Text = item.Nro_Orden.ToString();
                    txtDetNroDocumento.Text = item.Nro_Doc.ToString();
                    txtDetNomCompletos.Text = item.NombresCompletos.ToString();
                    txtDetEstado.Text = item.DscEstado.ToString();
                    txtDetEmpleaCrea.Text = item.EmpleadoCreador;
                    txtDetEmpleaModi.Text = item.EmpleadoModificador;
                    txtDetImpTotal.Text = item.ImporteTotal.ToString();

                    listDetOP = repoOrdenPedido.ObtenerDetOrdenPedido(item.Nro_Orden);
                    bsDetOrdenPedido.DataSource = listDetOP;
                    dgvDetOP.DataSource = bsDetOrdenPedido;

                    BuscarOrdenPedido();

                }
                catch (Exception ex)
                {
                    Alerta.Notificacion("Error al seleccionar el orden de pedido:\n" + ex.Message, MessageBoxIcon.Error);
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

        private void LimpiarCampos()
        {
            txtDetNroDocumento.Text = "";
            txtDetNroOrdenPedido.Text = "";
            txtDetImpTotal.Text = "";
            txtDetEstado.Text = "";
            txtDetNomCompletos.Text = null;
            txtDetEmpleaCrea.Text = "";
            txtDetEmpleaModi.Text = "";

            dgvOrdenPedido.DataSource = null;
            panelBus.Visible = true;
            panelBus.Dock = DockStyle.Fill;
            panelDetalle.Visible = false;
        }
    }

   
}
