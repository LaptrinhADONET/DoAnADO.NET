using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;

namespace Hotel.DAL
{
    public class CTHoaDonDAL : Repository<CTHoaDon>
    {
        public override void Add(CTHoaDon obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<CTHoaDon> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(CTHoaDon obj)
        {
            throw new NotImplementedException();
        }
    }
}