using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppBogedaTeo.Vistas
{
    public partial class frmLogin : Form
    {
        private static frmLogin form = null;
        private readonly EmpleadoRepositorio repo;
        private string cadenaConexion;

        public static frmLogin GetInstance(string cadenaConexion)
        {
            if (form == null || form.IsDisposed)
                form = new frmLogin(cadenaConexion);
            else
                form.BringToFront();

            return form;
        }


        private frmLogin(string cadenaConexion)
        {
            InitializeComponent();
            this.cadenaConexion = cadenaConexion;
            repo = new EmpleadoRepositorio(this.cadenaConexion);
            ValidacionesEventos();
        }



        private void ValidacionesEventos()
        {
            txtDNI.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
        }


        private void ValidarUsuario()
        {
            string dni = txtDNI.Text.Trim();
            string contraUsu = txtContra.Text.Trim();

            if (String.IsNullOrEmpty(dni) || String.IsNullOrEmpty(contraUsu))
            {
                Alerta.Notificacion("Todos los campos son obligatorios", MessageBoxIcon.Warning);
                return;
            }

            if (contraUsu.Length <= 7)
            {
                Alerta.Notificacion("La contraseña debe ser mayor a 7 dígitos", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Empleado usuario = repo.ObtenerEmpleado(dni,"", 1).FirstOrDefault();

                if (usuario == null)
                {
                    Alerta.Notificacion("El empleado no existe", MessageBoxIcon.Warning);
                    return;
                }

                if (!BCrypt.Net.BCrypt.Verify(contraUsu, usuario.Contra))
                {
                    Alerta.Notificacion("La contraseña no es correcta", MessageBoxIcon.Warning);
                    return;
                }

                Alerta.Notificacion("Credenciales Validadas", MessageBoxIcon.Information);

                LimpiarCampos();

                usuario.UltFechaIngreso = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

                frmPrin.GetInstance(usuario, cadenaConexion).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Alerta.Notificacion($"Ocurrio un error al validar credenciales : {ex.Message}", MessageBoxIcon.Warning);
            }


        }

        private void LimpiarCampos()
        {
            txtDNI.Text = "";
            txtContra.Text = "";
        }

        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

        private void lblOlvidoContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCampos();
            frmRestaurarContra.GetInstance(cadenaConexion).Show();
            this.Hide();
        }
    }
}
