using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Configuration;

namespace Hotel.Model
{
    public class DBContect
    {
        public SqlConnection conn = null;
        private string constr = "Data Source=.;Initial Catalog=LT.Net;Integrated Security=True";
        //private static string constr = ConfigurationManager.AppSettings["str"];

        public DBContect()
        {
            if (conn == null)
            {
                conn = new SqlConnection(constr);
                conn.Open();
            }
        }

        public SqlConnection GetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
    }
}