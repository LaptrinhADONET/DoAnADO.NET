using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class ChucVuDAL<ChucVu> : Repository<ChucVu>
    {
        public override void Add(ChucVu obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(ChucVu obj)
        {
            throw new NotImplementedException();
        }

        public override List<ChucVu> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(ChucVu obj)
        {
            throw new NotImplementedException();
        }
    }
}