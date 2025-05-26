using AppBogedaTeo.Vistas;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace AppBogedaTeo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            string cadenaConexion = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            //RepoUsu repoUsu = new RepoUsu(cadenaConexion);
            frmLogin login = frmLogin.GetInstance(cadenaConexion);
            Application.Run(login);
        }
    }
}
