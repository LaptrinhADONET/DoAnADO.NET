using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;

namespace Hotel.DAL
{
    public class PhongBanDAL : Repository<PhongBan>
    {
        public override void Add(PhongBan obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(PhongBan obj)
        {
            throw new NotImplementedException();
        }

        public override List<PhongBan> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(PhongBan obj)
        {
            throw new NotImplementedException();
        }
    }
}