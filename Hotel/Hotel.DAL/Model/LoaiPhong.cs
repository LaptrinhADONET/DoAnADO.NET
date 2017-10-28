using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    public class LoaiPhong
    {
        private string _giaPhong;
        private string _maLoaiPhong;
        private string _tenLoaiPhong;
        private string _trangThai;

        public string GiaPhong
        {
            get
            {
                return _giaPhong;
            }

            set
            {
                _giaPhong = value;
            }
        }

        public string MaLoaiPhong
        {
            get
            {
                return _maLoaiPhong;
            }

            set
            {
                _maLoaiPhong = value;
            }
        }

        public string TenLoaiPhong
        {
            get
            {
                return _tenLoaiPhong;
            }

            set
            {
                _tenLoaiPhong = value;
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

        public void LoaiPhongIDataReader(SqlDataReader dr)
        {
            MaLoaiPhong = dr["MaLoaiPhong"] is DBNull ? string.Empty : dr["MaLoaiPhong"].ToString();
            TenLoaiPhong = dr["TenLoaiPhong"] is DBNull ? string.Empty : dr["TenLoaiPhong"].ToString();
            GiaPhong = dr["GiaPhong"] is DBNull ? string.Empty : dr["GiaPhong"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();
        }
    }
}