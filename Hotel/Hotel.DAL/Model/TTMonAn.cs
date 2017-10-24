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
    public class TTMonAn
    {
        private string _anh;
        private string _maMenu;
        private string _maMonAn;
        private string _moTa;
        private string _tenMonAn;

        public string Anh
        {
            get
            {
                return _anh;
            }

            set
            {
                _anh = value;
            }
        }

        public string MaMenu
        {
            get
            {
                return _maMenu;
            }

            set
            {
                _maMenu = value;
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

        public string TenMonAn
        {
            get
            {
                return _tenMonAn;
            }

            set
            {
                _tenMonAn = value;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dr"></param>
        public void TTMonAnIDataReader(SqlDataReader dr)
        {
            MaMonAn = dr["MaMonAn"] is DBNull ? string.Empty : dr["MaMonAn"].ToString();
            TenMonAn = dr["TenMonAn"] is DBNull ? string.Empty : dr["TenMonAn"].ToString();
            MoTa = dr["MoTa"] is DBNull ? string.Empty : dr["MoTa"].ToString();
            Anh = dr["Anh"] is DBNull ? string.Empty : dr["Anh"].ToString();
            MaMenu = dr["MaMenu"] is DBNull ? string.Empty : dr["MaMenu"].ToString();
        }
    }
}