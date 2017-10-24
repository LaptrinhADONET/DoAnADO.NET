using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class ChucVu
    {
        private string _hSLuong;
        private string _maCV;
        private string _tenCV;

        public string HSLuong
        {
            get
            {
                return _hSLuong;
            }

            set
            {
                _hSLuong = value;
            }
        }

        public string MaCV
        {
            get
            {
                return _maCV;
            }

            set
            {
                _maCV = value;
            }
        }

        public string TenCV
        {
            get
            {
                return _tenCV;
            }

            set
            {
                _tenCV = value;
            }
        }

        public void ChucVuIdataReader(SqlDataReader dr)
        {
            MaCV = dr["MaCV"] is DBNull ? string.Empty : dr["MaCV"].ToString();
            TenCV = dr["TenCV"] is DBNull ? string.Empty : dr["TenCV"].ToString();
            HSLuong = dr["HSLuong"] is DBNull ? string.Empty : dr["HSLuong"].ToString();
        }
    }
}