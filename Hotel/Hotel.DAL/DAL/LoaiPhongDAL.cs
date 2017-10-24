using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;

namespace Hotel.DAL
{
    public class LoaiPhongDAL : Repository<LoaiPhong>
    {
        public override void Add(LoaiPhong obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(LoaiPhong obj)
        {
            throw new NotImplementedException();
        }

        public override List<LoaiPhong> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(LoaiPhong obj)
        {
            throw new NotImplementedException();
        }
    }
}