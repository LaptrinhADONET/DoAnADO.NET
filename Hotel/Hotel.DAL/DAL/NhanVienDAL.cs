using Hotel.Model.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;

namespace Hotel.DAL
{
    public class NhanVienDAL : Repository<NhanVien>
    {
        public override void Add(NhanVien obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<NhanVien> Get_By_Top(string Top, string Where, string Order)
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

        public List<NhanVien> login(string Email, string Pass)
        {
            List<NhanVien> lst = new List<NhanVien>();
            using (SqlCommand cmd = new SqlCommand("sp_login", db.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email", Email));
                cmd.Parameters.Add(new SqlParameter("@pass", Pass));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        NhanVien obj = new NhanVien();
                        obj.NhanVienIDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public override void Update(NhanVien obj)
        {
            throw new NotImplementedException();
        }

        public DataTable ViewData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.vv_rpNhanVien", db.GetConnection());
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}