using Hotel.DAL;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL khDAL = new KhachHangDAL();

        public DataTable GetByTop(string Top, string Where, string Order, string tenbang)
        {
            return khDAL.GetByTop(Top, Where, Order, tenbang);
        }

        public void Update(KhachHang obj)
        {
            khDAL.Update(obj);
        }
    }
}