using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    public class PhongBan
    {
        private string _maPhongBan;
        private string _tenPhongBan;
        private string _trangThai;

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

        public string TenPhongBan
        {
            get
            {
                return _tenPhongBan;
            }

            set
            {
                _tenPhongBan = value;
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

        public void PhongBanIDataReader(SqlDataReader dr)
        {
            MaPhongBan = dr["MaPhongBan"] is DBNull ? string.Empty : dr["MaPhongBan"].ToString();
            TenPhongBan = dr["TenPhongBan"] is DBNull ? string.Empty : dr["TenPhongBan"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();
        }
    }
}