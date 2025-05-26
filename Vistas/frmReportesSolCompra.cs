using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppBogedaTeo.Vistas
{
    public partial class frmReportesSolCompra : Form
    {

        private static frmReportesSolCompra _instance = null;
        private ParametroRepositorio repoParametro;
        private SolCompraRepositorio<SolCompraDTO> repoSolCompra;

        private BindingSource bsSolCompra;
      
        private BindingSource bsComboBProveedores;
        private BindingSource bsComboBEstado;

      
        private SolCompraBuscaDTO solCompraFiltro;
        private List<Parametro> listBProveedores;
        private List<Parametro> listBEstados;

        private frmReportesSolCompra(Form form, string cadenaConexion)
        {
            InitializeComponent();

            bsSolCompra = new BindingSource();
            bsComboBProveedores = new BindingSource();
            bsComboBEstado = new BindingSource();
     
            solCompraFiltro = new SolCompraBuscaDTO();
            listBProveedores = new List<Parametro>();
            listBEstados = new List<Parametro>();

            repoParametro = new ParametroRepositorio(cadenaConexion);
            repoSolCompra = new SolCompraRepositorio<SolCompraDTO>(cadenaConexion);

            CargarCombo("Proveedores", cmbBusProveedores, bsComboBProveedores, listBProveedores);
            CargarCombo("EstadoSolCompraReporte", cmbBusEstado, bsComboBEstado, listBEstados);
            EstablecerFechas();
            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
            txtBusColSolCompra.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
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

        public static frmReportesSolCompra GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmReportesSolCompra(form, cadenaConexion);
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;

            }
            else
                _instance.BringToFront();

            return _instance;
        }

        private void btnBuscarOP_Click(object sender, EventArgs e)
        {
            BuscarSolCompraReporte();
        }

        private void BuscarSolCompraReporte()
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
                solCompraFiltro.CodSolCompra = codSolCompra;
                solCompraFiltro.CodProveedor = codProveedor;
                solCompraFiltro.CodEstadoSolCompra = codEstado;
                solCompraFiltro.fechaInicio = fechaIni;
                solCompraFiltro.fechaFin = fechaFin;


                SolCompraReportesDTO response = repoSolCompra.ReporteSolCompra(solCompraFiltro);

                if (response.data.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    bsSolCompra.DataSource = null;
                    dgvSolCompra.DataSource = bsSolCompra;
                    return;
                }

                EstablecerResumen(response);

                bsSolCompra.DataSource = response.data;
                dgvSolCompra.DataSource = bsSolCompra;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar solicitudes de compra:\n" + ex.Message, MessageBoxIcon.Warning);
            }
        }


        private void EstablecerResumen(SolCompraReportesDTO reportes) 
        {

                txtCantAnulados.Text = "0";
                txtCantTerminado.Text = "0";
                txtCantObs.Text = "0";
                txtCantRegis.Text = "0";
                txtSumImp.Text = "0";


                foreach (var item in reportes.estadosXCantidad)
                {
                    if (item.DscEstadoSolCompra == "Anulado")
                        txtCantAnulados.Text = item.Cantidad.ToString();
                    if (item.DscEstadoSolCompra == "Terminado")
                        txtCantTerminado.Text = item.Cantidad.ToString();
                    if (item.DscEstadoSolCompra == "Terminado con observaciones")
                        txtCantObs.Text = item.Cantidad.ToString();
                    if (item.DscEstadoSolCompra == "Todos")
                        txtCantRegis.Text = item.Cantidad.ToString();
                }
                txtSumImp.Text = reportes.ImporteTotalPagado.ToString();
            
        }

        private void EstablecerFechas()
        {
            int year = DateTime.Now.Date.Year;
            int month = DateTime.Now.Date.Month;
            dtBusFechaInicio.Value = new DateTime(year, month, 1);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    DialogResult dialogResult = fbd.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {

                        int codSolCompra = Int32.TryParse(txtBusColSolCompra.Text.Trim(), out _) ? Convert.ToInt32(txtBusColSolCompra.Text.Trim()) : 0;
                        int codProveedor = Convert.ToInt32(cmbBusProveedores.SelectedValue);
                        int codEstado = Convert.ToInt32(cmbBusEstado.SelectedValue);
                        string fechaIni = dtBusFechaInicio.Value.ToString("yyyyMMdd");
                        string fechaFin = dtBusFechaFinal.Value.ToString("yyyyMMdd");
                        solCompraFiltro.CodSolCompra = codSolCompra;
                        solCompraFiltro.CodProveedor = codProveedor;
                        solCompraFiltro.CodEstadoSolCompra = codEstado;
                        solCompraFiltro.fechaInicio = fechaIni;
                        solCompraFiltro.fechaFin = fechaFin;

                        SolCompraReportesDTO response = repoSolCompra.ReporteSolCompra(solCompraFiltro);
                        if (response.data.Count == 0)
                        {
                            Alerta.Notificacion("No hay registros para generar el excel", MessageBoxIcon.Warning);
                            return;
                        }

                        SolCompraPDFDocument solCompraPDFDocument = new SolCompraPDFDocument(response);


                        string nombreArchivo = "ReporteSolCompras" + DateTime.Now.Millisecond.ToString();
                        nombreArchivo = nombreArchivo + ".pdf";
                        solCompraPDFDocument.GeneratePdf(fbd.SelectedPath.Trim() + "\\" + nombreArchivo);

                        Alerta.Notificacion("Se genero el pdf en la ruta solicitada ", MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Ocurrio un error al generar el PDF : " + ex.Message, MessageBoxIcon.Error);
            }

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    DialogResult dialogResult = fbd.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {

                        int codSolCompra = Int32.TryParse(txtBusColSolCompra.Text.Trim(), out _) ? Convert.ToInt32(txtBusColSolCompra.Text.Trim()) : 0;
                        int codProveedor = Convert.ToInt32(cmbBusProveedores.SelectedValue);
                        int codEstado = Convert.ToInt32(cmbBusEstado.SelectedValue);
                        string fechaIni = dtBusFechaInicio.Value.ToString("yyyyMMdd");
                        string fechaFin = dtBusFechaFinal.Value.ToString("yyyyMMdd");
                        solCompraFiltro.CodSolCompra = codSolCompra;
                        solCompraFiltro.CodProveedor = codProveedor;
                        solCompraFiltro.CodEstadoSolCompra = codEstado;
                        solCompraFiltro.fechaInicio = fechaIni;
                        solCompraFiltro.fechaFin = fechaFin;


                        SolCompraReportesDTO response = repoSolCompra.ReporteSolCompra(solCompraFiltro);
                        if (response.data.Count == 0)
                        {
                            Alerta.Notificacion("No hay registros para generar el excel", MessageBoxIcon.Warning);
                            return;
                        }


                        //Nombre de Columnas
                        string[] columnas = { "CÓDIGO",
                                              "RUC",
                                              "RAZÓN SOCIAL",
                                              "ESTADO",
                                              "F. CREACIÓN",
                                              "TOTAL ESPERADO",
                                              "TOTAL PAGADO",
                                              };

                        result = ExcelUtil.GenerarReporteSolCompraXls(response.data, columnas, "ReporteSolCompra", fbd.SelectedPath.Trim());

                        if (result == "ok")
                            Alerta.Notificacion("Se genero el excel en la ruta solicitada ", MessageBoxIcon.Information);
                        else
                            throw new Exception("");
                    }
                }

            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al exporta la data: " + ex.Message, MessageBoxIcon.Error);
            }
        }
    }

}
