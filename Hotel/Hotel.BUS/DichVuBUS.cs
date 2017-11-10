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
        private DichVuDAL dvDAL = new DichVuDAL();

        public void Add(DichVu obj)
        {
            dvDAL.Add(obj);
        }

        public List<DichVu> GetByTop(string top, string where, string order, string tenbang)
        {
            return dvDAL.GetByTop(top, where, order, tenbang);
        }

        public void Update(DichVu obj)
        {
            dvDAL.Update(obj);
        }
    }
}