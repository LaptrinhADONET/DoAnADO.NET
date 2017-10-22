using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class KhuVucDAL<KhuVuc> : Repository<KhuVuc>
    {
        public override void Add(KhuVuc obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(KhuVuc obj)
        {
            throw new NotImplementedException();
        }

        public override List<KhuVuc> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(KhuVuc obj)
        {
            throw new NotImplementedException();
        }
    }
}