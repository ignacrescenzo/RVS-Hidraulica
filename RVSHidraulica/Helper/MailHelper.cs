using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RVSHidraulica.Enum;

namespace RVSHidraulica.Helper
{

    public class MailHelper
    {
        public static IConfiguration Configuration { get; set; }

        public static void EnviarMail(string nombre,int tipoMensaje,string mensaje,string mail)
        {
            var tipo = "";
            switch (tipoMensaje)
            {
                case (int)TipoMensaje.Consulta:
                    tipo = TipoMensaje.Consulta.ToString();
                    break;
                case (int)TipoMensaje.Pedido:
                    tipo = TipoMensaje.Pedido.ToString();
                    break;
                case (int)TipoMensaje.Sugerencia:
                    tipo = TipoMensaje.Sugerencia.ToString();
                    break;
            }
            var asunto = $"[{tipo}] - {nombre}" + (mail == null ? "" : $" - {mail}");
            var message = new MailMessage(Configuration.GetSection("EmailConfig:EmailConsultas").Value, Configuration.GetSection("EmailConfig:EmailDestino").Value);
            message.Subject = asunto;
            message.Body = mensaje;
            SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587);
            mailer.Credentials = new NetworkCredential(Configuration.GetSection("EmailConfig:EmailConsultas").Value, Configuration.GetSection("EmailConfig:Password").Value);
            mailer.EnableSsl = true;
            mailer.Send(message);
            mailer.Dispose();
        }
    }
}
