using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Comun
{
    public class EmailHelper
    {
        public static void Send(string Destino, string Token)
        {
            string output = null;
            try
            {
                //Creando objeto MailMessage
                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress(Destino));
                email.From = new MailAddress("soporte@coopacsalud.com");
                email.Subject = "COOPERATIVA TOKEN " + DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss") + "";
                email.Body = "Tu Token es: <b>" + Token + "</b>";
                email.IsBodyHtml = true;
                email.Priority = MailPriority.Normal;
                //Definir Objeto SmtpClient
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "mail.rjdisenadores.com";
                smtp.Port = 587;
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("soporte@coopacsalud.com", "admin123");
                //Enviar Correo Electronico
                smtp.Send(email);
                email.Dispose();
                output = "Corre electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }
            Console.WriteLine(output);
        }
    }
}
