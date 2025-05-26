using System;
using System.Net.Mail;
using System.Net;

namespace AppBogedaTeo.Util
{
    public class Correo
    {

        public static void EnviarEmailRestaurarContra(string correo, int codVerifi = 0)
        {

            string emailOrigen = "Tambo172024@gmail.com";
            string emailDest = correo.Trim();
            string contra = "agdk fixw nvyq hkvp";
            string titulo = "Código de Verificación";
            string cuerpo = $"<b> Tu código de verificación es {codVerifi} </b>";

            MailMessage mailMessage = new MailMessage(emailOrigen, emailDest, titulo, cuerpo);
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            //smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(emailOrigen, contra);

            try
            {
                smtpClient.Send(mailMessage);
                smtpClient.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
