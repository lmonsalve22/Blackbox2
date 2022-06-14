using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace Login.Models
{
    public class Correo
    {
        public static void SendEmailAsync(string correo, string contenido)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("soporte@dataintelligence-group.com", "Bv#4582Hx");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("soporte@dataintelligence-group.com", "Recuperar contraseña"),
                    Subject = "DATAINTELLIGENCE",

                    Body = "<html><head></head><body><p>Correo de Recuperación de Contraseña</p><br/>" +
                    contenido +
                    "</body></html>",

                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress(correo));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "mail.dataintelligence-group.com",
                    EnableSsl = false,
                    Credentials = credentials
                };

                // Send it...
                client.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }

            //return Task.Com;
        }

        public static void correoConfirmacion(string correo, string contenido)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("soporte@dataintelligence-group.com", "sud123456789");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("soporte@dataintelligence-group.com", "Prueba de 7 dias de productos"),
                    Subject = "DATAINTELLIGENCE",

                    Body = "<html><head></head><body><p>Bienvenidos a DataIntelligence</p><br/>" +
                    "Tienes nuestra muestra de productos gratis por suscribirse a DataIntelligence, los cuales se vencen en 7 dias" +
                    //contenido +

                    "</body></html>",

                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress(correo));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "mail.dataintelligence-group.com",
                    EnableSsl = false,
                    Credentials = credentials
                };

                // Send it...
                client.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }

            //return Task.Com;
        }

        public static void SendEmailClent(string correo, string contenido)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("soporte@dataintelligence-group.com", "sud123456789");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("soporte@dataintelligence-group.com", "Recuperar contraseña"),
                    Subject = "DATAINTELLIGENCE",

                    Body = "<html><head></head><body><p style='color:red; background-color:blue; font-size:10em;'>Hola soy un html</p><br/>" +
                    contenido +
                    "</body></html>",

                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress(correo));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "mail.dataintelligence-group.com",
                    EnableSsl = false,
                    Credentials = credentials
                };

                // Send it...
                client.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }

            //return Task.Com;
        }
    }
}