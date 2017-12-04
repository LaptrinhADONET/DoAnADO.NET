using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Dgv
{
    public class dgvDatPhong
    {
        private DBContect db = new DBContect();

        public void getcmbDichVu(ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(" SELECT * FROM dbo.DichVu", db.GetConnection());
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cb.DataSource = dt;
            cb.DisplayMember = "TenDV";
            cb.ValueMember = "MaDV";
        }

        public void getcmbKH(ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(" SELECT * FROM dbo.KhachHang", db.GetConnection());
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cb.DataSource = dt;
            cb.DisplayMember = "TenKH";
            cb.ValueMember = "MaKH";
        }

        public void getcmbPhong(ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.vv_Phong", db.GetConnection());
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cb.DataSource = dt;
            cb.DisplayMember = "TenPhong";
            cb.ValueMember = "TenPhong";
        }

        public DataTable getKH(string ma)
        {
            KhachHang obj = new KhachHang();
            string str = " SELECT* FROM dbo.DisplayKH where MaKH = " + ma;
            SqlCommand cmd = new SqlCommand(str, db.GetConnection());
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}