using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Hotel.Model;
using System.Data.SqlClient;

namespace Hotel.ListForm
{
    public partial class TrangChu : UserControl
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void DemSL(string SQL, Label lcb)
        {
            DBContect db = new DBContect();
            SqlCommand cmd = new SqlCommand(SQL, db.GetConnection());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lcb.Text = dt.Rows.Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            DemSL(" SELECT * FROM dbo.vv_sl", lbTrong);
            DemSL(" SELECT * from dbo.vv_SLSD", lbDangSD);
            DemSL(" SELECT * FROM dbo.vv_KHD", lbDonDep);
        }
    }
}