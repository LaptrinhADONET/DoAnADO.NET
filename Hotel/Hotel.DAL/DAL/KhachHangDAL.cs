using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.DAL
{
    public class KhachHangDAL : Repository<KhachHang>
    {
        public override void Add(KhachHang obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<KhachHang> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public DataTable GetByTop(string Top, string Where, string Order, string tenbang)
        {
            SqlCommand cmd = new SqlCommand("sp_Get_By_Top", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tenbang", tenbang));
            cmd.Parameters.Add(new SqlParameter("@top", Top));
            cmd.Parameters.Add(new SqlParameter("@where", Where));
            cmd.Parameters.Add(new SqlParameter("@order", Order));
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public override void Update(KhachHang obj)
        {
            SqlCommand cmd = new SqlCommand("[sp_KhachHang_Update]", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(obj.MaKH)));
            cmd.Parameters.Add(new SqlParameter("@ten", obj.TenKH));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", int.Parse(obj.GioiTinh)));
            cmd.Parameters.Add(new SqlParameter("@trangthai", obj.TrangThai.Contains("1") ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("@diachi", obj.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@sdt", int.Parse(obj.SDT)));
            cmd.Parameters.Add(new SqlParameter("@email", obj.Email));
            cmd.Parameters.Add(new SqlParameter("@cmt", int.Parse(obj.CMT)));
            cmd.Parameters.Add(new SqlParameter("@namsinh", int.Parse(obj.Ns)));
            cmd.ExecuteNonQuery();
        }
    }
}