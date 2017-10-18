using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class VatDungDAL<VatDung> : Repository<VatDung>
    {
        public override void Add(VatDung obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(VatDung obj)
        {
            throw new NotImplementedException();
        }

        public override List<VatDung> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(VatDung obj)
        {
            throw new NotImplementedException();
        }
    }
}