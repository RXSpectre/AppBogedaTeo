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
    public partial class frmReportesVentas : Form
    {
        private static frmReportesVentas _instance = null;
        private BindingSource bsVentas;
        private VentasRepositorio repoVentas;
        private ParametroRepositorio repoParametro;
        private BindingSource bsMetodoPago;
        private List<Parametro> listMetodoPago;
        private VentasBusDTO ventasFiltro;
        private VentasPDFDocument ventasPDFDocument;

        private frmReportesVentas(Form form, string cadenaConexion)
        {
            InitializeComponent();
            bsVentas = new BindingSource();
            ventasFiltro = new VentasBusDTO();
            bsMetodoPago = new BindingSource();
            listMetodoPago = new List<Parametro>();
           

            repoVentas = new VentasRepositorio(cadenaConexion);
            repoParametro = new ParametroRepositorio(cadenaConexion);
            CargarCombo("MetodoPago", cmbMetodoPago, bsMetodoPago, listMetodoPago);
            ValidacionesEventos();
            EstablecerFechas();
        }

        public static frmReportesVentas GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmReportesVentas(form, cadenaConexion);
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;

            }
            else
                _instance.BringToFront();

            return _instance;
        }

        private void ValidacionesEventos()
        {

            txtCliente.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            txtNroDoc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
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

                string cliente = txtCliente.Text.Trim();
                string fechaInicio = dtFechaInicio.Value.ToString("yyyyMMdd");
                string fechaFinal = dtFechaFinal.Value.ToString("yyyyMMdd");
                int codMetodoPago = (int)cmbMetodoPago.SelectedValue;

                ventasFiltro.Nro_Doc = txtNroDoc.Text.Trim();
                ventasFiltro.NombresCompletos = cliente;

                ventasFiltro.FechaInicio = fechaInicio;
                ventasFiltro.FechaFinal = fechaFinal;
                ventasFiltro.CodMetodoPago = codMetodoPago;

                VentasReportesDTO ventas = repoVentas.ReporteVentas(ventasFiltro);

                ReiniciarResumen();

                if (ventas.data.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    ReiniciarResumen();
                }


                bsVentas.DataSource = ventas.data;
                dgvOrdenPedido.DataSource = bsVentas;

                //Resumen
                foreach (var resu in ventas.resumen)
                {
                    
                    if(resu.CodMetodoPago == 0) //todos las ventas
                    {
                        txtCantVentas.Text = resu.Cantidad.ToString();
                        txtSumImp.Text = resu.ImporteTotal.ToString();
                    }

                    if (resu.CodMetodoPago == 1) //Datos del ventas Al Contado
                    {
                        txtCantContado.Text = resu.Cantidad.ToString();
                        txtImpTotalContado.Text = resu.ImporteTotal.ToString();
                    }

                    if (resu.CodMetodoPago == 2) //Datos del ventas Al Crédito
                    {
                        txtCantCredito.Text = resu.Cantidad.ToString();
                        txtImpTotalCredito.Text = resu.ImporteTotal.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar ventas:\n" + ex.Message, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarVentas();
        }

        private void ReiniciarResumen()
        {
            txtCantContado.Text = "0";
            txtSumImp.Text = "0";
            txtCantContado.Text = "0";
            txtImpTotalContado.Text = "0";
            txtCantCredito.Text = "0";
            txtImpTotalCredito.Text = "0";
        }


        private void EstablecerFechas()
        {
            int year = DateTime.Now.Date.Year;
            int month = DateTime.Now.Date.Month;
            dtFechaInicio.Value = new DateTime(year, month, 1);
        }

        //Exporta el excel en base a lo que esta en la grilla
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

                        string cliente = txtCliente.Text.Trim();
                        string fechaInicio = dtFechaInicio.Value.ToString("yyyyMMdd");
                        string fechaFinal = dtFechaFinal.Value.ToString("yyyyMMdd");
                        int codMetodoPago = (int)cmbMetodoPago.SelectedValue;

                        ventasFiltro.Nro_Doc = txtNroDoc.Text.Trim();
                        ventasFiltro.NombresCompletos = cliente;

                        ventasFiltro.FechaInicio = fechaInicio;
                        ventasFiltro.FechaFinal = fechaFinal;
                        ventasFiltro.CodMetodoPago = codMetodoPago;

                        VentasReportesDTO ventas = repoVentas.ReporteVentas(ventasFiltro);

                        if (ventas.data.Count == 0)
                        {
                            Alerta.Notificacion("No hay registros para generar el excel", MessageBoxIcon.Warning);
                            return;
                        }


                        //Nombre de Columnas
                        string[] columnas = { "COD. VENTA",
                                              "TIPO DE COMPROBANTE",
                                              "DNI",
                                              "CLIENTE", 
                                              "MÉTODO DE PAGO",
                                              "ESTADO",
                                              "FECHA CREACIÓN",
                                              "FECHA LIMITE DE PAGO",
                                              "IMPORTE TOTAL" };


                        result = ExcelUtil.GenerarReporteVentasXls(ventas.data, columnas , "ReporteVentas", fbd.SelectedPath.Trim());

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

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    DialogResult dialogResult = fbd.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {

                        string cliente = txtCliente.Text.Trim();
                        string fechaInicio = dtFechaInicio.Value.ToString("yyyyMMdd");
                        string fechaFinal = dtFechaFinal.Value.ToString("yyyyMMdd");
                        int codMetodoPago = (int)cmbMetodoPago.SelectedValue;

                        ventasFiltro.Nro_Doc = txtNroDoc.Text.Trim();
                        ventasFiltro.NombresCompletos = cliente;

                        ventasFiltro.FechaInicio = fechaInicio;
                        ventasFiltro.FechaFinal = fechaFinal;
                        ventasFiltro.CodMetodoPago = codMetodoPago;

                        VentasReportesDTO ventas = repoVentas.ReporteVentas(ventasFiltro);

                        if (ventas.data.Count == 0)
                        {
                            Alerta.Notificacion("No hay registros para generar el excel", MessageBoxIcon.Warning);
                            return;
                        }

                        ventasPDFDocument = new VentasPDFDocument(ventas);

                      
                        string nombreArchivo = "ReporteVentas" + DateTime.Now.Millisecond.ToString();
                        nombreArchivo = nombreArchivo + ".pdf";
                        ventasPDFDocument.GeneratePdf(fbd.SelectedPath.Trim() + "\\" +nombreArchivo);
                        
                        Alerta.Notificacion("Se genero el pdf en la ruta solicitada ", MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Ocurrio un error al generar el PDF : " + ex.Message, MessageBoxIcon.Error);
            }

        }
    }
}
