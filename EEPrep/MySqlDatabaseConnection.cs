using System;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace EEPrep
{
    public class MySqlDatabaseConnection 
    {
        //private string connectionString = "server = Reph;" + "user id = admin;" +
          //                              "persistsecurityinfo=True;" + "database=examdb";
        private ConnectionState connState;
        
        private String currentDB;
        private String connectionString;
        // sql connection
        private MySqlConnection conn;
       

        public MySqlDatabaseConnection()
        {
            connState = ConnectionState.Closed;
            //Configuration Manager
            ConnectionStringSettingsCollection connStrings = ConfigurationManager.ConnectionStrings;

            if (connStrings != null)
            {
                // search for provider name that matches this nametype
                foreach (ConnectionStringSettings connString in connStrings)
                {
                    // GetType gets the full name of the class and the database connetion
                    // from app.config
                    if (connString.ProviderName == this.GetType().FullName)
                    {
                        connectionString = connString.ConnectionString;
                        break;
                    }
                }
            }
            // create the connection
            conn = new MySqlConnection(this.connectionString);
        }

        #region ConnectionMethods
        /**
         * Purpose:
         */

        //Purpose: Opens the database connection and sets the
        //          Connection State property.
        //Requires: none
        //Returns: none
        public virtual void OpenConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            connState = ConnectionState.Open;
        }
        /*--------------------------------------------------------------*/
        //Purpose: Creates an instance of a command object
        //Requires: nothing
        //Returns: an instance of a command object
        public virtual IDbCommand CreateCommand()
        {
            IDbCommand result = new MySqlCommand();
            result.Connection = conn;
            return result;
        }
        #endregion

        public virtual ConnectionState State { get { return conn.State; }  }
      }
}
    
