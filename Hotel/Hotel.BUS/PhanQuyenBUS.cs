using Hotel.DAL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class PhanQuyenBUS
    {
        private PhanQuyenDAL PQDAL = new PhanQuyenDAL();

        public DataTable Get_By_Top()
        {
            return PQDAL.Get_By_Top();
        }

        public DataTable Get_By_Top1(string Email, string Pass)
        {
            return PQDAL.Get_By_Top1(Email, Pass);
        }

        public DataTable Insearch_PQ(string MaTK, int MaNV, int TrangChu, int TiepNhanKhach, int DanhSachPhong, int LoaiPhong, int DichVu, int ThucDon, int PhongBan, int KhuVuc, int ThongTinKhach, int ThongTinNV, int DanhSachHD, int ChucVu,
            int LichDonPhong, int TKCuaTui, int PhanQuyen)
        {
            return PQDAL.Insearch_PQ(MaTK, MaNV, TrangChu, TiepNhanKhach, DanhSachPhong, LoaiPhong,
            DichVu, ThucDon, PhongBan, KhuVuc, ThongTinKhach, ThongTinNV, DanhSachHD, ChucVu, LichDonPhong,
            TKCuaTui, PhanQuyen);
        }
    }
}