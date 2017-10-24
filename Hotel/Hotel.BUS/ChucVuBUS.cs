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

        public List<ChucVu> Get_By_Top(string Top, string Where, string Order)
        {
            return cmd.Get_By_Top(Top, Where, Order);
        }
    }
}