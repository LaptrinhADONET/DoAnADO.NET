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
    public class KhuVucDAL : Repository<KhuVuc>
    {
        public override void Add(KhuVuc obj)
        {
            SqlCommand cmd = new SqlCommand("sp_KhuVuc_ADD", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ten", obj.TenKV));
            cmd.Parameters.Add(new SqlParameter("@mota", obj.MoTa));
            cmd.ExecuteNonQuery();
        }

        public override void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<KhuVuc> Get_By_Top(string Top, string Where, string Order)
        {
            List<KhuVuc> lst = new List<KhuVuc>();
            using (SqlCommand cmd = new SqlCommand("sp_LoaiPhong_Get_By_Top", db.GetConnection()))
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
                        KhuVuc obj = new KhuVuc();
                        obj.KhuVucIdataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            db.conn.Close();
            return lst;
        }

        public List<KhuVuc> GetByTop(string top, string where, string order, string tenbang)
        {
            db.conn.Close();
            List<KhuVuc> lst = new List<KhuVuc>();
            using (SqlCommand cmd = new SqlCommand("sp_Get_By_Top", db.GetConnection()))
            {
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
                        KhuVuc obj = new KhuVuc();
                        obj.KhuVucIdataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public override void Update(KhuVuc obj)
        {
            SqlCommand cmd = new SqlCommand("[sp_KhuVuc_Update]", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(obj.MaKV)));
            cmd.Parameters.Add(new SqlParameter("@ten", obj.TenKV));
            cmd.Parameters.Add(new SqlParameter("@mota", obj.MoTa));
            cmd.ExecuteNonQuery();
        }
    }
}