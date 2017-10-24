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
    public class ChucVuDAL : Repository<ChucVu>
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
            List<ChucVu> lst = new List<ChucVu>();
            using (SqlCommand cmd = new SqlCommand("sp_ChucVuGet_By_Top", db.GetConnection()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@top", Top));
                cmd.Parameters.Add(new SqlParameter("@where", Where));
                cmd.Parameters.Add(new SqlParameter("@order", Order));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ChucVu obj = new ChucVu();
                        obj.ChucVuIdataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public override void Update(ChucVu obj)
        {
            throw new NotImplementedException();
        }
    }
}