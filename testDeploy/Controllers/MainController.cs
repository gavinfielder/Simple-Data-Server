using System.Collections.Generic;
using testDeploy.ServiceReference1;

namespace testDeploy.Controllers
{
    public class MainController
    {
        //Fields
        private static DataServiceClient dataClient = new DataServiceClient();
        private static ILogManager logManager = new TextLogManager("C:\\inetpub\\wwwroot\\App_Data\\log.txt");

        //Provides public access to the log system
        public static ILogManager Log
        {
            get
            {
                return logManager;
            }
        }

        //Uses the data service object to record the requested data
        public static void SendData(string id, float value)
        {
            //Disabling
            //Log.Write("Inserting new record.");
            //dataClient.AddRecord(id, value);
        }

        //Uses the data service object to retrieve all data
        public static List<Record> RetrieveAllRecords()
        {
            /* Disabling
            Log.Write("Retrieving records.");
            RecordsDataContract dc = dataClient.GetRecords();
            List<Record> records = new List<Record>(dc.Records);
            return records;
            */

            //Disabled version
            return new List<Record>();
        }
        
    }
}