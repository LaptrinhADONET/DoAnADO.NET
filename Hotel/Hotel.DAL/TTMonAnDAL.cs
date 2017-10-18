using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class TTMonAnDAL<TTMonAn> : Repository<TTMonAn>
    {
        public override void Add(TTMonAn obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(TTMonAn obj)
        {
            throw new NotImplementedException();
        }

        public override List<TTMonAn> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(TTMonAn obj)
        {
            throw new NotImplementedException();
        }
    }
}