using System;
using System.Collections.Generic;
using testDeploy.DataDefinitions;
using System.Data.SqlClient;

namespace DataService.SQLServer
{
    
    public class SQLServerService : IDataService
    {
        //Fields
        private SqlConnection connection;

        //Constructor sets up connection
        public SQLServerService()
        {
            connection = SQLServerConnectionHelper.GetSQLConnection();
        }

        //Retrieve all records in the data table
        public RecordsDataContract GetRecords()
        {
            //Console.WriteLine("Entering GetRecords.");
            List<Record> records = new List<Record>();
            try
            {
                Console.WriteLine("Opening connection to SQL server...");
                connection.Open();
                Console.WriteLine("Connection opened. Formatting query...");
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM sdsdata ORDER BY added ASC;";
                command.Connection = connection;
                Console.WriteLine("Query formed: " + command.CommandText + " Executing now...");
                SqlDataReader reader = command.ExecuteReader();
                Record rec;
                while (reader.Read())
                {
                    rec = new Record();
                    rec.id = reader.GetString(0);
                    rec.value = (float)reader.GetDecimal(1);
                    rec.dateTime = reader.GetDateTime(2);
                    records.Add(rec);
                }
                //Console.WriteLine("Query executed. Retrieved " + records.Count + " records.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception occurred in AddRecord: " + ex.Message);
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unknown exception occurred: " + ex.Message);
            //}
            finally
            {
                connection.Close();
                //Console.WriteLine("Connection closed.");
            }

            //Formulate data contract
            Console.WriteLine("Serializing " + records.Count + " records for data contract now.");
            RecordsDataContract dc = new RecordsDataContract();
            dc.Records = records;
            //Console.WriteLine("Exiting GetRecords.");
            return dc;
        }

        //Add a record to the data table
        public void AddRecord(string id, float value)
        {
            //Console.WriteLine("Entering AddRecord.");
            try
            {
                Console.WriteLine("Opening connection to SQL server...");
                connection.Open();
                Console.WriteLine("Connection opened. Formatting query...");
                SqlCommand command = new SqlCommand();
                command.CommandText = String.Format("INSERT INTO sdsdata VALUES ('{0}',{1},'{2}');",
                    id, value, DateTime.Now.ToString("yyyyMMdd hh:mm:ss"));
                command.Connection = connection;
                Console.WriteLine("Query formed: " + command.CommandText + " Executing now...");
                command.ExecuteNonQuery();
                //Console.WriteLine("Query executed.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception occurred in AddRecord: " + ex.Message);
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unknown exception occurred: " + ex.Message);
            //}
            finally
            {
                connection.Close();
                //Console.WriteLine("Connection closed.");
            }
            //Console.WriteLine("Exiting AddRecord.");
        }
    }
}
