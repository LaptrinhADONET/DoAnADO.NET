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

        public DataTable Get_By_Top()
        {
            SqlCommand cmd = new SqlCommand("sp_PQ_Get_By_Top", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Get_By_Top1(string Email, string Pass)
        {
            SqlCommand cmd = new SqlCommand("sp_PQ_Get_By_Top1", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add(new SqlParameter("@Email", Email));
            cmd.Parameters.Add(new SqlParameter("@Pass", Pass));
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}