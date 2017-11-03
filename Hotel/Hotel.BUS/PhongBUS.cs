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
    public class PhongBUS

    {
        private PhongDAL pDAL = new PhongDAL();

        public void Add(Phong obj)
        {
            pDAL.Add(obj);
        }

        public void Delete(int obj)
        {
            pDAL.Delete(obj);
        }

        public DataTable GetByTop(string top, string where, string order)
        {
            return pDAL.Get_By_Top1(top, where, order);
        }

        public DataTable loadcb(string ma, string ten, string tenbang)
        {
            return pDAL.loadcb(ma, ten, tenbang);
        }

        public void Update(Phong obj)
        {
            pDAL.Update(obj);
        }
    }
}