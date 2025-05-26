using System.Windows.Forms;

namespace AppBogedaTeo.Util
{
    public class Alerta
    {
        public static void Notificacion(string contenido, MessageBoxIcon icon)
        {
            MessageBox.Show(contenido, "Información", MessageBoxButtons.OK, icon);
        }


        public static bool Confirmacion(string contenido)
        {
            bool result = false;
            DialogResult dResult = MessageBox.Show(contenido, "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dResult == DialogResult.Yes)
                result = true;

            return result;
        }
    }
}
