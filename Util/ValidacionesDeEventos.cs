using System;
using System.Linq;
using System.Windows.Forms;

namespace AppBogedaTeo.Util
{
    public class ValidacionesDeEventos
    {
        public static void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea todo lo que no sea letra o espacio
            }
        }

        public static void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea todo lo que no sea número
            }
        }

        // Validación durante la escritura
        public static void txtSoloDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && !txt.Text.Contains('.'))
                return;

            e.Handled = true;
        }

        public static void txtSoloDecimales_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (!string.IsNullOrWhiteSpace(txt.Text) && !decimal.TryParse(txt.Text, out decimal valor))
            {
                MessageBox.Show("Ingrese un número decimal válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Text = "";
                txt.Focus();
            }
        }

    }
}
