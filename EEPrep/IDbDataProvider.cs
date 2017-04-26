using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EEPrep
{
    public interface IDbDataProvider
    {
        IDataReader ExecuteReader(string sqlQuery);
        object ExecuteScalar(string sqlQuery);
    }
}
