using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class HoaDon
    {
        private string _maHD;
        private string _ngayThanhToan;
        private string _tongTien;

        public string MaHD
        {
            get
            {
                return _maHD;
            }

            set
            {
                _maHD = value;
            }
        }

        public string NgayThanhToan
        {
            get
            {
                return _ngayThanhToan;
            }

            set
            {
                _ngayThanhToan = value;
            }
        }

        public string TongTien
        {
            get
            {
                return _tongTien;
            }

            set
            {
                _tongTien = value;
            }
        }

        public void HoaDonIDataReader(SqlDataReader dr)
        {
            MaHD = dr["MaHD"] is DBNull ? string.Empty : dr["MaHD"].ToString();
            TongTien = dr["TongTien"] is DBNull ? string.Empty : dr["TongTien"].ToString();
            NgayThanhToan = dr["NgayThanhToan"] is DBNull ? string.Empty : dr["NgayThanhToan"].ToString();
        }
    }
}