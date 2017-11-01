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
    public class LoaiPhongBUS
    {
        private LoaiPhongDAL lp = new LoaiPhongDAL();

        public void Add(LoaiPhong obj)
        {
            lp.Add(obj);
        }

        public DataTable checkma(int ma)
        {
            return lp.checkma(ma);
        }

        public void Delete(int obj)
        {
            lp.Delete(obj);
        }

        public List<LoaiPhong> Get_By_Top(string Top, string Where, string Order)
        {
            return lp.Get_By_Top(Top, Where, Order);
        }

        public void Search(LoaiPhong obj)
        {
            lp.Search(obj);
        }

        public void Update(LoaiPhong obj)
        {
            lp.Update(obj);
        }
    }
}