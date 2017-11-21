using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL.DAL
{
    public class reposstLstHoaDon
    {
        public DataTable getdata()
        {
            DBContect db = new DBContect();
            SqlCommand cmd = new SqlCommand("sp_lstHoaDon", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}