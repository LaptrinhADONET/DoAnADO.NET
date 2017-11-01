using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;
using System.Data.SqlClient;
using System.Data;

namespace Hotel.DAL
{
    public class LoaiPhongDAL : Repository<LoaiPhong>
    {
        public override void Add(LoaiPhong obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_LoaiPhong_insert", db.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ten", obj.TenLoaiPhong));
                    cmd.Parameters.Add(new SqlParameter("@gia", float.Parse(obj.GiaPhong)));
                    cmd.Parameters.Add(new SqlParameter("@trangthai", int.Parse(obj.TrangThai)));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable checkma(int ma)
        {
            SqlCommand cmd = new SqlCommand("sp_checkLoginLP", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ma", ma));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public override void Delete(int ma)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_LoaiPhong_Delete", db.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", ma));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override List<LoaiPhong> Get_By_Top(string Top, string Where, string Order)
        {
            List<LoaiPhong> lst = new List<LoaiPhong>();
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
                        LoaiPhong obj = new LoaiPhong();
                        obj.LoaiPhongIDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            db.conn.Close();
            return lst;
        }

        public void Search(LoaiPhong obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_LoaiPhong_Search", db.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(obj.MaLoaiPhong)));
                cmd.Parameters.Add(new SqlParameter("@ten", obj.TenLoaiPhong));
                cmd.Parameters.Add(new SqlParameter("@gia", float.Parse(obj.GiaPhong)));
                cmd.Parameters.Add(new SqlParameter("@trangthai", int.Parse(obj.TrangThai)));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Update(LoaiPhong obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_LoaiPhong_Update", db.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(obj.MaLoaiPhong)));
                cmd.Parameters.Add(new SqlParameter("@ten", obj.TenLoaiPhong));
                cmd.Parameters.Add(new SqlParameter("@gia", float.Parse(obj.GiaPhong)));
                cmd.Parameters.Add(new SqlParameter("@trangthai", int.Parse(obj.TrangThai)));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}