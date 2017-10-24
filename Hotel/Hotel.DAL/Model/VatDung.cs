using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    /// <summary>
    ///
    /// </summary>
    public class VatDung
    {
        private string _kichThuoc;
        private string _maPhong;
        private string _maVD;
        private string _sLGiuong;
        private string _trangThai;
        private string _tTWifi;

        public string KichThuoc
        {
            get
            {
                return _kichThuoc;
            }

            set
            {
                _kichThuoc = value;
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

        public string MaVD
        {
            get
            {
                return _maVD;
            }

            set
            {
                _maVD = value;
            }
        }

        public string SLGiuong
        {
            get
            {
                return _sLGiuong;
            }

            set
            {
                _sLGiuong = value;
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

        public string TTWifi
        {
            get
            {
                return _tTWifi;
            }

            set
            {
                _tTWifi = value;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dr"></param>
        public void VatDungIDataReader(SqlDataReader dr)
        {
            MaVD = dr["MaVD"] is DBNull ? string.Empty : dr["MaVD"].ToString();
            MaPhong = dr["MaPhong"] is DBNull ? string.Empty : dr["MaPhong"].ToString();
            KichThuoc = dr["KichThuoc"] is DBNull ? string.Empty : dr["KichThuoc"].ToString();
            TTWifi = dr["TTWifi"] is DBNull ? string.Empty : dr["TTWifi"].ToString();
            SLGiuong = dr["SLGiuong"] is DBNull ? string.Empty : dr["SLGiuong"].ToString();
            TrangThai = dr["TrangThai"] is DBNull ? string.Empty : dr["TrangThai"].ToString();
        }
    }
}