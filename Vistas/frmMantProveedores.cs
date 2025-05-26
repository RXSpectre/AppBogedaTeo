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
    public partial class frmMantProveedores : Form
    {
        private static frmMantProveedores _instance = null;
        private ProveedorRepositorio repoProveedor;
        private ParametroRepositorio repoParametro;
        private BindingSource bsProveedores;

        private BindingSource bsCmbEstProveedorBus;
        private List<Parametro> lstEstadosProveedorBus;

        private BindingSource bsCmbEstProveedorMant;
        private List<Parametro> lstEstadosProveedorMant;

        private int codProveedorSel = 0;

        public frmMantProveedores(Form form, string cadenaConexion)
        {
            InitializeComponent();

            bsProveedores = new BindingSource();
            bsCmbEstProveedorBus = new BindingSource();

            lstEstadosProveedorBus = new List<Parametro>();
            bsCmbEstProveedorMant = new BindingSource();
            lstEstadosProveedorMant = new List<Parametro>();

            repoProveedor = new ProveedorRepositorio(cadenaConexion);
            repoParametro = new ParametroRepositorio(cadenaConexion);

            //Cargar combo estados de clientes
            CargarCombo("EstadoProveedor", cmbEstadoBus, bsCmbEstProveedorBus, lstEstadosProveedorBus, 0);

            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
            txtMantRuc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtMantTelefono.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtBusRuc.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtBusRazonSocial.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            txtMantRazonSocial.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
        }

        private void CargarCombo(string CodPrm, ComboBox cmb, BindingSource bs, List<Parametro> parametros, int Fmod = 0)
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

        public static frmMantProveedores GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmMantProveedores(form, cadenaConexion);

                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
                _instance.BringToFront();

            _instance.PanelPrincipal();

            return _instance;
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

            CargarCombo("EstadoProveedor", cmbEstadoMant, bsCmbEstProveedorMant, lstEstadosProveedorMant, 1);
            panelMantCliente.Visible = false;
            panelMantCliente.Visible = true;

        }

        private void LimpiarCampos()
        {
            //Panel Busqueda
            txtBusRuc.Text = "";
            txtBusRazonSocial.Text = "";

            //Panel Mantenimiento
            txtMantCorreo.Text = "";
            txtMantTelefono.Text = "";
            txtMantRuc.Text = "";
            txtMantRazonSocial.Text = "";
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            BuscarProveedor();
        }


        private void BuscarProveedor()
        {
            try
            {
                int codEstadoProveedor = ((Parametro)bsCmbEstProveedorBus.Current).Codigo;

                List<Proveedor> proveedor = repoProveedor.BuscarProveedor(txtBusRuc.Text.Trim(), txtBusRazonSocial.Text.Trim(), codEstadoProveedor);

                if (proveedor.Count == 0) {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    bsProveedores.DataSource = null;
                    dgvProveedores.DataSource = bsProveedores;
                    return;
                }

                bsProveedores.DataSource = proveedor;
                dgvProveedores.DataSource = bsProveedores;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar proveedor: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (bsProveedores != null && bsProveedores.Count > 0)
            {
                PanelMant();
                btnActualizar.Visible = true;
                btnCrearCliente.Visible = false;

                Proveedor proveedor = (Proveedor)bsProveedores.Current;
                codProveedorSel = proveedor.CodProveedor;
                txtMantRuc.Enabled = false;
                //Establecemos los datos del panel de mantenimiento
                txtMantRazonSocial.Text = proveedor.RazonSocial;
                txtMantRuc.Text = proveedor.RucProveedor;
                txtMantTelefono.Text = proveedor.NroTelContacto;
                txtMantCorreo.Text = proveedor.CorreoProveedor;

                cmbEstadoMant.SelectedValue = proveedor.CodEstadoProveedor;

                lblMant.Text = "Actualizar Proveedor";
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PanelMant();

            txtMantRuc.Enabled = true;
            LimpiarCampos();
            lblMant.Text = "Crear Proveedor";

            btnActualizar.Visible = false;
            btnCrearCliente.Visible = true;
        }

        private void MantProveedor(string fMant)
        {
            string ruc = txtMantRuc.Text.Trim();
            string razonSocial = txtMantRazonSocial.Text.Trim();
            string telefono = txtMantTelefono.Text.Trim();
            string correo = txtMantCorreo.Text.Trim();


            string msg = "";


            //Validar campos
            if (String.IsNullOrEmpty(ruc))
                msg = "*El campo ruc es obligatorio \n";

            if (String.IsNullOrEmpty(razonSocial))
                msg += "*El campo razón social  es obligatorio \n";

            if (String.IsNullOrEmpty(telefono))
                msg += "*El campo Nro. teléfono es obligatorio \n";

            if (String.IsNullOrEmpty(correo))
                msg += "*El campo correo es obligatorio \n";


            if (msg.Length > 0)
            {
                Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                return;
            }

            Proveedor proveedor = new Proveedor();


            proveedor.CodProveedor = fMant == "R" ? 0 : codProveedorSel;
            proveedor.RucProveedor = ruc;
            proveedor.RazonSocial = razonSocial;
            proveedor.NroTelContacto = telefono;
            proveedor.CorreoProveedor = correo;
            proveedor.CodEstadoProveedor = ((Parametro)bsCmbEstProveedorMant.Current).Codigo;

            try
            {
                RespuestaDTO res = repoProveedor.MantProveedor(proveedor);

                if (res.CodRes == 1)
                {
                    Alerta.Notificacion(res.MsgRespuesta, MessageBoxIcon.Information);
                    PanelPrincipal();
                    LimpiarCampos();
                    BuscarProveedor();
                }
                else
                {
                    Alerta.Notificacion(res.MsgRespuesta, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Error en el mantenimiento de proveedor : " + ex.Message, MessageBoxIcon.Warning);
            }

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            MantProveedor("R");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MantProveedor("A");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal();
            LimpiarCampos();
        }
    }
}
