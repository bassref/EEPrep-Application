using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPrep
{
    /**
     * Executes queries on the database
     */
    public class MySqlDataProvider : IDbDataProvider
    {
        private MySqlDatabaseConnection databaseConnection;

        public MySqlDataProvider(MySqlDatabaseConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }

        /**
         * 
         */
        public IDataReader ExecuteReader(string sqlQuery)
        {
            if (databaseConnection.State != ConnectionState.Open)
            {
                databaseConnection.OpenConnection();
            }
            IDataReader result;
            IDbCommand sqlCommand = CreateSqlTextCommand(sqlQuery);
            result = sqlCommand.ExecuteReader();
            return result;
        }

        public object ExecuteScalar(string sqlQuery)
        {
            object result;
            IDbCommand sqlCommand = CreateSqlTextCommand(sqlQuery);
            result = sqlCommand.ExecuteScalar();
            return result;
        }

        private IDbCommand CreateSqlTextCommand(string sqlQuery)
        {
            IDbCommand sqlCommand = databaseConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sqlQuery;
            return sqlCommand;
        }




    }

}
