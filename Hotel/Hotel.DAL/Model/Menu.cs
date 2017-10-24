using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    public class Menu
    {
        private string _maBookRoom;
        private string _maMonAn;
        private string _soLuong;
        private string _trangThai;

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

        public string MaMonAn
        {
            get
            {
                return _maMonAn;
            }

            set
            {
                _maMonAn = value;
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

        public string TrangThai
        {
            get
            {
                return _trangThai;
            }

            set
            {
                _trangThai = value;
            }
        }

        public void MenuIDataReader(SqlDataReader dr)
        {
            MaBookRoom = dr["MaBookRoom"] is DBNull ? string.Empty : dr["MaBookRoom"].ToString();
            MaMonAn = dr["MaMonAn"] is DBNull ? string.Empty : dr["MaMonAn"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();
            SoLuong = dr["SoLuong"] is DBNull ? string.Empty : dr["SoLuong"].ToString();
        }
    }
}