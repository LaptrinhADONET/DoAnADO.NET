using Hotel.Model;
using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class CheckOutDAL : Repository<CheckOut>
    {
        public override void Add(CheckOut obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(CheckOut obj)
        {
            throw new NotImplementedException();
        }

        public override List<CheckOut> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(CheckOut obj)
        {
            throw new NotImplementedException();
        }
    }
}