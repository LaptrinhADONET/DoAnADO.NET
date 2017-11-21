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
    public partial class HoaDon_RP : Form
    {
        public HoaDon_RP()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            DBContect db = new DBContect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.vv_HoaDon", db.GetConnection());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            HoaDon_RP_View1.SetDataSource(dt);
            cryHoaDon.ReportSource = HoaDon_RP_View1;
        }
    }
}