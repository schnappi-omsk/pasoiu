using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace DS
{
    class DBConnector
    {

        private const string CONNECTION_STRING = @"DataSource=sociologist.sdf";

        private SqlCeConnection connection;

        public DBConnector() 
        {
            connection = new SqlCeConnection(CONNECTION_STRING);
        }        

        public SqlCeConnection Connection
        {
            get
            {
                return this.connection;
            }
        }

        public void Open() 
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }

    }
}
