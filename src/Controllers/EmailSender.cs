using SMTPSender.src.Models;
using SMTPSender.src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SMTPSender.src.Controllers
{
    public sealed class EmailSender
    {
        private readonly static EmailSender _instance = new EmailSender();
        private const int PORT = 587;
        private const string HOST = "smtp.gmail.com";

        private EmailSender()
        {
        }

        public static EmailSender Instance
        {
            get 
            {
                return _instance;
            }
        }

        public static void SendEmail(EmailCredentials credentials, Email email)
        {
            if (credentials == null || email == null)
            {
                throw new ArgumentNullException("The creedentials and the email cannot be null");
            }

            var client = new SmtpClient(HOST, PORT)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(credentials.Email, credentials.Password),
                EnableSsl = true
            };

            var message = new MailMessage()
            {
                From = new MailAddress(credentials.Email),
                Subject = email.Subject,
                Body = email.Body,
                To = { email.To },
                IsBodyHtml = true
            };

            if (email.Attachments != null)
            {
                foreach (var attachment in email.Attachments)
                {
                    Attachment fileAttachment = attachment.CreateAttachment();

                    if (fileAttachment == null) continue;

                    message.Attachments.Add(fileAttachment);
                }

                Logger.LogLine($"The message has {message.Attachments.Count} attachments");
            }

            try
            {
                client.Send(message);

                Logger.LogLine("Email sent sucessfully");
            }
            catch (Exception ex)
            {
                Logger.LogLine(ex.Message);
            }
            finally
            {
                message.Dispose();
            }
        }
    }
}
