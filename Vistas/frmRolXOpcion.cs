using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppBogedaTeo.Vistas
{
    public partial class frmRolXOpcion : Form
    {

        private static frmRolXOpcion _instance = null;
        private BindingSource bs;
        private frmPrin fPrin;
        private readonly RolXOpcionRepositorio repo;
       
        private int codRolSel = 0;


        public static frmRolXOpcion GetInstance(Form form, string cadenaConexion)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new frmRolXOpcion(form, cadenaConexion);
                _instance.MdiParent = form;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
                _instance.BringToFront();

            _instance.PanelPrincipal();
            _instance.BuscarRol();

            return _instance;
        }


        private frmRolXOpcion(Form form, string cadenaConexion)
        {
            InitializeComponent();
            PanelPrincipal();

            this.repo = new RolXOpcionRepositorio(cadenaConexion);
          
            bs = new BindingSource();
            fPrin = (frmPrin)form;

            //BuscarPerfil();
        }


        private void PanelPrincipal()
        {
            txtNomRolMant.Text = "";
            panelBusRol.Visible = true;
            panelBusRol.Dock = DockStyle.Fill;
            panelMantRol.Visible = false;
            codRolSel = 0;
        }

        private void BuscarRol()
        {
            Parametro prm = new Parametro();
            prm.CodPrm = "Rol";
            prm.Descripcion = txtRolBus.Text.Trim();
            prm.Habilitado = "1";
            prm.Fmod = 1;

            try
            {
                List<ListarRolesDTO> listaPrm = repo.ListarRoles(prm);
                if (listaPrm == null)
                {
                    Alerta.Notificacion("No hay registros", MessageBoxIcon.Warning);
                    return;
                }

                bs.DataSource = listaPrm;
                dgvPerfil.DataSource = bs;
            }
            catch (Exception ex)
            {

                Alerta.Notificacion("Error al buscar perfiles: " + ex.Message, MessageBoxIcon.Warning);
            }

        }


        private void MostrarMant()
        {
            panelBusRol.Visible = false;
            panelMantRol.Visible = true;
        }



        private void ConstruirListBox(ListBox list, List<OpcionesDTO> opciones)
        {
            list.Items.Clear();
            if (opciones.Count > 0)
            {
                foreach (var opc in opciones)
                    list.Items.Add(opc.ToString());
            }
        }

      
        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            BuscarRol();
        }

        private void btnSeleccionarRol_Click(object sender, EventArgs e)
        {
            ListarRolesDTO prm = (ListarRolesDTO)bs.Current;

            if (prm != null)
            {
                txtNomRolMant.Text = prm.Descripcion;
                codRolSel = prm.Codigo;
                try
                {
                    //Listar Todas las 
                    RolvsOpcionesDTO rolvsOpciones = repo.RolvsOpciones(codRolSel);

                    //Pintar opciones habilitadas
                    ConstruirListBox(listBoxHabi, rolvsOpciones.opcHabilitadas);
                    //pintar opciones deshabilitadas
                    ConstruirListBox(listBoxDesHabi, rolvsOpciones.opcDeshabilitadas);

                    MostrarMant();

                }
                catch (Exception ex)
                {
                    Alerta.Notificacion("Ocurrio un error al seleccionar el registro: " + ex.Message, MessageBoxIcon.Warning);
                    PanelPrincipal();
                }
            }
            else
            {
                Alerta.Notificacion("No hay registros seleccionados", MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarOpc_Click(object sender, EventArgs e)
        {
            if (listBoxHabi.Items.Count == 0)
            {
                Alerta.Notificacion("No hay opciones para agregar", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RespuestaDTO respuesta = null;
                repo.EliminarRolConOpciones(codRolSel);

                foreach (var po in listBoxHabi.Items)
                {
                    int codOpcion = Convert.ToInt32(po.ToString().Split('-')[0].Trim());

                    respuesta = repo.MantRolXOpcion(new RolXOpcion()
                    {
                        CodOpcion = codOpcion,
                        CodRol = codRolSel
                    });
                }

                if (respuesta.CodRes == 1)
                {
                    Alerta.Notificacion(respuesta.MsgRespuesta, MessageBoxIcon.Information);
                    PanelPrincipal();
                    fPrin.PintarOpcionesPorPerfil();
                }

            }
            catch (Exception ex)
            {
                Alerta.Notificacion("Ocurrio un error al agregar las opciones al perfil: " + ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal();
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            if (listBoxDesHabi.SelectedItem != null)
            {
                string nomOpcion = listBoxDesHabi.SelectedItem.ToString();
                listBoxHabi.Items.Add(nomOpcion);

                listBoxDesHabi.Items.RemoveAt(listBoxDesHabi.SelectedIndex);
            }
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            if (listBoxHabi.SelectedItem != null)
            {
                string nomOpcion = listBoxHabi.SelectedItem.ToString();
                listBoxDesHabi.Items.Add(nomOpcion);
                listBoxHabi.Items.RemoveAt(listBoxHabi.SelectedIndex);
            }
        }
    }
}
