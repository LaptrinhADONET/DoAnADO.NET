using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;

namespace Hotel.DAL
{
    public class PhongDAL : Repository<Phong>
    {
        public override void Add(Phong obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int obj)
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