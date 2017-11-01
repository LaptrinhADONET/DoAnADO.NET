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

        public DataTable Get_By_Top1(string Top, string Where, string Order)
        {
            return pDAL.Get_By_Top1(Top, Where, Order);
        }

        public List<Phong> GetByTop(string top, string where, string order)
        {
            return pDAL.Get_By_Top(top, where, order);
        }

        public DataTable loadcb(string ma, string ten, string tenbang)
        {
            return pDAL.loadcb(ma, ten, tenbang);
        }
    }
}