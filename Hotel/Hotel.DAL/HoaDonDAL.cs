using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class HoaDonDAL<HoaDon> : Repository<HoaDon>
    {
        public override void Add(HoaDon obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(HoaDon obj)
        {
            throw new NotImplementedException();
        }

        public override List<HoaDon> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(HoaDon obj)
        {
            throw new NotImplementedException();
        }
    }
}