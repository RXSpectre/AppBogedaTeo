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
    public partial class frmConsSolCompra : Form
    {
        private static frmConsSolCompra _instance = null;

        private ParametroRepositorio repoParametro;
        private SolCompraRepositorio<SolCompraDTO> repoSolCompra;

        private BindingSource bsSolCompra;
        private BindingSource bsDetSolCompra;
        private BindingSource bsComboBProveedores;
        private BindingSource bsComboBEstado;

        private List<DetSolCompraDTO> listDetSolCompra;
        private SolCompraBuscaDTO solCompraFiltro;
        private List<Parametro> listBProveedores;
        private List<Parametro> listBEstados;

        public frmConsSolCompra(Form form, string cadenaConexion)
        {
            InitializeComponent();

            bsSolCompra = new BindingSource();
            bsDetSolCompra = new BindingSource();
            bsComboBProveedores = new BindingSource();
            bsComboBEstado = new BindingSource();
            listDetSolCompra = new List<DetSolCompraDTO>();
            solCompraFiltro = new SolCompraBuscaDTO();
            listBProveedores = new List<Parametro>();
            listBEstados = new List<Parametro>();

            repoParametro = new ParametroRepositorio(cadenaConexion);
            repoSolCompra = new SolCompraRepositorio<SolCompraDTO>(cadenaConexion);

            CargarCombo("Proveedores", cmbBusProveedores, bsComboBProveedores, listBProveedores);
            CargarCombo("EstadoSolCompra", cmbBusEstado, bsComboBEstado, listBEstados);
        }

        public static frmConsSolCompra GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmConsSolCompra(form, cadenaConexion);

                //_instance.NroDocEmpleado = codEmpleado;
               
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
            txtImpTotalEsperadoSC.Text = "";

            txtBusColSolCompra.Text = "";

            dgvSolCompra.DataSource = null;
            dgvDetSC.DataSource = null;
            txtCodSolCompraSC.Text = "";
            //txtSumImp.Text = "0";
            panelBus.Visible = true;
            panelBus.Dock = DockStyle.Fill;
            panelDetalle.Visible = false;
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
                Alerta.Notificacion("Ocurrio un error al cargar el combos: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void PanelMant()
        {
            panelBus.Visible = false;
            panelDetalle.Visible = true;

        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (bsSolCompra != null && bsSolCompra.Count > 0)
            {
                try
                {
                    SolCompraDTO item = (SolCompraDTO)bsSolCompra.Current;

                    PanelMant();

                    //Pintar datos de orden de pedido
                    txtCodSolCompraSC.Text = item.CodSolCompra.ToString();
                   
                    txtRUCSC.Text = item.RucProveedor;
                    txtRazonSocialSC.Text = item.DscProveedor;
                    txtImpTotalEsperadoSC.Text = item.ImporteTotalEsperado.ToString();
                    txtImpTotalPagadoSC.Text = item.ImporteTotalPagado.ToString();
                    txtObsSC.Text = item.Observacion;
                    txtEmpleaCrea.Text = item.EmpleadoCreador;
                    txtEmpleaModi.Text = item.EmpleadoModificador;
                    txtEstado.Text = item.DscEstadoSolCompra;


                    listDetSolCompra = repoSolCompra.BuscarDetalleSolCompra(item.CodSolCompra);
                    bsDetSolCompra.DataSource = listDetSolCompra;
                    dgvDetSC.DataSource = bsDetSolCompra;

                }
                catch (Exception ex)
                {
                    Alerta.Notificacion("Error al seleccionar la solicitud de compra:\n" + ex.Message, MessageBoxIcon.Error);
                }

            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }


        private void BuscarSolCompra()
        {
            try
            {
                if (dtBusFechaInicio.Value.Date > dtBusFechaFinal.Value.Date)
                {
                    Alerta.Notificacion("El rango de fechas es inválido", MessageBoxIcon.Warning);
                  
                    return;
                }

                int codSolCompra = Int32.TryParse(txtBusColSolCompra.Text.Trim(), out _) ? Convert.ToInt32(txtBusColSolCompra.Text.Trim()) : 0;
                int codProveedor = Convert.ToInt32(cmbBusProveedores.SelectedValue);
                int codEstado = Convert.ToInt32(cmbBusEstado.SelectedValue);
                string fechaIni = dtBusFechaInicio.Value.ToString("yyyyMMdd");
                string fechaFin = dtBusFechaFinal.Value.ToString("yyyyMMdd");
                decimal SumatorioImportesEsperado = 0m;
                solCompraFiltro.CodSolCompra = codSolCompra;
                solCompraFiltro.CodProveedor = codProveedor;
                solCompraFiltro.CodEstadoSolCompra = codEstado;
                solCompraFiltro.fechaInicio = fechaIni;
                solCompraFiltro.fechaFin = fechaFin;


                List<SolCompraDTO> items = repoSolCompra.BuscarSolCompra(solCompraFiltro, out SumatorioImportesEsperado);
                if (items.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    //txtSumImp.Text = "0";
                    bsSolCompra.DataSource = null;
                    dgvSolCompra.DataSource = bsSolCompra;
                }
                   

                //txtSumImp.Text = SumatorioImportesEsperado.ToString();
                bsSolCompra.DataSource = items;
                dgvSolCompra.DataSource = bsSolCompra;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar solicitudes de compra:\n" + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarOP_Click(object sender, EventArgs e)
        {
            BuscarSolCompra();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


    }
}
