using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SMTPSender.src.Utils
{
    public class Converters
    {
        public static SecureString ConvertToSecureString(string str)
        {
            if (str == null) throw new ArgumentNullException("str");

            SecureString secureString = new SecureString();

            foreach(char c in str)
            {
                secureString.AppendChar(c);
            }

            secureString.MakeReadOnly();

            return secureString;
        }
    }
}
