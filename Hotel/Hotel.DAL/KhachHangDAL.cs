using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class KhachHangDAL<KhachHang> : Repository<KhachHang>
    {
        public override void Add(KhachHang obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(KhachHang obj)
        {
            throw new NotImplementedException();
        }

        public override List<KhachHang> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(KhachHang obj)
        {
            throw new NotImplementedException();
        }
    }
}