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
    public partial class frmMantEmpleado : Form
    {
        private static frmMantEmpleado _instance = null;
        private ParametroRepositorio repoParametro;
        private EmpleadoRepositorio repoEmpleado;

        private BindingSource bsEmpleado;
        private BindingSource bsRoles;
        private List<Parametro> roles;

      

        public static frmMantEmpleado GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmMantEmpleado(form, cadenaConexion);

                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
                _instance.BringToFront();

            _instance.PanelPrincipal();

            return _instance;
        }

        private frmMantEmpleado(Form form, string cadenaConexion)
        {
            InitializeComponent();
            bsEmpleado = new BindingSource();
            bsRoles = new BindingSource();
            repoParametro = new ParametroRepositorio(cadenaConexion);
            repoEmpleado = new EmpleadoRepositorio(cadenaConexion);
            CargarCombo();
            BuscarUsu();
            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
            txtNomComBus.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            txtDNI.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            txtNomCom.KeyPress += ValidacionesDeEventos.txtSoloLetras_KeyPress;
            
        }

        private void PanelPrincipal()
        {
            panelBusUsu.Visible = true;
            panelBusUsu.Dock = DockStyle.Fill;
            panelMantUsu.Visible = false;
            LimpiarCampos();
        }

        private void PanelMant()
        {
            panelBusUsu.Visible = false;
            panelMantUsu.Visible = true;

        }

        private void LimpiarCampos()
        {
            //Panel Busqueda
            txtNomComBus.Text = "";
           
            //Panel Mantenimiento
            txtDNI.Text = "";
            txtNomCom.Text = "";
            txtCorreo.Text = "";
            txtContra.Text = "";

           

            cmbRol.SelectedValue = roles.FirstOrDefault().Codigo;
        }

        private void CargarCombo(int fmod=0)
        {
            Parametro prm = new Parametro();
            prm.CodPrm = "Rol";
            prm.Fmod = fmod;
            try
            {
                roles = repoParametro.ObtenerParametro(prm);

                bsRoles.DataSource = roles;
                cmbRol.DataSource = bsRoles;
                cmbRol.DisplayMember = "Descripcion";
                cmbRol.ValueMember = "Codigo";

                cmbRol.SelectedValue = roles.FirstOrDefault().Codigo;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Ocurrio un error al cargar los roles: " + ex.Message, MessageBoxIcon.Warning);
            }
        }


        private void BuscarUsu()
        {
            try
            {
                List<Empleado> empleados = repoEmpleado.ObtenerEmpleado("",txtNomComBus.Text, 2);

                if (empleados.Count == 0)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Information);
                    bsEmpleado.DataSource = null;
                    dgvUsuLista.DataSource = bsEmpleado;
                }

                bsEmpleado.DataSource = empleados;
                dgvUsuLista.DataSource = bsEmpleado;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al buscar empleado: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void MantUsu(string fMant)
        {
            string dni = txtDNI.Text.Trim();
            string nomComple = txtNomCom.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contra = txtContra.Text.Trim();

            string msg = "";

            if (String.IsNullOrEmpty(dni))
                msg = "*El DNI es obligatorio \n";

            if (String.IsNullOrEmpty(nomComple))
                msg = "*Los nombres completos es obligatorio \n";

            if (String.IsNullOrEmpty(correo))
                msg += "*El nombre de correo es obligatorio \n";

            if (!ValidarEmail(correo))
                msg += "*El formato de correo no es válido \n";

            if (String.IsNullOrEmpty(contra))
                msg += "*La contraseña es obligatorio \n";

            if (contra.Length < 8)
                msg += "*La contraseña debe ser mayor a 7 dígitos \n";


            Empleado empleadoBus = repoEmpleado.ObtenerEmpleado(dni,"", 1).FirstOrDefault();


            if (empleadoBus != null && fMant == "R")
                msg += "*Ya existe un usuario con ese nombre\n";
            if (empleadoBus == null && fMant == "A")
                msg += "*El usuario que desea actualizar no existe\n";


            if (msg.Length > 0)
            {
                Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                return;
            }

            Empleado empleado = new Empleado();

            empleado.CodEmpleado = empleadoBus != null ? empleadoBus.CodEmpleado : 0;
            empleado.DNI = dni;
            empleado.NombreCompletos = nomComple;
            empleado.Contra = BCrypt.Net.BCrypt.HashPassword(contra);
            empleado.Correo = correo;
            empleado.CodRol = ((Parametro)bsRoles.Current).Codigo;
            empleado.FlagMant = fMant == "R" ? 0 : 1;

            try
            {
                RespuestaDTO res = repoEmpleado.MantEmpleado(empleado);
                if (res.CodRes == 1)
                {
                    Alerta.Notificacion(res.MsgRespuesta, MessageBoxIcon.Information);
                    PanelPrincipal();
                    LimpiarCampos();
                    BuscarUsu();
                }

                if (res.CodRes == 0)
                {
                    Alerta.Notificacion(res.MsgRespuesta, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Error en el mantenimiento de usuario : " + ex.Message, MessageBoxIcon.Warning);
            }

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsu();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (bsEmpleado != null)
            {
                PanelMant();
                btnActualizar.Visible = true;
                btnCrearCuenta.Visible = false;

                Empleado empleado = (Empleado)bsEmpleado.Current;

                txtDNI.Text = empleado.DNI;
                txtCorreo.Text = empleado.Correo;
                txtNomCom.Text = empleado.NombreCompletos;
                cmbRol.SelectedValue = empleado.CodRol;
                lblMant.Text = "Actualizar Empleado";
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void btnCrearUsuInterno_Click(object sender, EventArgs e)
        {
            PanelMant();
            CargarCombo(1);
            LimpiarCampos();
            lblMant.Text = "Crear Empleado";
            btnActualizar.Visible = false;
            btnCrearCuenta.Visible = true;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            MantUsu("R");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MantUsu("A");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal();
            LimpiarCampos();
        }
    }
}
