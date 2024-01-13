using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SMTPSender.src.Models
{
    public class EmailCredentials
    {
        public string Email { get; set; }
        public SecureString Password { get; set; }
    }
}
