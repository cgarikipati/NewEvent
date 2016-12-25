using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEvent.Services
{
    public class EmailSender
    {
        public static void SendEmail(string email, string subject, string message)
        {
            var mkitMessage = new MimeMessage();
            mkitMessage.From.Add(new MailboxAddress("Chendra", "cgarikipati@gmail.com"));
            mkitMessage.To.Add(new MailboxAddress("Chendra", email));
            mkitMessage.Subject = subject;

            mkitMessage.Body = new TextPart("plain")
            {
                Text = message
            };


            using (var client = new SmtpClient(new MailKit.ProtocolLogger("smtp.log")))
            {
                client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);

                client.Authenticate("cgarikipati", "Pe0nyfl0wer");

                client.Send(mkitMessage);

                client.Disconnect(true);
            }

        }
    }


}
