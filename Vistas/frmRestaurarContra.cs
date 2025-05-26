using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppBogedaTeo.Vistas
{
    public partial class frmRestaurarContra : Form
    {

        private static frmRestaurarContra instance = null;
        //private string conexion = "";
        private EmpleadoRepositorio repo;

        private int codVerificacion = 0;
        private string DNI_Empleado = "";
        private string cadenaConexion = "";


        //Objetos a usar dentro del login

        public static frmRestaurarContra GetInstance(string cadenaConexion)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmRestaurarContra(cadenaConexion);
            }
            else
            {
                instance.BringToFront();
            }

            return instance;
        }


        private frmRestaurarContra(string cadenaConexion)
        {
            InitializeComponent();
            this.cadenaConexion = cadenaConexion;
            repo = new EmpleadoRepositorio(cadenaConexion);
            ValidacionesEventos();
        }

        private void ValidacionesEventos()
        {
            txtDNI.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
            txtCodVeri.KeyPress += ValidacionesDeEventos.txtSoloNumeros_KeyPress;
        }




        private void Volver()
        {
            this.Hide();
            frmLogin.GetInstance(cadenaConexion).Show();
        }

        private void LimpiarCampos()
        {
            txtContra.Text = "";
            txtConfirmContra.Text = "";
            txtDNI.Text = "";
            txtCodVeri.Text = "";
        }

     
        private void RestaurarContraseña()
        {
            string dni = txtDNI.Text.Trim();
            string contra = txtContra.Text.Trim();
            string contraConfirm = txtConfirmContra.Text.Trim();

            if (String.IsNullOrEmpty(dni))
            {
                Alerta.Notificacion("El DNI es obligatorio", MessageBoxIcon.Warning);
                return;
            }

            Empleado empleado = repo.ObtenerEmpleado(dni, "", 1).FirstOrDefault();

            if (empleado == null)
            {
                Alerta.Notificacion("DNI no existe", MessageBoxIcon.Warning);
                return;
            }

            if (contra.Length <= 7)
            {
                Alerta.Notificacion("La contraseña debe ser mayor a 7 dígitos", MessageBoxIcon.Warning);
                return;
            }

            if (contra != contraConfirm)
            {
                Alerta.Notificacion("Las contraseñas no son iguales", MessageBoxIcon.Warning);
                return;
            }


            Random rnd = new Random();
            int codVerifica = rnd.Next(999, 9999);
            codVerificacion = codVerifica;
            DNI_Empleado = empleado.DNI;

            try
            {
                Correo.EnviarEmailRestaurarContra(empleado.Correo, codVerificacion);
                Alerta.Notificacion("Se envio correo con el código de verificación", MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                Alerta.Notificacion("Hubo un problema al enviar el correo", MessageBoxIcon.Warning);
            }

        }

      

        private void ValidarCodigoVerificacion()
        {
            string dni = txtDNI.Text.Trim();
            string contra = txtContra.Text.Trim();
            string contraConfirm = txtConfirmContra.Text.Trim();
            string codVeriText = txtCodVeri.Text;

            Empleado empleado = repo.ObtenerEmpleado(dni, "", 1).FirstOrDefault();


            if (!int.TryParse(codVeriText, out _))
            {
                Alerta.Notificacion("El código debe ser númerico", MessageBoxIcon.Warning);
                return;
            }

            if (empleado == null)
            {
                Alerta.Notificacion("Usuario no existe", MessageBoxIcon.Warning);
                return;
            }

            if (contra.Length <= 7)
            {
                Alerta.Notificacion("La contraseña debe ser mayor a 7 dìgitos", MessageBoxIcon.Warning);
                return;
            }

            if (contra != contraConfirm)
            {
                Alerta.Notificacion("Las contraseñas no son iguales", MessageBoxIcon.Warning);
                return;
            }

            if (codVerificacion != Convert.ToInt32(codVeriText) || DNI_Empleado != empleado.DNI)
            {
                Alerta.Notificacion($"¡El código de verificación es incorrecto para el empleado {empleado.NombreCompletos}!", MessageBoxIcon.Warning);
                return;
            }

            empleado.Contra = BCrypt.Net.BCrypt.HashPassword(contra);
            empleado.UltFechaIngreso = "";
            empleado.FlagMant = 1;
            //Actualizar contraseña
            try
            {
                RespuestaDTO respuesta = repo.MantEmpleado(empleado);

                if (respuesta.CodRes == 1)
                {
                    Alerta.Notificacion("Se restauro la contraseña del empleado", MessageBoxIcon.Information);
                    LimpiarCampos();
                    Volver();
                }

            }
            catch (Exception ex)
            {
                Alerta.Notificacion($"Error mantenimiento empleado : {ex.Message}", MessageBoxIcon.Warning);
            }





        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarContraseña();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Volver();
        }

        private void btnValidarCodVerificación_Click(object sender, EventArgs e)
        {
            ValidarCodigoVerificacion();
        }
    }
}
