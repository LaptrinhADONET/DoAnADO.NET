using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    public class Phong
    {
        private string _anhPhong;
        private string _gia;
        private string _maBookRoom;
        private string _maLoaiPhong;
        private string _maPhong;
        private string _moTa;
        private string _nguoiLon;
        private string _tenPhong;
        private string _trangThai;
        private string _treEm;
        private string _viTri;

        public string AnhPhong
        {
            get
            {
                return _anhPhong;
            }

            set
            {
                _anhPhong = value;
            }
        }

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

        public string MoTa
        {
            get
            {
                return _moTa;
            }

            set
            {
                _moTa = value;
            }
        }

        public string NguoiLon
        {
            get
            {
                return _nguoiLon;
            }

            set
            {
                _nguoiLon = value;
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

        public string TreEm
        {
            get
            {
                return _treEm;
            }

            set
            {
                _treEm = value;
            }
        }

        public string ViTri
        {
            get
            {
                return _viTri;
            }

            set
            {
                _viTri = value;
            }
        }

        public void PhongIDataReader(SqlDataReader dr)
        {
            MaPhong = dr["MaPhong"] is DBNull ? string.Empty : dr["MaPhong"].ToString();
            TenPhong = dr["TenPhong"] is DBNull ? string.Empty : dr["TenPhong"].ToString();
            MaLoaiPhong = dr["MaLoaiPhong"] is DBNull ? string.Empty : dr["MaLoaiPhong"].ToString();
            AnhPhong = dr["AnhPhong"] is DBNull ? string.Empty : dr["AnhPhong"].ToString();
            MoTa = dr["MoTa"] is DBNull ? string.Empty : dr["MoTa"].ToString();
            ViTri = dr["ViTri"] is DBNull ? string.Empty : dr["ViTri"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();
            NguoiLon = dr["NguoiLon"] is DBNull ? string.Empty : dr["NguoiLon"].ToString();
            TreEm = dr["TreEm"] is DBNull ? string.Empty : dr["TreEm"].ToString();
            Gia = dr["Gia"] is DBNull ? string.Empty : dr["Gia"].ToString();
            MaBookRoom = dr["MaBookRoom"] is DBNull ? string.Empty : dr["MaBookRoom"].ToString();
        }
    }
}