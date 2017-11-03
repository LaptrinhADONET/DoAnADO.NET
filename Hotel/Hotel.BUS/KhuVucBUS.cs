using Hotel.DAL;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class KhuVucBUS
    {
        private KhuVucDAL kvDAL = new KhuVucDAL();

        public List<KhuVuc> Get_By_Top(string Top, string Where, string Order, string tenbang)
        {
            return kvDAL.GetByTop(Top, Where, Order, tenbang);
        }
    }
}