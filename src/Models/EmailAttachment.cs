using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SMTPSender.src.Models
{
    public class EmailAttachment
    {
        public bool AttachFile { get; set; }    
        public string FilePath { get; set; }
        
        public Attachment CreateAttachment()
        {
            if (!AttachFile || string.IsNullOrEmpty(FilePath))
            {
                return null;
            }

            return new Attachment(FilePath);
        }
    }
}
