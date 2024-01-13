using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTPSender.src.Utils
{
    public static class Logger
    {
        private static StreamWriter SWLog;
        private const string LOG_FILENAME = "log.txt";

        static Logger()
        {
            Logger.OpenLogger();
        }

        public static void OpenLogger()
        {
            SWLog = new StreamWriter(LOG_FILENAME, false)
            {
                AutoFlush = true
            };
        }

        public static void LogLine(string message)
        {
            SWLog.WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} \t: \t {message}");
        }

        public static void CloseLogger()
        {
            SWLog.Flush();
            SWLog.Close();
        }
    }
}
