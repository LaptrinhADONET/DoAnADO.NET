using Hotel.Model;
using Hotel.Repost;
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
    public partial class NhanVien_rp : Form
    {
        public NhanVien_rp()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            DBContect db = new DBContect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.vv_rpNhanVienShow", db.GetConnection());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Nhan_Vien_RP1.SetDataSource(dt);
            cryNhanVien.ReportSource = Nhan_Vien_RP1;
        }
    }
}