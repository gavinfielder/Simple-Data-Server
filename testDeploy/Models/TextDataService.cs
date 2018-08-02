using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testDeploy.ServiceReference1;

namespace testDeploy.Models
{
    public class TextDataService : IDataService
    {
        private DataServiceClient client = new DataServiceClient();
        
        public bool Insert(string id, float value)
        {
            client.AddRecord(id, value);
            return true; //TODO: how do I know if this was really a success?
        }

        public bool PurgeRecords()
        {
            //TODO: no functionality for this in the service yet
            return false;
        }

        public List<Record> RetrieveAll()
        {
            RecordsDataContract dc = client.GetRecords();
            List<Record> records = new List<Record>(dc.Records);
            return records;
        }

    }
}