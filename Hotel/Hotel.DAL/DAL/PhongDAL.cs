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
    public class PhongDAL : Repository<Phong>
    {
        public override void Add(Phong obj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_insert_Phong", db.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@maloaiphong", int.Parse(obj.MaLoaiPhong)));
                    cmd.Parameters.Add(new SqlParameter("@tenphong", obj.TenPhong));
                    cmd.Parameters.Add(new SqlParameter("@mota", obj.MoTa));
                    cmd.Parameters.Add(new SqlParameter("@vitri", obj.ViTri));
                    cmd.Parameters.Add(new SqlParameter("@trangthai", int.Parse(obj.TrangThai)));
                    cmd.Parameters.Add(new SqlParameter("@nguoilon", int.Parse(obj.NguoiLon)));
                    cmd.Parameters.Add(new SqlParameter("@treem", int.Parse(obj.TreEm)));
                    cmd.Parameters.Add(new SqlParameter("@makv", int.Parse(obj.MaKV)));
                    cmd.Parameters.Add(new SqlParameter("@anh", (obj.AnhPhong)));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<Phong> Get_By_Top(string Top, string Where, string Order)
        {
            List<Phong> lst = new List<Phong>();
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Get_By_Top_Phong @t", db.GetConnection()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //  cmd.Parameters.Add(new SqlParameter("@Tenbang", "Phong"));
                cmd.Parameters.Add(new SqlParameter("@top", Top));
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@order", Order));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Phong obj = new Phong();
                        obj.PhongIDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public DataTable Get_By_Top1(string Top, string Where, string Order)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Get_By_Top_Phong", db.GetConnection()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //  cmd.Parameters.Add(new SqlParameter("@Tenbang", "Phong"));
                cmd.Parameters.Add(new SqlParameter("@top", Top));
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@order", Order));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable loadcb(string ma, string ten, string tenbang)
        {
            SqlCommand cmd = new SqlCommand("sp_loadcb", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //  cmd.Parameters.Add(new SqlParameter("@Tenbang", "Phong"));
            cmd.Parameters.Add(new SqlParameter("@ma", ma));
            cmd.Parameters.Add(new SqlParameter("@ten", ten));
            cmd.Parameters.Add(new SqlParameter("@tenbang", tenbang));
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public override void Update(Phong obj)
        {
            throw new NotImplementedException();
        }
    }
}