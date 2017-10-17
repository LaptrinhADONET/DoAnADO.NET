using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class CheckOut
    {
        private string _maBookRoom;
        private string _maKH;
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

        public string MaKH
        {
            get
            {
                return _maKH;
            }

            set
            {
                _maKH = value;
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

        public void CheckOutIDataReader(SqlDataReader dr)
        {
            MaKH = dr["MaKH"] is DBNull ? string.Empty : dr["MaKH"].ToString();
            SoLuong = dr["SoLuong"] is DBNull ? string.Empty : dr["SoLuong"].ToString();
            MaBookRoom = dr["MaBookRoom"] is DBNull ? string.Empty : dr["MaBookRoom"].ToString();
        }
    }
}