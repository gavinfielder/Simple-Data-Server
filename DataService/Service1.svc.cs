using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using testDeploy.DataDefinitions;
using System.IO;

namespace DataService
{

    public class TextDataService : IDataService
    {

        private const string filename = "C:\\inetpub\\wwwroot\\App_Data\\textStorage.txt";

        public RecordsDataContract GetRecords()
        {

            Console.WriteLine("Entering GetRecords.");
            RecordsDataContract dc = new RecordsDataContract();
            StreamReader fin = new StreamReader(filename);
            string line;
            List<Record> records = new List<Record>();
            while (!(fin.EndOfStream))
            {
                line = fin.ReadLine();
                Console.WriteLine("Got line: " + line);
                records.Add(SplitCSV(line));
                Console.WriteLine("Record successfully added to collection.");
            }
            Console.WriteLine("Done collecting records, now assigning to data contract.");
            dc.Records = records;
            Console.WriteLine("Finished getting records. Retrieved " + dc.Records.Count + " records. Returning now.");
            fin.Close();
            Console.WriteLine("StreamReader closed.");
            return dc;
        }

        public void AddRecord(string id, float value)
        {
            Console.WriteLine("Entering AddRecord.");
            StreamWriter fout = new StreamWriter(filename, true);
            Console.WriteLine("StreamWriter created.");
            fout.WriteLine("{0},{1},{2}",id, value, DateTime.Now.ToString());
            Console.WriteLine("File appended. Closing now...");
            fout.Close();
            Console.WriteLine("Record added: {0},{1},{2}", id, value, DateTime.Now.ToString());
        }

        //Splits the CSV line into a Record
        private Record SplitCSV(string line)
        {
            int i = line.IndexOf(','); //hello,47.6,datetime
            string id = line.Substring(0, i);
            Console.WriteLine("Found id: " + id);
            line = line.Substring(i + 1);
            i = line.IndexOf(',');
            float value = float.Parse(line.Substring(0, i));
            Console.WriteLine("Found value: " + value);
            line = line.Substring(i + 1);
            Record r = new Record();
            r.id = id;
            r.value = value;
            Console.WriteLine("Now parsing datetime: <" + line + ">");
            r.dateTime = DateTime.Parse(line);
            Console.WriteLine("DateTime parsing succeeded.");
            return r;
        }

    }
}
