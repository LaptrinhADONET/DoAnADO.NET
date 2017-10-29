using Hotel.Model;
using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    public class BookRoomDAL : Repository<BookRoom>
    {
        public override void Add(BookRoom obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int ma)
        {
            throw new NotImplementedException();
        }

        public override List<BookRoom> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public override void Update(BookRoom obj)
        {
            throw new NotImplementedException();
        }
    }
}