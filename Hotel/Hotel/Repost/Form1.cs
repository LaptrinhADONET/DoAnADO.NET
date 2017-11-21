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
    public partial class Form1123 : Form
    {
        public Form1123()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            DataTable dt = new DataTable();
            DBContect db = new DBContect();
            string a = "SELECT * FROM dbo.vv_rpPhong";
            SqlCommand cmd = new SqlCommand(a, db.GetConnection());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            RpPhong1.SetDataSource(dt);
            crystalReportViewer1.ReportSource = RpPhong1;
        }
    }
}