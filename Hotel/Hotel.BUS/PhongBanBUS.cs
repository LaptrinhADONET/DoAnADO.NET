using Hotel.DAL;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class PhongBanBUS
    {
        private PhongBanDAL pbDAL = new PhongBanDAL();

        public List<PhongBan> Get_By_Top(string Top, string Where, string Order, string tenbang)
        {
            return pbDAL.Get_By_Top1(Top, Where, Order, tenbang);
        }
    }
}