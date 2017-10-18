using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class CTDichVuDAL<CTDichVu> : Repository<CTDichVu>
    {
        public override void Add(CTDichVu obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(CTDichVu obj)
        {
            throw new NotImplementedException();
        }

        public override List<CTDichVu> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(CTDichVu obj)
        {
            throw new NotImplementedException();
        }
    }
}