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
    public class PhongBanDAL : Repository<PhongBan>
    {
        public override void Add(PhongBan obj)
        {
            SqlCommand cmd = new SqlCommand("sp_PhongBan_ADD", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ten", obj.TenPhongBan));
            cmd.Parameters.Add(new SqlParameter("@TrangThai", int.Parse(obj.TrangThai)));
            cmd.ExecuteNonQuery();
        }

        public override void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<PhongBan> Get_By_Top(string Top, string Where, string Order)
        {
            List<PhongBan> lst = new List<PhongBan>();
            using (SqlCommand cmd = new SqlCommand("sp_Get_By_Top", db.GetConnection()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@top", Top));
                cmd.Parameters.Add(new SqlParameter("@top", Top));
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@order", Order));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PhongBan obj = new PhongBan();
                        obj.PhongBanIDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            db.conn.Close();
            return lst;
        }

        public List<PhongBan> Get_By_Top1(string Top, string Where, string Order, string tenbang)
        {
            List<PhongBan> lst = new List<PhongBan>();
            using (SqlCommand cmd = new SqlCommand("sp_Get_By_Top", db.GetConnection()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tenbang", tenbang));
                cmd.Parameters.Add(new SqlParameter("@top", Top));
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@order", Order));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PhongBan obj = new PhongBan();
                        obj.PhongBanIDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            db.conn.Close();
            return lst;
        }

        public override void Update(PhongBan obj)
        {
            SqlCommand cmd = new SqlCommand("sp_PhongBan_Update", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(obj.MaPhongBan)));
            cmd.Parameters.Add(new SqlParameter("@ten", obj.TenPhongBan));
            cmd.Parameters.Add(new SqlParameter("@TrangThai", int.Parse(obj.TrangThai)));
            cmd.ExecuteNonQuery();
        }
    }
}