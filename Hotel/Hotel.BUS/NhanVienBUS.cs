using Hotel.DAL;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL NVDAL = new NhanVienDAL();

        public List<NhanVien> Login(string Email, string Pass)
        {
            return NVDAL.login(Email, Pass);
        }
    }
}