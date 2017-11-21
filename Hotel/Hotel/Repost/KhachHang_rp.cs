using Hotel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Repost
{
    public partial class KhachHang_rp : Form
    {
        public KhachHang_rp()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            DBContect db = new DBContect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.vv_rpKhachHang", db.GetConnection());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Rp_KhachHang1.SetDataSource(dt);
            rpKhachHang.ReportSource = Rp_KhachHang1;
        }
    }
}