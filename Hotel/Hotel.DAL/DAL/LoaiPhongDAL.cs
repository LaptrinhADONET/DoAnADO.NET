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
            List<LoaiPhong> lst = new List<LoaiPhong>();
            using (SqlCommand cmd = new SqlCommand("sp_LoaiPhong_Get_By_Top", db.GetConnection()))
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
                        LoaiPhong obj = new LoaiPhong();
                        obj.LoaiPhongIDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public override void Update(LoaiPhong obj)
        {
            throw new NotImplementedException();
        }
    }
}