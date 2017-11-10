using Hotel.DAL;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class ChucVuBUS
    {
        private ChucVuDAL cmd = new ChucVuDAL();

        public void Add(ChucVu obj)
        {
            cmd.Add(obj);
        }

        public void Delete(int ma)
        {
            cmd.Delete(ma);
        }

        public List<ChucVu> Get_By_Top(string Top, string Where, string Order, string tenbang)
        {
            return cmd.Get_By_Top1(Top, Where, Order, tenbang);
        }

        public void Update(ChucVu obj)
        {
            cmd.Update(obj);
        }
    }
}