using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEvent.Services
{
    public class MKitTest
    {

       public void send()
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Chendra", "cgarikipati@gmail.com"));
            message.To.Add(new MailboxAddress("Chendra", "cgarikipati@gmail.com"));
            message.Subject = "How you doin?";

            message.Body = new TextPart("plain")
            {
                Text = @"Hey,
                What are you up to this weekend? 
                "
            };


             using (var client = new SmtpClient(new ProtocolLogger("smtp.log")))
            {
                client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);

                client.Authenticate("cgarikipati", "Pe0nyfl0wer");

                client.Send(message);

                client.Disconnect(true);
            }

           
        
    }
    }
}
