using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class PhongDAL<Phong> : Repository<Phong>
    {
        public override void Add(Phong obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Phong obj)
        {
            throw new NotImplementedException();
        }

        public override List<Phong> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(Phong obj)
        {
            throw new NotImplementedException();
        }
    }
}