using Hotel.DAL;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class DichVuBUS
    {
        private DichVuDAL obj = new DichVuDAL();

        public List<DichVu> GetByTop(string top, string where, string order, string tenbang)
        {
            return obj.GetByTop(top, where, order, tenbang);
        }
    }
}