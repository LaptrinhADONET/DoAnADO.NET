using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;
using System.Data.SqlClient;

namespace Hotel.DAL
{
    public class ChucVuDAL : Repository<ChucVu>
    {
        public override void Add(ChucVu obj)
        {
            SqlCommand cmd = new SqlCommand("sp_ChucVu_ADD", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ten", obj.TenCV));
            cmd.Parameters.Add(new SqlParameter("@hsl", float.Parse(obj.HSLuong)));
            cmd.ExecuteNonQuery();
        }

        public override void Delete(int ma)
        {
            SqlCommand cmd = new SqlCommand("sp_Delete_ChucVu", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ma", ma));
            cmd.ExecuteNonQuery();
        }

        public override List<ChucVu> Get_By_Top(string Top, string Where, string Order)
        {
            List<ChucVu> lst = new List<ChucVu>();
            using (SqlCommand cmd = new SqlCommand("sp_ChucVuGet_By_Top", db.GetConnection()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@top", Top));
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@order", Order));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ChucVu obj = new ChucVu();
                        obj.ChucVuIdataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public List<ChucVu> Get_By_Top1(string top, string where, string order, string tenbang)
        {
            db.conn.Close();
            List<ChucVu> lst = new List<ChucVu>();
            SqlCommand cmd = new SqlCommand("sp_Get_By_Top", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tenbang", tenbang));
            cmd.Parameters.Add(new SqlParameter("@top", top));
            cmd.Parameters.Add(new SqlParameter("@where", where));
            cmd.Parameters.Add(new SqlParameter("@order", order));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ChucVu obj = new ChucVu();
                    obj.ChucVuIdataReader(dr);
                    lst.Add(obj);
                }
            }

            return lst;
        }

        public override void Update(ChucVu obj)
        {
            SqlCommand cmd = new SqlCommand("sp_ChucVu_Update", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(obj.MaCV)));
            cmd.Parameters.Add(new SqlParameter("@ten", obj.TenCV));
            cmd.Parameters.Add(new SqlParameter("@gia", float.Parse(obj.HSLuong)));
            cmd.ExecuteNonQuery();
        }
    }
}