using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testDeploy.Models;

namespace testDeploy.Controllers
{
    public class MainController
    {
        //Fields
        private static IDataService data = new ramOnlyStorage();

        //Uses the data service object to record the requested data
        public static bool SendData(string id, float value)
        {
            return data.Insert(id, value);
        }

        //Uses the data service object to retrieve all data
        public static List<Record> RetrieveAllRecords()
        {
            return data.RetrieveAll();
        }
    }
}