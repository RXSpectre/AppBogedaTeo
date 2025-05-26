using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace AppBogedaTeo
{
    public partial class frmMantParam : Form
    {
        private static frmMantParam _instance = null;
        private RepoParametro repoParametro;
        private BindingSource bs;

        public static frmMantParam GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmMantParam(form, cadenaConexion);
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
                _instance.BringToFront();

            _instance.PanelPrincipal();

            return _instance;
        }

        private frmMantParam(Form form, string cadenaConexion)
        {
            InitializeComponent();
            PanelPrincipal();

            repoParametro = new RepoParametro(cadenaConexion);

            bs = new BindingSource();

            BuscarParam();
        }



        private void BuscarParam()
        {
            Parametro prm = new Parametro();
            prm.CodPrm = txtCodPrmBus.Text;
            prm.CodIden = int.TryParse(txtCodIdenBus.Text, out _) ? Convert.ToInt32(txtCodIdenBus.Text) : 0;
            prm.Valor1 = txtValor1Bus.Text;
            prm.Valor2 = txtValor2Bus.Text;
            prm.Habilitado = chkHabilBus.Checked ? "1" : "0";

            try
            {
                List<Parametro> prms = repoParametro.ObtenerParametro(prm);
                bs.DataSource = prms;
                dgvParametro.DataSource = bs;
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Ocurrio un error al listar los parametros: " + ex.Message, MessageBoxIcon.Warning);
            }


        }

     

        private void PanelPrincipal()
        {
            panelBus.Visible = true;
            panelBus.Dock = DockStyle.Fill;
            panelMantParam.Visible = false;
            LimpiarCampos();
        }

        private void PanelMant()
        {
            panelBus.Visible = false;
            panelMantParam.Visible = true;
        }


        private void LimpiarCampos()
        {
            //Panel
            txtCodPrmBus.Text = "";
            txtCodIdenBus.Text = "";
            txtValor1Bus.Text = "";
            txtValor2Bus.Text = "";
            chkHabilBus.Checked = true;
            //Panel Mantenimiento
            txtCodPrmMant.Text = "";
            txtCodIdenMant.Text = "0";
            txtValor1Mant.Text = "";
            txtValor2Mant.Text = "";
            chkHabilMant.Checked = true;
        }




   

       


        private void MantParam(string fMant)
        {
            string msg = string.Empty;

            if (String.IsNullOrEmpty(txtCodPrmMant.Text))
            {
                msg = "*El código parametro es obligatorio \n";
            }

            if (String.IsNullOrEmpty(txtCodIdenMant.Text))
            {
                msg += "*El código identificador es obligatorio \n";
            }

            if (String.IsNullOrEmpty(txtValor1Mant.Text))
            {
                msg += "*El valor 1 es obligatorio \n";
            }

            if (msg.Length > 0)
            {
                Alerta.Notificacion(msg, MessageBoxIcon.Warning);
                return;
            }

            Parametro prm = new Parametro();
            prm.CodPrm = txtCodPrmMant.Text;
            prm.CodIden = int.TryParse(txtCodIdenMant.Text, out _) ? Convert.ToInt32(txtCodIdenMant.Text) : 0;
            prm.Valor1 = txtValor1Mant.Text;
            prm.Valor2 = txtValor2Mant.Text;


            if (fMant == "R")
                prm.CodIden = 0;

            if (fMant == "A")
                prm.Habilitado = chkHabilMant.Checked ? "1" : "0";

            try
            {
                RespuestaDTO res = repoParametro.MantParam(prm);
                if (res.CodRes == 1)
                {
                    Alerta.Notificacion(res.MsgRespuesta, MessageBoxIcon.Information);
                    LimpiarCampos();
                    BuscarParam();
                    PanelPrincipal();
                }
            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Error al realizar el mantenimiento de parametro: " + ex.Message, MessageBoxIcon.Information);
            }
        }

    
     

     

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            BuscarParam();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PanelMant();
            LimpiarCampos();

            lblMantParam.Text = "Registrar Parametro";

            panelChkHabMant.Visible = false;

            txtCodPrmMant.ReadOnly = false;
            txtCodIdenMant.ReadOnly = true;
            btnActualizar.Visible = false;
            btnRegistrar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bs != null)
            {
                LimpiarCampos();
                Parametro prm = (Parametro)bs.Current;

                panelChkHabMant.Visible = true;


                txtCodPrmMant.ReadOnly = true;
                txtCodIdenMant.ReadOnly = true;
                btnActualizar.Visible = true;
                btnRegistrar.Visible = false;

                txtCodPrmMant.Text = prm.CodPrm;
                txtCodIdenMant.Text = prm.CodIden.ToString();
                txtValor1Mant.Text = prm.Valor1;
                txtValor2Mant.Text = prm.Valor2;
                chkHabilMant.Checked = prm.Habilitado == "1" ? true : false;

                lblMantParam.Text = "Actualizar Parametro";

                PanelMant();
            }
            else
            {
                Alerta.Notificacion("¡No hay registros seleccionados!", MessageBoxIcon.Warning);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MantParam("R");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MantParam("A");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal();
        }
    }
}
