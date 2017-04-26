using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace EEPrep
{
    public class DatabaseConnection
    {
        public static void MakeConnection()
        {

        /*private ConnectionState state;

        private string connectionString = "Server = Reph;" +
                                          "Database = ExitExam;" +
                                          "Uid = root;" + "Pwd = bre@d&Chee3e";

        private SqlConnection conn = new SqlConnection(connectionString);
        */
        
            String sqlServerLogin = "root";
                        String password = "bre@d&Chee3e";
                        String instanceName = "instance_name";
                        String remoteSvrName = "";

        // Connecting to an instance of SQL Server using SQL Server Authentication  
        Server srv1 = new Server(); // connects to default instance  
                 srv1.ConnectionContext.LoginSecure = true; // set to true for Windows Authentication  
                 srv1.ConnectionContext.Login = sqlServerLogin;
                 srv1.ConnectionContext.Password = password;
                 Console.WriteLine(srv1.Information.Version); // connection is established  
    }
      }
    
}