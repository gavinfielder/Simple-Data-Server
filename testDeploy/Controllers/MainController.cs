using System.Collections.Generic;
using testDeploy.Models;
using testDeploy.DataDefinitions;

namespace testDeploy.Controllers
{
    public class MainController
    {
        //Fields
        private static IDataService data = new ramOnlyStorage();
        private static ILogManager logManager = new TextLogManager("C:\\inetpub\\wwwroot\\App_Data\\log.txt");

        //Uses the data service object to record the requested data
        public static bool SendData(string id, float value)
        {
            Log("Inserting new record.");
            bool success = data.Insert(id, value);
            return success;
        }

        //Uses the data service object to retrieve all data
        public static List<Record> RetrieveAllRecords()
        {
            Log("Retrieving records.");
            return data.RetrieveAll();
        }
        
        //Writes a message to the log file
        public static void Log(string message)
        {
            logManager.Log(message);
        }

        //Retrieves the contents of the log file
        public static string ReadLogFile()
        {
            return logManager.ReadAll();
        }
    }
}