using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL hdDal = new HoaDonDAL();

        public DataTable GetByTop(string Top, string Where, string Order, string tenbang)
        {
            return hdDal.GetByTop(Top, Where, Order, tenbang);
        }
    }
}