using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppBogedaTeo.Vistas
{ 
    public partial class frmMantCredito : Form
    {
        private static frmMantCredito _instance = null;
        private ClienteRepositorio<ClienteDTO> repoCliente;
        private MantPagoCreditoRepositorio repoMantPagoCredito;
        private BindingSource bsCliente;
        private BindingSource bsOrdenPedido;
        private ClienteBusDTO clienteFiltro;

        private string NroDoc = "";
        private int CodCliente = 0;
        private string Razon_Social = "";

        public frmMantCredito(Form form, string cadenaConexion)
        {
            InitializeComponent();

            repoCliente = new ClienteRepositorio<ClienteDTO>(cadenaConexion);
            bsCliente = new BindingSource();
            clienteFiltro = new ClienteBusDTO();
            repoMantPagoCredito = new MantPagoCreditoRepositorio(cadenaConexion);
            bsOrdenPedido = new BindingSource();

            BuscarCliente();
            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
            txtBusNroDoc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtNroDocMod.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtNroOPAdd.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtNroDocMod.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
        }


        public static frmMantCredito GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmMantCredito(form, cadenaConexion);
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;

            }
            else
                _instance.BringToFront();

            _instance.PanelBus();
            _instance.LimpiarCampos();

            return _instance;
        }


        private void LimpiarCampos()
        {
            txtBusNroDoc.Text = "";
            txtNroDocCrea.Text = "";
            txtNroDocMod.Text = "";
            txtRazonSocialMod.Text = "";
            txtNroOPAdd.Text = "";
            dtFechaLimiteAdd.Text = DateTime.Now.ToString("yyyy/MM/dd");
            NroDoc = "";
            CodCliente = 0;
            Razon_Social = "";
        }


        private void PanelBus()
        {
            panelBus.Visible = true;
            panelBus.Dock = DockStyle.Fill;
            panelCreacion.Visible = false;
            panelModificacion.Visible = false;
            panelAdicion.Visible = false;
        }

        private void PanelCreacion()
        {
            panelBus.Visible = false;
            panelCreacion.Visible = true;
            panelCreacion.Dock = DockStyle.Fill;
            panelModificacion.Visible = false;
            panelAdicion.Visible = false;
        }

        private void PanelModificacion()
        {
            panelBus.Visible = false;
            panelCreacion.Visible = false;
            panelModificacion.Visible = true;
            panelModificacion.Dock = DockStyle.Fill;
            panelAdicion.Visible = false;
        }

        private void PanelAdicion()
        {
            panelBus.Visible = false;
            panelCreacion.Visible = false;
            panelModificacion.Visible = false;
            panelAdicion.Visible = true;
            panelAdicion.Dock = DockStyle.Fill;
        }


        private void BuscarCliente()
        {
            try
            {
                clienteFiltro.Nro_Doc = txtBusNroDoc.Text.Trim();
                clienteFiltro.FlagTieneHistPagos = true;
                //Solo recurrentes
                clienteFiltro.CodEstadoCliente = 4;
                List<ClienteDTO> clientes = repoCliente.BuscarCliente(clienteFiltro);
                if (clientes.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    bsCliente.DataSource = null;
                    dgvClientes.DataSource = bsCliente;
                }
                   

                bsCliente.DataSource = clientes;
                dgvClientes.DataSource = bsCliente;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar cliente: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnCrearHPC_Click(object sender, EventArgs e)
        {
            PanelCreacion();
        }

        private void btnBuscarHPC_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnModificarHPC_Click(object sender, EventArgs e)
        {
            if (bsCliente != null && bsCliente.Count > 0)
            {
                try
                {
                    ClienteDTO item = (ClienteDTO)bsCliente.Current;

                    //Estado cliente Moroso
                    if (item.CodEstadoCliente == 3)
                    {
                        Alerta.Notificacion("No se puede agregar ordenes de pedido a un cliente moroso", MessageBoxIcon.Warning);
                        return;
                    }

                    PanelModificacion();

                    //Pintar datos de orden de pedido
                    txtNroDocMod.Text = item.Nro_Doc;
                    NroDoc = item.Nro_Doc;
                    CodCliente = item.CodCliente;
                    txtRazonSocialMod.Text = item.NombresCompletos;
                    Razon_Social= item.NombresCompletos;
                    List<OrdenPedido> ordenPedidos = repoMantPagoCredito.BuscarHistorialPagos(item.CodCliente);
                    bsOrdenPedido.DataSource = ordenPedidos;
                    dgvOrdenPedido.DataSource = bsOrdenPedido;

                }
                catch (Exception ex)
                {
                    Alerta.Notificacion("Error al seleccionar la orden de pedido:\n" + ex.Message, MessageBoxIcon.Error);
                }

            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelBus();
            LimpiarCampos();
        }

        private void btnAnadirOP_Click(object sender, EventArgs e)
        {
            PanelAdicion();
            txtNroOPAdd.Text = "";
            dtFechaLimiteAdd.Value = DateTime.Now;
        }

        private void btnSalirCrea_Click(object sender, EventArgs e)
        {
            PanelBus();
            LimpiarCampos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string NroDoc=txtNroDocCrea.Text;
                if (NroDoc.Length == 0) {
                    Alerta.Notificacion("El DNI es obligatorio", MessageBoxIcon.Warning);
                    return;
                }

                var response =repoMantPagoCredito.MantPagosAlCredito(NroDoc, 0, "",1);

                if(response.CodRes==0)
                {
                    Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Warning);
                    return;
                }

                Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Information);
                PanelBus();

                txtBusNroDoc.Text = NroDoc;
                BuscarCliente();
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al crear el historial:\n" + ex.Message, MessageBoxIcon.Error);
            }


        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            try
            {
                string msg = "";
                int NroOrden = Int32.TryParse(txtNroOPAdd.Text,out _) ? Convert.ToInt32(txtNroOPAdd.Text):0 ;
                if (NroOrden == 0)
                    msg += "*El Nro de orden de pedido es obligatorio\n";

                int comparacion=DateTime.Compare(dtFechaLimiteAdd.Value, DateTime.Now);
                //Si la fecha es menor o igual a la fecha actual saldra el siguente mensaje
                if (comparacion <= 0) 
                    msg += "*La fecha limite de pago no puede ser una fecha antes  o igual a la fecha actual";
                
                if (msg.Length > 0) {
                    Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                    return;
                }

                var response = repoMantPagoCredito.MantPagosAlCredito(NroDoc, NroOrden, dtFechaLimiteAdd.Value.ToString("yyyyMMdd"), 2);

                if (response.CodRes == 0)
                {
                    Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Warning);
                    return;
                }

                Alerta.Notificacion(response.MsgRespuesta, MessageBoxIcon.Information);
                PanelModificacion();

                //Actualiza grilla 
                txtNroDocMod.Text = NroDoc;
                txtRazonSocialMod.Text = Razon_Social;

                List<OrdenPedido> ordenPedidos = repoMantPagoCredito.BuscarHistorialPagos(CodCliente);
                bsOrdenPedido.DataSource = ordenPedidos;
                dgvOrdenPedido.DataSource = bsOrdenPedido;

            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al crear el historial:\n" + ex.Message, MessageBoxIcon.Error);
            }
        }

        private void btnSalirAdd_Click(object sender, EventArgs e)
        {
            PanelModificacion();

        }
    }
}
