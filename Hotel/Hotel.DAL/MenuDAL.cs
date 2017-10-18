using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class MenuDAL<Menu> : Repository<Menu>
    {
        public override void Add(Menu obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Menu obj)
        {
            throw new NotImplementedException();
        }

        public override List<Menu> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(Menu obj)
        {
            throw new NotImplementedException();
        }
    }
}