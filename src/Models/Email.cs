using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTPSender.src.Models
{
    public class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        
        public List<EmailAttachment> Attachments { get; set; }

        public Email() 
        {
            Attachments = new List<EmailAttachment>();
        }
    }
}
