using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class BookRoom
    {
        private string _maBookRoom;
        private string _maPhong;
        private string _soLuongKhach;
        private string _thoiGian;

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

        public string MaPhong
        {
            get
            {
                return _maPhong;
            }

            set
            {
                _maPhong = value;
            }
        }

        public string SoLuongKhach
        {
            get
            {
                return _soLuongKhach;
            }

            set
            {
                _soLuongKhach = value;
            }
        }

        public string ThoiGian
        {
            get
            {
                return _thoiGian;
            }

            set
            {
                _thoiGian = value;
            }
        }

        /// <summary>
        /// Reader property
        /// </summary>
        public void BookRoomIDataReader(SqlDataReader dr)
        {
            MaBookRoom = dr["MaBookRoom"] is DBNull ? string.Empty : dr["MaBookRoom"].ToString();
            MaPhong = dr["MaPhong"] is DBNull ? string.Empty : dr["MaPhong"].ToString();
            ThoiGian = dr["ThoiGian"] is DBNull ? string.Empty : dr["ThoiGian"].ToString();
            SoLuongKhach = dr["SoLuongKhach"] is DBNull ? string.Empty : dr["SoLuongKhach"].ToString();
        }
    }
}