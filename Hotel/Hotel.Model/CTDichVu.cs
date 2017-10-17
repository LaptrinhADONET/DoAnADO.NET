using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class CTDichVu
    {
        private string _maBookRoom;
        private string _maDV;
        private string _ngaySD;
        private string _soLuong;

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

        public string MaDV
        {
            get
            {
                return _maDV;
            }

            set
            {
                _maDV = value;
            }
        }

        public string NgaySD
        {
            get
            {
                return _ngaySD;
            }

            set
            {
                _ngaySD = value;
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

        public void CTDichVuIDataReader(SqlDataReader dr)
        {
            MaDV = dr["MaDV"] is DBNull ? string.Empty : dr["MaDV"].ToString();
            SoLuong = dr["SoLuong"] is DBNull ? string.Empty : dr["SoLuong"].ToString();
            NgaySD = dr["NgaySD"] is DBNull ? string.Empty : dr["NgaySD"].ToString();
            MaBookRoom = dr["MaBookRoom"] is DBNull ? string.Empty : dr["MaBookRoom"].ToString();
        }
    }
}