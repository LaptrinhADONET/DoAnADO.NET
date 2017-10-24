using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;

namespace Hotel.DAL
{
    public class LichDonPhongDAL : Repository<LichDonPhong>
    {
        public override void Add(LichDonPhong obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(LichDonPhong obj)
        {
            throw new NotImplementedException();
        }

        public override List<LichDonPhong> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(LichDonPhong obj)
        {
            throw new NotImplementedException();
        }
    }
}