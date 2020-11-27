using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Logger
    {
        const string filePath = "Logger.TXT";
        


        private static Logger instance;

        private Logger()
        { }

       

        public static Logger getInstance()
        {

            if (instance == null)
            {
                instance = new Logger();
            }
            

            return instance;
        }

        public void MakeMassage(string Type, string Message)
        {
            string massage = "{ " + Type + " }: { " + Message + " }";
            File.AppendAllText(filePath, massage + "\n");
            Console.WriteLine(massage);

        }

        public string[] ReadAllLogs()
        {
            string[] all_logs = File.ReadAllLines(filePath);
            return all_logs;
        }

        public void Info()
        {
            MakeMassage("Info", "Message");
        }
        
        public void Warning()
        {
            
            MakeMassage("Warning", "Message");
        }
        
        public void Error(Exception ex)
        {
           
            MakeMassage("Error", ex.StackTrace);
        }
    }

}