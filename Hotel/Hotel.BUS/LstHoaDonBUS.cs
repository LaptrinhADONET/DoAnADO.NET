using Hotel.DAL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class LstHoaDonBUS
    {
        private reposstLstHoaDon rp = new reposstLstHoaDon();

        public DataTable getdata()
        {
            return rp.getdata();
        }
    }
}