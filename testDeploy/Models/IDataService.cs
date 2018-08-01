using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDeploy.Models
{

    public struct Record
    {
        public string id;
        public float value;
        public DateTime dateTime;
    }


    public interface IDataService
    {
        bool Insert(string id, float value);
        List<Record> RetrieveAll();
        bool PurgeRecords();
    }
}
