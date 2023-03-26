using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace StudentManagement
{
    class DataConnection
    {
        readonly private string conStr;

        public DataConnection()
        {
            conStr = "Data Source=LAPTOP-5OR18CU3;Initial Catalog=StudentManagement;Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}