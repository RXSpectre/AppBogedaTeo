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
    public partial class FrmIngresoSolCompra : Form
    {

        private static FrmIngresoSolCompra _instance = null;
        private int codEmpleado { get; set; } = 0;
        private int codProveedor { get; set; } = 0;


        private BindingSource bsSolCompra;
        private BindingSource bsDetSolCompra;
        private BindingSource bsComboBProveedores;


        private SolCompraRepositorio<SolCompraIngresoDTO> repoSolCompra;
        private ParametroRepositorio repoParametro;
        private List<Parametro> listBProveedores;
        private List<DetSolCompraDTO> listDetSolCompra;

        private SolCompraBuscaDTO solCompraFiltro;

        private int codDetalleSel = 0;
        private SolCompraIngresoDTO itemSel;

        public FrmIngresoSolCompra(Form form, string cadenaConexion)
        {
            InitializeComponent();

            bsSolCompra = new BindingSource();
            bsDetSolCompra = new BindingSource();
            bsComboBProveedores = new BindingSource();
            listBProveedores = new List<Parametro>();
            listDetSolCompra = new List<DetSolCompraDTO>();
            solCompraFiltro = new SolCompraBuscaDTO();
            itemSel = new SolCompraIngresoDTO();
           

            repoSolCompra = new SolCompraRepositorio<SolCompraIngresoDTO>(cadenaConexion);
            repoParametro = new ParametroRepositorio(cadenaConexion);


            CargarCombo("Proveedores", cmbBusProveedores, bsComboBProveedores, listBProveedores);
            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
            txtBusColSolCompra.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtImporteTotalPagSC.KeyPress += ValidacionesDeEventos.txtSoloDecimales_KeyPress;
            txtImporteTotalPagSC.Leave += ValidacionesDeEventos.txtSoloDecimales_Leave;
            txtSelCantProducto.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;


        }

        public static FrmIngresoSolCompra GetInstance(Form form, string cadenaConexion, int codEmpleado)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmIngresoSolCompra(form, cadenaConexion);

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
            txtImpTotalEsperadoSC.Text = "";
        
            txtBusColSolCompra.Text = "";


            bsSolCompra.DataSource = null;
            dgvSolCompra.DataSource = null;


            dgvDetSC.DataSource = null;
            txtCodSolCompraSC.Text = "";
            codProveedor = 0;
            txtImporteTotalPagSC.Text = "0";
            txtObsSC.Text = "";

            txtSelDscProducto.Text = "";
            txtSelCantProducto.Text = "";

            panelBus.Visible = true;
            panelBus.Dock = DockStyle.Fill;
            panelDetalle.Visible = false;
            //CargarCombo("Proveedores", cmbBusProveedores, bsComboBProveedores, listBProveedores);

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
                    itemSel = (SolCompraIngresoDTO)bsSolCompra.Current;

                    PanelMant();

                    //Pintar datos de orden de pedido
                    txtCodSolCompraSC.Text = itemSel.CodSolCompra.ToString();
                    codProveedor = itemSel.CodProveedor;
                    txtRUCSC.Text = itemSel.RucProveedor;
                    txtRazonSocialSC.Text = itemSel.DscProveedor;
                    txtImpTotalEsperadoSC.Text = itemSel.ImporteTotalEsperado.ToString();

                    listDetSolCompra = repoSolCompra.BuscarDetalleSolCompra(itemSel.CodSolCompra);
                    bsDetSolCompra.DataSource = listDetSolCompra;
                    dgvDetSC.DataSource = bsDetSolCompra;

                    CalcularImpTotalPagado();
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

        private void btnBuscarOP_Click(object sender, EventArgs e)
        {
            BuscarSolCompra();
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
                string fechaIni = dtBusFechaInicio.Value.ToString("yyyyMMdd");
                string fechaFin = dtBusFechaFinal.Value.ToString("yyyyMMdd");
              

                solCompraFiltro.CodSolCompra = codSolCompra;
                solCompraFiltro.CodProveedor = codProveedor;
                //Estado 1 -> Generado
                solCompraFiltro.CodEstadoSolCompra = 1;
                solCompraFiltro.fechaInicio = fechaIni;
                solCompraFiltro.fechaFin = fechaFin;

                List<SolCompraIngresoDTO> items = repoSolCompra.BuscarSolCompra(solCompraFiltro,out _);
                if (items.Count == 0)
                {
                    bsSolCompra.DataSource = null;
                    dgvSolCompra.DataSource = bsSolCompra;
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    return;
                }
                    
                bsSolCompra.DataSource = items;
                dgvSolCompra.DataSource = bsSolCompra;

            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar solicitudes de compra:\n" + ex.Message, MessageBoxIcon.Warning);
            }
        }



        private void MantSolCompra(int codEstadoSolCompra)
        
        {
            RespuestaDTO respuesta = new RespuestaDTO();

            int  codSolCompra = Int32.TryParse(txtCodSolCompraSC.Text.Trim(), out _) ? Convert.ToInt32(txtCodSolCompraSC.Text.Trim()) : 0;
            decimal importeTotalPagado = Decimal.TryParse(txtImporteTotalPagSC.Text.Trim(), out _) ? Convert.ToDecimal(txtImporteTotalPagSC.Text.Trim()) : 0;
            decimal importeTotalEsperado = Decimal.TryParse(txtImpTotalEsperadoSC.Text.Trim(), out _) ? Convert.ToDecimal(txtImpTotalEsperadoSC.Text.Trim()) : 0;
            string observacion = txtObsSC.Text.Trim();

            try
            {
                //Validaciones del negocio
                if(codSolCompra==0)
                    respuesta.MsgRespuesta += "*Debe haber seleccionado un código de solicitud de compra\n";

                if (codEmpleado == 0)
                    respuesta.MsgRespuesta += "*El autor que ha realizado la acción no ha sido enviado\n";

                if (codProveedor == 0)
                    respuesta.MsgRespuesta += "*El proveedor no se ha especificado\n";

                if (importeTotalEsperado == 0)
                    respuesta.MsgRespuesta = "*El importe total a pagar no puede ser 0\n";

                //2 -> Terminado
                if (codEstadoSolCompra == 2 &&  importeTotalPagado != importeTotalEsperado )
                    respuesta.MsgRespuesta += "*Los importes difieren, debe ser terminado con observaciones\n";

                //2 -> Terminado
                if (codEstadoSolCompra == 2 &&  !String.IsNullOrEmpty(observacion))
                    respuesta.MsgRespuesta += "*La acción que intentas realizar no acepta observaciones\n";


                //2 -> Terminado | 4 -> Terminado con observaciones 
                if ((codEstadoSolCompra == 2 || codEstadoSolCompra == 4) && importeTotalPagado == 0)
                    respuesta.MsgRespuesta += "*El importe total a pagar es obligatorio\n";


                //3 -> Anulado |  4 -> Terminado con observaciones 
                if ((codEstadoSolCompra == 3 || codEstadoSolCompra == 4) && String.IsNullOrWhiteSpace(observacion))
                    respuesta.MsgRespuesta += "*El campo observaciones es obligatorio para esta acción\n";

                if ((codEstadoSolCompra == 3 || codEstadoSolCompra == 4) && observacion.Length>300)
                    respuesta.MsgRespuesta += "*El campo observaciones ha superado el limite permitido de caracteres\n";


                if (!String.IsNullOrWhiteSpace(respuesta.MsgRespuesta)) {

                    Alerta.Notificacion(respuesta.MsgRespuesta, MessageBoxIcon.Warning);
                    return;
                }

                //Acción BD

                //Actualizar Cabecera
                respuesta = repoSolCompra.MantSolCompra(new SolCompra()
                {
                    CodSolCompra = codSolCompra,
                    CodProveedor = codProveedor,
                    CodEstadoSolCompra = codEstadoSolCompra,
                    ImporteTotalEsperado = importeTotalEsperado,
                    Observacion = observacion,
                    ImporteTotalPagado = importeTotalPagado,
                    CodEmpleadoModi = codEmpleado
                });

                if (respuesta.CodRes == 1)
                {
                    //Actualizar Detalle en caso lo requiera
                    foreach (var item in listDetSolCompra)
                    {
                        var res = repoSolCompra.ActualizarDetSolCompra(item);
                        if (res.CodRes != 1)
                            throw new Exception($"Ocurrio un error al actualizar un registro del detalle");
                    }
                    Alerta.Notificacion(respuesta.MsgRespuesta, MessageBoxIcon.Information);
                    LimpiarCampos();
                }   
                else
                    Alerta.Notificacion(respuesta.MsgRespuesta, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Error al realiza el mantenimiento de solicitud de compras :\n" + ex.Message, MessageBoxIcon.Error);
            }        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            MantSolCompra(2);
        }

        private void btnTerminadoObs_Click(object sender, EventArgs e)
        {
            MantSolCompra(4);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            MantSolCompra(3);
        }

        private void btnSelDetalle_Click(object sender, EventArgs e)
        {
            if (bsDetSolCompra != null && bsDetSolCompra.Count > 0)
            {
                try
                {
                    DetSolCompraDTO item = (DetSolCompraDTO)bsDetSolCompra.Current;

                    //Pintar datos de orden de pedido
                    codDetalleSel = item.CodDetSolCompra;
                    txtSelDscProducto.Text = item.DscProducto.ToString();
                    txtSelCantProducto.Text = item.Cantidad.ToString();

                }
                catch (Exception ex)
                {
                    Alerta.Notificacion("Error al seleccionar el detalle :\n" + ex.Message, MessageBoxIcon.Error);
                }

            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void btnActualizarDetalle_Click(object sender, EventArgs e)
        {
            string selCantProducto = txtSelCantProducto.Text;
            string selDscProducto = txtSelDscProducto.Text;
            //Validaciones
            string msg = string.Empty;

            if (String.IsNullOrEmpty(selDscProducto))
                msg += "*Tiene que seleccionar un registro del detalle\n";

            if (String.IsNullOrEmpty(selCantProducto))
                msg += "*Tiene que indicar una cantidad\n";

            if (!Int32.TryParse(selCantProducto, out _))
                msg += "*El valor debe ser númerico\n";
            

            if (msg.Length > 0)
            {
                Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                return;
            }


            var rpta = Alerta.Confirmacion("¿Está seguro que deseas cambiar la cantidad del registro seleccionado?");
            if (rpta)
            {
                
                   int  indice = listDetSolCompra.FindIndex(x => x.CodDetSolCompra == codDetalleSel);
                   DetSolCompraDTO item = listDetSolCompra[indice];

                    if (indice >= 0)
                    {
                            item.Cantidad = Convert.ToInt32(selCantProducto);
                            item.ValorCompra = item.Cantidad * item.PrecioCompra;
                            //Actualizar cantidad en la lista
                            listDetSolCompra[indice] = item;

                            bsDetSolCompra.DataSource = listDetSolCompra;
                            dgvDetSC.DataSource = null;
                            dgvDetSC.DataSource = bsDetSolCompra;
                    }
                    CalcularImpTotalPagado();
                    Alerta.Notificacion("Se actualizo el detalle", MessageBoxIcon.Information);

                   txtSelDscProducto.Text = "";
                   txtSelCantProducto.Text = "";
            }
        }


        private void CalcularImpTotalPagado() 
        {
            var importeTotalPagado =listDetSolCompra.Sum(p => p.ValorCompra);
            txtImporteTotalPagSC.Text = importeTotalPagado.ToString();
        }
    }
}
