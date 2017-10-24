using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    public class KhuVuc
    {
        private string _maKV;
        private string _moTa;
        private string _tenKV;

        public string MaKV
        {
            get
            {
                return _maKV;
            }

            set
            {
                _maKV = value;
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

        public string TenKV
        {
            get
            {
                return _tenKV;
            }

            set
            {
                _tenKV = value;
            }
        }

        public void KhuVucIdataReader(SqlDataReader dr)
        {
            MaKV = dr["MaKV"] is DBNull ? string.Empty : dr["MaKV"].ToString();
            TenKV = dr["TenKV"] is DBNull ? string.Empty : dr["TenKV"].ToString();
            MoTa = dr["MoTa"] is DBNull ? string.Empty : dr["MoTa"].ToString();
        }
    }
}