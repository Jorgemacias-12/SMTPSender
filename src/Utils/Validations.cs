using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SMTPSender.src.Utils
{
    public class Validations
    {
        public static Boolean IsEmail(string email)
        {
            const string EMAIL_PATTERN = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex r = new Regex(EMAIL_PATTERN);

            return r.IsMatch(email);
        }
    }
}