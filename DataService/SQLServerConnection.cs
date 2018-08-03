using System.Configuration;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;

namespace DataService.SQLServer
{
    public class SQLServerConnectionHelper 
    {

        //Fields
        private static SqlConnection connection;

        //Forms the connection string
        public static string GetRDSConnectionString()
        {
            string dbname = "sdsdb";
            string username = "gavinfielder";
            string password = "rdspassword";
            string hostname = "aa1d878wsxdcd5s.cilxwsaqcwqv.us-east-2.rds.amazonaws.com";
            string port = "1433";

            return "Data Source=" + hostname + "," + port + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }

        //Returns a connection to the SQL server
        public static SqlConnection GetSQLConnection()
        {
            connection = new SqlConnection(GetRDSConnectionString());
            return connection;
        }
        
    }
    
}