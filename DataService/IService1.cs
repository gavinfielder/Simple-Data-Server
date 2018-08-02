using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using testDeploy.DataDefinitions;

namespace DataService
{
    [ServiceContract]
    public interface IDataService
    {

        [OperationContract]
        void AddRecord(string id, float value);

        [OperationContract]
        RecordsDataContract GetRecords();
        
    }

    
    [DataContract]
    public class RecordsDataContract
    {
        [DataMember]
        public List<Record> Records { get; set; }
    }
}
