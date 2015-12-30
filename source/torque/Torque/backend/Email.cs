using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Torque.backend
{
    class Email
    {
        SmtpClient smtpServer = new SmtpClient();
        MailMessage mail = new MailMessage();

        public Email()
        {
            SetupMailServer();
        }

        private void SetupMailServer(string hostName = "mail.rivadigital.com")
        {
            smtpServer.Host = hostName;
            mail.From = new MailAddress("torque@rivadigital.com");
        }

        public void SendMail(List<string> recipients, string subject, string message)
        {
            // Remove any previously added addresses
            mail.To.Clear();
            
            // Add the list of addresses.
            foreach (string recp in recipients)
            {
                mail.To.Add(recp);
            }

            mail.Subject = subject;
            mail.Body = message;

            smtpServer.Send(mail);
        }
    }
}
