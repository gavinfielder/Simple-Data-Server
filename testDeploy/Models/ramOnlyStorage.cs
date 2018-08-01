using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testDeploy.DataDefinitions;

namespace testDeploy.Models
{
    //This class simply uses application memory to store data. 
    public class ramOnlyStorage : IDataService
    {
        //Fields
        private List<Record> _internalStorage = new List<Record>();

        //Insert a record
        public bool Insert(string id, float value)
        {
            Record r = new Record();
            r.dateTime = DateTime.Now;
            r.id = id;
            r.value = value;
            _internalStorage.Add(r);
            return true;
        }

        //Retrieve all the records
        public List<Record> RetrieveAll()
        {
            return new List<Record>(_internalStorage); 
        }

        //Purges all the records from memory
        public bool PurgeRecords()
        {
            _internalStorage.Clear();
            return true;
        }

    }
}