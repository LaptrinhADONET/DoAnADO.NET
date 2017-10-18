using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    public class DBContect
    {
        public SqlConnection conn = null;
        private string constr = "Data Source=.;Initial Catalog=LT.Net;Integrated Security=True";

        public DBContect()
        {
            if (conn == null)
            {
                conn = new SqlConnection(constr);
                conn.Open();
            }
        }
    }
}