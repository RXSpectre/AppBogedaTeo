using AppBogedaTeo.DTO;
using AppBogedaTeo.Entidades;
using AppBogedaTeo.Repositorio;
using AppBogedaTeo.Vistas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppBogedaTeo.Vistas
{
    public partial class frmPrin : Form
    {
        private Empleado empleado;
        private string cadenaConexion;
        private static frmPrin instance = null;

        private RolXOpcionRepositorio repoRolXOpcion;

        public static frmPrin GetInstance(Empleado empleado, string cadenaConexion)
        {
            if (instance == null || instance.IsDisposed)
                instance = new frmPrin(empleado, cadenaConexion);
            else
                instance.BringToFront();

            return instance;
        }

        private frmPrin(Empleado empleado, string cadenaConexion)
        {
            InitializeComponent();
            this.empleado = empleado;
            this.cadenaConexion = cadenaConexion;

            repoRolXOpcion = new RolXOpcionRepositorio(cadenaConexion);

            PintarDatos();
            PintarOpcionesPorPerfil();
        }

        private void PintarDatos()
        {
            lblNomUsu.Text = empleado.NombreCompletos;
            lblUlt_Ingreso.Text = empleado.UltFechaIngreso;
            lblRol.Text = empleado.DscRol;
        }


        public void PintarOpcionesPorPerfil()
        {
            List<OpcionesDTO> opcRolUsu = repoRolXOpcion.ObtenerOpcPorRol(empleado.CodRol);

            //Obtener solo los botones
            foreach (var control in panelBotones.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    //listaBtn.Add((Button)control);
                    ((Button)control).Visible = false;
                    foreach (var opc in opcRolUsu)
                    {
                        if (opc.DscOpcion.Trim() == ((Button)control).Text)
                            ((Button)control).Visible = true;
                    }
                }

            }
            btnCerrarSesion.Visible = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.GetInstance(cadenaConexion).Show();
        }

        private void btnRolXOpcion_Click(object sender, EventArgs e)
        {
            frmRolXOpcion.GetInstance(this, cadenaConexion).Show();
        }

        private void btnMantUsuario_Click(object sender, EventArgs e)
        {
            frmMantEmpleado.GetInstance(this, cadenaConexion).Show();
        }

        private void btnMantParam_Click(object sender, EventArgs e)
        {
            //frmMantParam.GetInstance(this, cadenaConexion).Show();
        }

        private void btnMantOrdenPedido_Click(object sender, EventArgs e)
        {
            frmGenOrdenPedido.GetInstance(this, cadenaConexion, empleado.CodEmpleado).Show();
        }

        private void btnMantCliente_Click(object sender, EventArgs e)
        {
            frmMantCliente.GetInstance(this, cadenaConexion).Show();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            frmRegisVenta.GetInstance(this, cadenaConexion, empleado.CodEmpleado).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMantCredito.GetInstance(this, cadenaConexion).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConsOrdenPedido.GetInstance(this, cadenaConexion, empleado.CodEmpleado).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmConsVentas.GetInstance(this, cadenaConexion).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMantProductos.GetInstance(this, cadenaConexion).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGenSolCompra.GetInstance(this, cadenaConexion, empleado.CodEmpleado).Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmMantProveedores.GetInstance(this, cadenaConexion).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmIngresoSolCompra.GetInstance(this, cadenaConexion, empleado.CodEmpleado).Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmConsSolCompra.GetInstance(this, cadenaConexion).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmReportesVentas.GetInstance(this, cadenaConexion).Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmReportesSolCompra.GetInstance(this, cadenaConexion).Show();
        }
    }
}
