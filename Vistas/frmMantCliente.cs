using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AppBogedaTeo.Vistas
{
    public partial class frmMantCliente : Form
    {

        private static frmMantCliente _instance = null;
        private ClienteBusDTO clienteFiltro;
        private BindingSource bsCliente;
        private ParametroRepositorio repoParametro;
        private ClienteRepositorio<ClienteDTO> repoCliente;
        private List<Parametro> estadosCliente;
        private List<Parametro> estadosBusCliente;
        private List<Parametro> tipoDoc;
        private BindingSource bsComboEstadoCliente;
        private BindingSource bsComboBusEstadoCliente;
        //private BindingSource bsComboTipoDoc;

        public static frmMantCliente GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmMantCliente(form, cadenaConexion);

                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
                _instance.BringToFront();

            _instance.PanelPrincipal();
            _instance.LimpiarCampos();

            return _instance;
        }

        private void ValidacionesEventos() 
        {
            txtBusNroDoc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtBusNombres.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            txtBusApellidos.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;

            txtNroDoc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtNombres.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            txtApellidos.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;

        }

        private void PanelPrincipal()
        {
            panelBusCliente.Visible = true;
            panelBusCliente.Dock = DockStyle.Fill;
            panelMantCliente.Visible = false;
            LimpiarCampos();
        }

        private void PanelMant()
        {
            panelMantCliente.Visible = false;
            panelMantCliente.Visible = true;

            //Cargar combo estados de clientes
            CargarCombo("EstadoCliente", cmbEstadoMant, bsComboEstadoCliente, estadosCliente, 1);
            //Carga combo tipos de documentos
            //CargarCombo("TipoDocumento", cmbTipoDoc, bsComboTipoDoc, tipoDoc, 1);

        }


        private void LimpiarCampos()
        {
            //Panel Busqueda
            txtBusNroDoc.Text = "";
            txtBusNombres.Text = "";
            txtBusApellidos.Text = "";

            //Panel Mantenimiento
            txtNroDoc.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";

        }


        private void CargarCombo(string CodPrm , ComboBox cmb , BindingSource bs , List<Parametro> parametros, int Fmod=0)
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


        public frmMantCliente(Form form, string cadenaConexion)
        {
            InitializeComponent();
           
            bsComboEstadoCliente = new BindingSource();
            //bsComboTipoDoc = new BindingSource();
            bsComboBusEstadoCliente = new BindingSource();
            bsCliente = new BindingSource();

            repoParametro = new ParametroRepositorio(cadenaConexion);
            repoCliente = new ClienteRepositorio<ClienteDTO>(cadenaConexion);
            clienteFiltro = new ClienteBusDTO();

            tipoDoc = new List<Parametro>();
            estadosCliente = new List<Parametro>();
            estadosBusCliente = new List<Parametro>();

            //Cargar combo estados de clientes de búsqueda
            CargarCombo("EstadoCliente", cmbBusEstado, bsComboBusEstadoCliente, estadosBusCliente);

            //Cargar combo estados de clientes
            CargarCombo("EstadoCliente", cmbEstadoMant, bsComboEstadoCliente, estadosCliente);
            //Carga combo tipos de documentos
            //CargarCombo("TipoDocumento", cmbTipoDoc, bsComboTipoDoc, tipoDoc);

            BuscarCliente();

            ValidacionesEventos();


        }


        private void BuscarCliente()
        {
            try
            {
                clienteFiltro.Nro_Doc = txtBusNroDoc.Text.Trim();
                clienteFiltro.Nombres = txtBusNombres.Text.Trim();
                clienteFiltro.Apellidos = txtBusApellidos.Text.Trim();
                clienteFiltro.CodEstadoCliente = (int)cmbBusEstado.SelectedValue;
                dgvClientes.DataSource = null;

                if (clienteFiltro.Nro_Doc.Length > 0 && clienteFiltro.Nro_Doc.Length < 8)
                {
                    Alerta.Notificacion("Ingrese un DNI válido", MessageBoxIcon.Information);
                    return;
                }

                List<ClienteDTO> empleados = repoCliente.BuscarCliente(clienteFiltro);

                if (empleados.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    return;
                }
                    
                bsCliente.DataSource = empleados;
                dgvClientes.DataSource = bsCliente;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar cliente: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PanelMant();
           

            LimpiarCampos();
            txtNroDoc.Enabled = true;
            lblMant.Text = "Crear Cliente";
            btnActualizar.Visible = false;
            btnCrearCliente.Visible = true;
            cmbEstadoMant.Enabled = false;
            //cmbTipoDoc.Enabled = true;

            txtNroDoc.ReadOnly = false;
           
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (bsCliente != null && bsCliente.Count>0)
            {
                PanelMant();
                btnActualizar.Visible = true;
                btnCrearCliente.Visible = false;

                ClienteDTO cliente = (ClienteDTO)bsCliente.Current;


                txtNroDoc.Text = cliente.Nro_Doc;
                txtNroDoc.Enabled = false;


                txtNombres.Text = cliente.Nombres;
                txtApellidos.Text = cliente.Apellidos;
                txtCorreo.Text = cliente.Correo;

                //cmbTipoDoc.SelectedValue = cliente.CodTipoDocumento;
                //cmbTipoDoc.Enabled = false;
                    

                cmbEstadoMant.SelectedValue = cliente.CodEstadoCliente;
                cmbEstadoMant.Enabled = true;

                lblMant.Text = "Actualizar Cliente";
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MantUsu("A");
        }


        private void MantUsu(string fMant)
        {
            string nroDoc = txtNroDoc.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string correo = txtCorreo.Text.Trim();


            string msg = "";

            if (String.IsNullOrEmpty(nroDoc))
                msg = "*El DNI es obligatorio \n";

            if (String.IsNullOrEmpty(nombres))
                msg += "*Los nombres  son obligatorio \n";

            if (String.IsNullOrEmpty(apellidos))
                msg += "*Los apellidos son obligatorio \n";

            if (String.IsNullOrEmpty(correo))
                msg += "*El correo  es obligatorio \n";

            if (!ValidarEmail(correo))
                msg += "*El formato de correo no es válido \n";


            //Buscar para actualizar
            ClienteDTO clienteBuscado = repoCliente.BuscarCliente(new ClienteBusDTO() { Nro_Doc= nroDoc , FMant='A' }).FirstOrDefault();


            if (clienteBuscado != null && fMant == "R")
                msg += "*Ya existe un cliente con ese DNI\n";
            if (clienteBuscado == null && fMant == "A")
                msg += "*El cliente que desea actualizar no existe\n";

            

            if (msg.Length > 0)
            {
                Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = new Cliente();

            cliente.CodCliente = clienteBuscado != null ? clienteBuscado.CodCliente : 0;
            cliente.Nro_Doc = nroDoc;
            cliente.Nombres = nombres;
            cliente.Apellidos = apellidos;
            cliente.Correo = correo;
                
            //cliente.CodTipoDocumento = ((Parametro)bsComboTipoDoc.Current).Codigo;
            cliente.CodTipoDocumento = 1;
            cliente.CodEstadoCliente = ((Parametro)bsComboEstadoCliente.Current).Codigo;
            cliente.Fmant = fMant == "R" ? 0 : 1;

            try
            {
                RespuestaDTO res = repoCliente.MantCliente(cliente);

                if (res.CodRes == 1)
                {
                    Alerta.Notificacion(res.MsgRespuesta, MessageBoxIcon.Information);
                    PanelPrincipal();
                    LimpiarCampos();
                    BuscarCliente();
                }

            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Error en el mantenimiento de cliente : " + ex.Message, MessageBoxIcon.Warning);
            }

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            MantUsu("R");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private bool ValidarEmail(string email)
        {
            String expresion;
            bool resultado = false;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                    resultado = true;
                else
                    resultado = false;
            }

            return resultado;
        }
    }
}
