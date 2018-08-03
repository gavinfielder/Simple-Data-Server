using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace testDeploy.Controllers
{
    public interface ILogManager
    {
        void Write(string message);
        string ReadAll();
    }


    public class TextLogManager : ILogManager
    {
        //Fields
        private string _logFilePath;

        //Constructor. Accepts relative file path of log in project
        public TextLogManager(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        //Writes a message to the log
        public void Write(string message)
        {
            StreamWriter fout = new StreamWriter(_logFilePath, true);
            string record = DateTime.Now.ToString() + "   " + message + "\r\n";
            fout.Write(record);
            fout.Close();
        }

        //Retrieves the contents of the log file
        public string ReadAll()
        {
            string logContents;
            StreamReader fin = new StreamReader(_logFilePath);
            logContents = fin.ReadToEnd();
            fin.Close();
            return logContents;
        }
    }
}