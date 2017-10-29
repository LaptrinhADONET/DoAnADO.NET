using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.IRepository
{
    public interface IRepository<T>
    {
        void Add(T obj);

        void Delete(int ma);

        List<T> Get_By_Top(string Top, string Where, string Order);

        void Update(T obj);
    }
}