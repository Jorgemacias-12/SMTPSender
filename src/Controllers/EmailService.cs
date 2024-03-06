using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Util.Store;
using SMTPSender.src.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMTPSender.src.Controllers
{
    public class EmailService : IEmailService
    {
        private readonly static EmailService _service = new EmailService();
        private const int PORT = 587;
        private const string HOST = "smtp.gmail.com";
        private string[] AuthPermissions = { GmailService.Scope.GmailSend };
        private readonly string ApplicationName = "Example Desktop client";
        private const string CREDENTIALS_FILENAME = "credentials.json";
        private string basePath = Path.Combine(Directory.GetCurrentDirectory(), CREDENTIALS_FILENAME);
        private string tokenPath = Path.Combine(Directory.GetCurrentDirectory(), "token.json");

        private UserCredential credential;
        private SmtpClient smtpClient;
        private MailMessage message;

        public static EmailService Service { get { return _service; } }

        public EmailService() { }

        public async Task<bool> Authenticate()
        {
            using(var stream = new FileStream(basePath, FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    AuthPermissions,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(tokenPath, true)
                ); 
            }

            if (credential is null)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }

        public void SendEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
