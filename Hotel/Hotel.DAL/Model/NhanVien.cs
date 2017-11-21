using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    public class NhanVien
    {
        private string _diaChi;
        private string _email;
        private string _gioiTinh;
        private string _luong;
        private string _maCV;
        private string _maNV;
        private string _maPhongBan;
        private string _ngayBDL;
        private string _ngaySinh;
        private string _password;
        private string _sDT;
        private string _tenCV;
        private string _tenNV;
        private string _tenPhong;
        private string _trangThai;

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

        public string Luong
        {
            get
            {
                return _luong;
            }

            set
            {
                _luong = value;
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

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
            }
        }

        public string MaPhongBan
        {
            get
            {
                return _maPhongBan;
            }

            set
            {
                _maPhongBan = value;
            }
        }

        public string NgayBDL
        {
            get
            {
                return _ngayBDL;
            }

            set
            {
                _ngayBDL = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
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

        public string TenNV
        {
            get
            {
                return _tenNV;
            }

            set
            {
                _tenNV = value;
            }
        }

        public string TenPhong
        {
            get
            {
                return _tenPhong;
            }

            set
            {
                _tenPhong = value;
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="dr"></param>
        public void NhanVienIDataReader(SqlDataReader dr)
        {
            MaNV = dr["MaNV"] is DBNull ? string.Empty : dr["MaNV"].ToString();
            TenNV = dr["TenNV"] is DBNull ? string.Empty : dr["TenNV"].ToString();
            NgaySinh = dr["NgaySinh"] is DBNull ? string.Empty : dr["NgaySinh"].ToString();
            DiaChi = dr["DiaChi"] is DBNull ? string.Empty : dr["DiaChi"].ToString();
            GioiTinh = dr["GioiTinh"] is DBNull ? string.Empty : dr["GioiTinh"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();
            SDT = dr["SDT"] is DBNull ? string.Empty : dr["SDT"].ToString();
            Email = dr["Email"] is DBNull ? string.Empty : dr["Email"].ToString();
            NgayBDL = dr["NgayBDL"] is DBNull ? string.Empty : dr["NgayBDL"].ToString();
            Password = dr["Password"] is DBNull ? string.Empty : dr["Password"].ToString();
            Luong = dr["Luong"] is DBNull ? string.Empty : dr["Luong"].ToString();
            MaCV = dr["MaCV"] is DBNull ? string.Empty : dr["MaCV"].ToString();
        }
    }
}