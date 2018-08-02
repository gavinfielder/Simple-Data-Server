using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using testDeploy.DataDefinitions;
using testDeploy.ServiceReference1;


namespace testDeploy.Models
{
    public interface IDataService
    {
        bool Insert(string id, float value);
        List<Record> RetrieveAll();
        bool PurgeRecords();
    }
}
