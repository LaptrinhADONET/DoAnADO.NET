using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class NhanVienDAL<NhanVien> : Repository<NhanVien>
    {
        public override void Add(NhanVien obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(NhanVien obj)
        {
            throw new NotImplementedException();
        }

        public override List<NhanVien> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(NhanVien obj)
        {
            throw new NotImplementedException();
        }
    }
}