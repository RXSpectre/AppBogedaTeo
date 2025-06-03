using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppBogedaTeo
{
    public partial class frmConsVentas : Form
    {
        private static frmConsVentas _instance = null;
        private VentasBusDTO ventasFiltro;
        
        private BindingSource bsVentas;
        private VentasRepositorio repoVentas;
        private OrdenPedidoRepositorio repoOrdenPedido;
        private ParametroRepositorio repoParametro;

        private BindingSource bsDetVentas;
        private BindingSource bsMetodoPago;
        private List<Parametro> listMetodoPago;

      

        public frmConsVentas(Form form, string cadenaConexion)
        {
            InitializeComponent();
            bsVentas = new BindingSource();
            bsDetVentas = new BindingSource();
            bsMetodoPago = new BindingSource();
            ventasFiltro = new VentasBusDTO();
            listMetodoPago = new List<Parametro>();

            repoVentas = new VentasRepositorio(cadenaConexion);
            repoOrdenPedido = new OrdenPedidoRepositorio(cadenaConexion);
            repoParametro = new ParametroRepositorio(cadenaConexion);
           

            CargarCombo("MetodoPago", cmbMetodoPago, bsMetodoPago, listMetodoPago);
            LimpiarCampos();
            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
         
            txtRazonSocial.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            txtNroDoc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
        }


        public static frmConsVentas GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmConsVentas(form, cadenaConexion);
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;

            }
            else
                _instance.BringToFront();

            _instance.LimpiarCampos();

            return _instance;
        }

        private void btnBuscarHPC_Click(object sender, EventArgs e)
        {
            BuscarVentas();
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


        private void BuscarVentas()
        {
            try
            {

                if (dtFechaInicio.Value.Date > dtFechaFinal.Value.Date)
                {
                    Alerta.Notificacion("El rango de fechas es inválido", MessageBoxIcon.Warning);
                    return;
                }

                string razonSocial = txtRazonSocial.Text.Trim();
                string fechaInicio = dtFechaInicio.Value.ToString("yyyyMMdd");
                string fechaFinal = dtFechaFinal.Value.ToString("yyyyMMdd");
                int codMetodoPago = (int)cmbMetodoPago.SelectedValue;
                decimal sumatoriaImportes = 0m;

                ventasFiltro.Nro_Doc = txtNroDoc.Text.Trim();
                ventasFiltro.NombresCompletos = razonSocial;

                ventasFiltro.FechaInicio = fechaInicio;
                ventasFiltro.FechaFinal = fechaFinal;
                ventasFiltro.CodMetodoPago = codMetodoPago;
                List<VentasDTO> ventas = repoVentas.ObtenerVentas(ventasFiltro, out sumatoriaImportes);

                if (ventas.Count == 0) {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    //txtSumImp.Text = "0";
                    bsVentas.DataSource = null;
                    dgvOrdenPedido.DataSource = null;
                }
                    

                bsVentas.DataSource = ventas;
                dgvOrdenPedido.DataSource = bsVentas;

              
                //txtSumImp.Text = sumatoriaImportes.ToString();
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar ventas:\n" + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {

            //Búsqueda
            txtNroDoc.Text = "";
            txtRazonSocial.Text = "";
      
            //Detalle
            txtDetCodVenta.Text = "";
            txtDetNroDoc.Text = "";
            txtDetNomCompletos.Text = "";

            txtDetFechaCreacion.Text = "";
            txtDetFechaLimite.Text = "";
            //txtSumImp.Text = "0";
            bsVentas.DataSource = null;
            dgvOrdenPedido.DataSource = null;
            dgvDetVentas.DataSource = null;

            panelBus.Visible = true;
            panelBus.Dock = DockStyle.Fill;
            panelDetalle.Visible = false;
        }

        private void PanelMant()
        {
            panelBus.Visible = false;
            panelDetalle.Visible = true;

        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (bsVentas != null && bsVentas.Count > 0)
            {
                try
                {
                    VentasDTO item = (VentasDTO)bsVentas.Current;

                    PanelMant();

                    //Pintar datos de orden de pedido
                    txtDetCodVenta.Text = item.Cod_Venta.ToString();
                    txtDetNroDoc.Text = item.Nro_Doc.ToString();
                    txtDetNomCompletos.Text = item.NombresCompletos.ToString();
                    txtDetFechaCreacion.Text = item.FechaCreacion;
                    txtDetFechaLimite.Text = item.FechaLimitePago;
                    txtDetEstado.Text = item.DscEstado;
                    txtDetImporte.Text = item.ImporteTotal.ToString();

                    txtDetTipoComprobante.Text = item.DscTipoComp;
                    txtDetMetodoPago.Text = item.DscMetodoPago;
                    //txtSumImp.Text = item.ImporteTotal.ToString();



                    List<DetOrdenPedido> listDetOP = repoOrdenPedido.ObtenerDetOrdenPedido(item.Nro_Orden);
                    bsDetVentas.DataSource = listDetOP;
                    dgvDetVentas.DataSource = bsDetVentas;

                }
                catch (Exception ex)
                {
                    Alerta.Notificacion("Error al seleccionar la venta:\n" + ex.Message, MessageBoxIcon.Error);
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

       
    }
}
