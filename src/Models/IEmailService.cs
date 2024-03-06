using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTPSender.src.Models
{
    public interface IEmailService
    {
        void SendEmail(string email);

        Task<bool> Authenticate();
    }
}
