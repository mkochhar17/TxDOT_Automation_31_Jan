using System;
using System.IO;

namespace TxDOTAutomation.Helpers
{
    public class LogHelpers
    {
        //Log file name
        private static string logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter streamw = null;

        //Create a file which can store the log information
        public static void CreateLogFile()
        {
            string dir =  @"e:\TxDOTAutomation\Logs";
            if (Directory.Exists(dir))
            {
                streamw = File.AppendText(dir + logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                streamw = File.AppendText(dir + logFileName + ".log");
            }
        }

        //Create a method which can write the text in the log file 
        public static void Write(string logMessage)
        {
            streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            streamw.WriteLine("    {0}", logMessage);
            streamw.Flush();
        }
    }
}
