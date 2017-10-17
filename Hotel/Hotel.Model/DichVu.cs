using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class DichVu
    {
        private string _gia;
        private string _maDV;
        private string _tenDV;
        private string _trangThai;

        public string Gia
        {
            get
            {
                return _gia;
            }

            set
            {
                _gia = value;
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

        public string TenDV
        {
            get
            {
                return _tenDV;
            }

            set
            {
                _tenDV = value;
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

        public void DichVuIDataReader(SqlDataReader dr)
        {
            MaDV = dr["MaDV"] is DBNull ? string.Empty : dr["MaDV"].ToString();
            TenDV = dr["TenDV"] is DBNull ? string.Empty : dr["TenDV"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();
            Gia = dr["Gia"] is DBNull ? string.Empty : dr["Gia"].ToString();
        }
    }
}