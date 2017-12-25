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
    public class NhanVienBUS
    {
        private NhanVienDAL NVDAL = new NhanVienDAL();

        public DataTable GetByTop(string Top, string Where, string Order, string tenbang)
        {
            return NVDAL.GetByTop(Top, Where, Order, tenbang);
        }

        public List<NhanVien> Login(string Email, string Pass)
        {
            return NVDAL.login(Email, Pass);
        }

        public void Update(NhanVien obj)
        {
            NVDAL.Update(obj);
        }

        public DataTable ViewData()
        {
            return NVDAL.ViewData();
        }
    }
}