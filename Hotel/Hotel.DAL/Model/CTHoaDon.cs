using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class CTHoaDon
    {
        private string _maBookRoom;
        private string _maHD;
        private string _soLuong;
        private string _thanhTien;

        public string MaBookRoom
        {
            get
            {
                return _maBookRoom;
            }

            set
            {
                _maBookRoom = value;
            }
        }

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

        public string SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }

        public string ThanhTien
        {
            get
            {
                return _thanhTien;
            }

            set
            {
                _thanhTien = value;
            }
        }

        public void CTHoaDonIDataReader(SqlDataReader dr)
        {
            MaHD = dr["MaHD"] is DBNull ? string.Empty : dr["MaHD"].ToString();
            MaBookRoom = dr["MaBookRoom"] is DBNull ? string.Empty : dr["MaBookRoom"].ToString();
            SoLuong = dr["SoLuong"] is DBNull ? string.Empty : dr["SoLuong"].ToString();
            ThanhTien = dr["ThanhTien"] is DBNull ? string.Empty : dr["ThanhTien"].ToString();
        }
    }
}