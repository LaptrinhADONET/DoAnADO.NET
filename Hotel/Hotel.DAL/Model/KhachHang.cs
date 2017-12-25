using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class KhachHang
    {
        private string _cMT;
        private string _diaChi;
        private string _email;
        private string _gioiTinh;
        private string _maKH;
        private string _ns;
        private string _sDT;
        private string _tenKH;
        private string _trangThai;

        public string CMT
        {
            get
            {
                return _cMT;
            }

            set
            {
                _cMT = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _gioiTinh;
            }

            set
            {
                _gioiTinh = value;
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

        public string Ns
        {
            get
            {
                return _ns;
            }

            set
            {
                _ns = value;
            }
        }

        public string SDT
        {
            get
            {
                return _sDT;
            }

            set
            {
                _sDT = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _tenKH;
            }

            set
            {
                _tenKH = value;
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

        public void KhachHangIDataReader(SqlDataReader dr)
        {
            MaKH = dr["MaKH"] is DBNull ? string.Empty : dr["MaKH"].ToString();
            TenKH = dr["TenKH"] is DBNull ? string.Empty : dr["TenKH"].ToString();
            DiaChi = dr["DiaChi"] is DBNull ? string.Empty : dr["DiaChi"].ToString();
            SDT = dr["SDT"] is DBNull ? string.Empty : dr["SDT"].ToString();
            Email = dr["Email"] is DBNull ? string.Empty : dr["Email"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();

            CMT = dr["CMT"] is DBNull ? string.Empty : dr["CMT"].ToString();
        }
    }
}