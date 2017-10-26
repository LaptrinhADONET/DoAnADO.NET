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
        private DataTable dt = new DataTable();

        public DataTable Get_By_Top()
        {
            SqlCommand cmd = new SqlCommand("sp_PQ_Get_By_Top", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
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
            da.Fill(dt);
            return dt;
        }

        public DataTable Insearch_PQ(string MaTK, int MaNV, int TrangChu, int TiepNhanKhach, int DanhSachPhong, int LoaiPhong,
             int DichVu, int ThucDon, int PhongBan, int KhuVuc, int ThongTinKhach, int ThongTinNV, int DanhSachHD, int ChucVu, int LichDonPhong,
             int TKCuaTui, int PhanQuyen)
        {
            SqlCommand cmd = new SqlCommand("sp_Insearch_PQ", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaTaiKhoan", MaTK));
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.Parameters.Add(new SqlParameter("@TrangChu", TrangChu));
            cmd.Parameters.Add(new SqlParameter("@TiepNhanKhach", TiepNhanKhach));
            cmd.Parameters.Add(new SqlParameter("@DanhSachPhong", DanhSachPhong));
            cmd.Parameters.Add(new SqlParameter("@LoaiPhong", LoaiPhong));
            cmd.Parameters.Add(new SqlParameter("@DichVu", DichVu));
            cmd.Parameters.Add(new SqlParameter("@ThucDon", ThucDon));
            cmd.Parameters.Add(new SqlParameter("@PhongBan", PhongBan));
            cmd.Parameters.Add(new SqlParameter("@KhuVuc", KhuVuc));
            cmd.Parameters.Add(new SqlParameter("@ThongTinKhach", ThongTinKhach));
            cmd.Parameters.Add(new SqlParameter("@ThongTinNV", ThongTinNV));
            cmd.Parameters.Add(new SqlParameter("@DanhSachHD", DanhSachHD));
            cmd.Parameters.Add(new SqlParameter("@ChucVu", ChucVu));
            cmd.Parameters.Add(new SqlParameter("@LichDonPhong", LichDonPhong));
            cmd.Parameters.Add(new SqlParameter("@TKCuaTui", TKCuaTui));
            cmd.Parameters.Add(new SqlParameter("@PhanQuyen", PhanQuyen));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            db.conn.Close();
            da.Fill(dt);
            return dt;
        }
    }
}