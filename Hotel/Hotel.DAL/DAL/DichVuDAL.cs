using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;
using System.Data.SqlClient;

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

        public List<DichVu> GetByTop(string top, string where, string order, string tenbang)
        {
            db.conn.Close();
            List<DichVu> lst = new List<DichVu>();
            SqlCommand cmd = new SqlCommand("sp_Get_By_Top", db.GetConnection());

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tenbang", tenbang));
            cmd.Parameters.Add(new SqlParameter("@top", top));
            cmd.Parameters.Add(new SqlParameter("@where", where));
            cmd.Parameters.Add(new SqlParameter("@order", order));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DichVu obj = new DichVu();
                    obj.DichVuIDataReader(dr);
                    lst.Add(obj);
                }
            }

            return lst;
        }

        public override void Update(DichVu obj)
        {
            throw new NotImplementedException();
        }
    }
}