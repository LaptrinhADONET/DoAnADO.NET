using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;

namespace Hotel.DAL
{
    public class DichVuDAL : Repository<DichVu>
    {
        public override void Add(DichVu obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<DichVu> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(DichVu obj)
        {
            throw new NotImplementedException();
        }
    }
}