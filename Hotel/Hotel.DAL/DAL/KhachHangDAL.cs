using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.DAL
{
    public class KhachHangDAL : Repository<KhachHang>
    {
        public override void Add(KhachHang obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<KhachHang> Get_By_Top(string Top, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public DataTable GetByTop(string Top, string Where, string Order, string tenbang)
        {
            SqlCommand cmd = new SqlCommand("sp_Get_By_Top", db.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tenbang", tenbang));
            cmd.Parameters.Add(new SqlParameter("@top", Top));
            cmd.Parameters.Add(new SqlParameter("@where", Where));
            cmd.Parameters.Add(new SqlParameter("@order", Order));
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public override void Update(KhachHang obj)
        {
            throw new NotImplementedException();
        }
    }
}