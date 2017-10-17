using System;
using System.Data.SqlClient;

namespace Hotel.Model
{
    public class LichDonPhong
    {
        private string _maBookRoom;
        private string _maLich;
        private string _maNV;
        private string _ngayLam;
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

        public string MaLich
        {
            get
            {
                return _maLich;
            }

            set
            {
                _maLich = value;
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

        public string NgayLam
        {
            get
            {
                return _ngayLam;
            }

            set
            {
                _ngayLam = value;
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

        public void LichDonPhongIDataReader(SqlDataReader dr)
        {
            MaBookRoom = dr["MaBookRoom"] is DBNull ? string.Empty : dr["MaBookRoom"].ToString();
            MaNV = dr["MaNV"] is DBNull ? string.Empty : dr["MaNV"].ToString();
            NgayLam = dr["NgayLam"] is DBNull ? string.Empty : dr["NgayLam"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();
            MaLich = dr["MaLich"] is DBNull ? string.Empty : dr["MaLich"].ToString();
        }
    }
}