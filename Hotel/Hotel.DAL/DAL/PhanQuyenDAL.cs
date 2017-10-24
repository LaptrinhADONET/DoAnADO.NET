using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;
using System.Data.SqlClient;
using System.Data;

namespace Hotel.DAL.DAL
{
    public class PhanQuyenDAL
    {
        private DBContect db = new DBContect();

        public DataTable Get_By_Top(string top, string where, string order)
        {
            SqlCommand cmd = new SqlCommand("sp_PQ_Get_By_Top", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@top", top));
            cmd.Parameters.Add(new SqlParameter("@where", where));
            cmd.Parameters.Add(new SqlParameter("@order", order));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}