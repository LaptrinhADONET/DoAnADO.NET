using Hotel.DAL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class PhanQuyenBUS
    {
        private PhanQuyenDAL PQDAL = new PhanQuyenDAL();

        public DataTable Get_By_Top(string top, string where, string order)
        {
            return PQDAL.Get_By_Top(top, where, order);
        }
    }
}