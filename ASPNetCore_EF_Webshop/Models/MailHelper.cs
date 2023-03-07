using System.Net;
using System.Net.Mail;

namespace Webshop.Models
{
    public static class MailHelper
    {
        /// <summary>
        /// Stuurt een mail via de smtp-server van Office365
        /// </summary>
        /// <param name="zender">E-mailadres van de zender</param>
        /// <param name="naam">Naam van de zender</param>
        /// <param name="inhoud">Inhoud van de email</param>
        /// <param name="ontvanger">E-mailadres van de ontvanger</param>
        public static void SendMail(string zender, string naam, string inhoud, string ontvanger)
        {
            // twee keer "ontvanger", omdat Outlook niet toelaat een ander From adres te gebruiken dan de gebruiker van de account
            // (anders zou je de invuller van het formulier in het "From" veld kunnen steken)
            MailMessage mail = new(ontvanger, ontvanger, $"Bericht van {naam}", inhoud);
            // We kunnen weliswaar geen mail verzenden als de persoon die het contactformulier invult, 
            // maar door de volgende regel code zal het e-mailadres ingevuld in het formulier worden gebruikt als de ontvanger op "Reply" drukt.
            mail.ReplyToList.Add(zender);
            mail.IsBodyHtml = true;
            SmtpClient smtp = new("smtp.office365.com", 587)
            {
                Credentials = new NetworkCredential(ontvanger, "wachtwoord"),
                EnableSsl = true
            };
            smtp.Send(mail);
        }
    }
}
