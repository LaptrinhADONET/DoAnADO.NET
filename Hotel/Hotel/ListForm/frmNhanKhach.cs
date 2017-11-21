using Hotel.BUS;
using Hotel.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmNhanKhach : UserControl
    {
        private Button[,] btn;

        private int flag;

        public frmNhanKhach()
        {
            InitializeComponent();
            txtTenPhong.Enabled = false;
            txtGia.Enabled = false;
            txtViTri.Enabled = false;
            txtNguoiLon.Enabled = false;
            txtTreEm.Enabled = false;
            txtTenKhuVuc.Enabled = false;
            txtTrangThai.Enabled = false;
            ve();
            lbName.Text = "Tiếp nhận khách";
        }

        private DataTable abc()
        {
            DBContect db = new DBContect();
            SqlCommand cmd = new SqlCommand("SELECT * from dbo.vv_SLSD", db.GetConnection());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            txtTenPhong.Text = "";
            txtGia.Text = "";
            txtViTri.Text = "";
            txtNguoiLon.Text = "";
            txtTreEm.Text = "";
            txtTenKhuVuc.Text = "";
            txtTrangThai.Text = "";

            picPhong.Image = null;
            PhongBUS pBUS = new PhongBUS();
            DataTable dt = new DataTable();
            dt = pBUS.GetByTop("", "", "");
            Button btn = (Button)sender;
            string[] vt = btn.Tag.ToString().Split(',');
            int i = int.Parse(vt[0]);
            int j = int.Parse(vt[1]);

            txtTenPhong.Text = (dt.Rows[i * 10 + j][1].ToString());
            txtGia.Text = (dt.Rows[i * 10 + j][10].ToString());
            txtViTri.Text = (dt.Rows[i * 10 + j][5].ToString());
            txtNguoiLon.Text = (dt.Rows[i * 10 + j][6].ToString());
            txtTreEm.Text = (dt.Rows[i * 10 + j][7].ToString());
            txtTenKhuVuc.Text = (dt.Rows[i * 10 + j][9].ToString());
            txtTrangThai.Text = (dt.Rows[i * 10 + j][12].ToString());
            if (!(dt.Rows[i * 10 + j][3].ToString() == ""))
            {
                byte[] MyData = new byte[0];
                MyData = (byte[])((dt.Rows[i * 10 + j][3]));
                MemoryStream stream = new MemoryStream(MyData);
                picPhong.Image = Image.FromStream(stream);
            }
        }

        private void grbDanhsach_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ve()
        {
            PhongBUS pBUS = new PhongBUS();
            int count = pBUS.SoLuongPhong();
            btn = new Button[12, 12];
            int k = 10;
            int flag = 0;
            DataTable dt = new DataTable();
            dt = pBUS.GetByTop("", "", "");
            for (int i = 0; i < count / 10 + 1; i++)
            {
                if (i == count / 10)
                {
                    k = count % 10;
                }
                for (int j = 0; j < k; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Location = new System.Drawing.Point(5 + j + 70 * j, 30 + i + i * 70);
                    btn[i, j].Size = new System.Drawing.Size(70, 60);
                    btn[i, j].Text = dt.Rows[flag][1].ToString();
                    btn[i, j].TextAlign = ContentAlignment.BottomCenter;
                    btn[i, j].Image = Properties.Resources.Bed_30px;
                    btn[i, j].ImageAlign = ContentAlignment.TopCenter;
                    btn[i, j].Tag = "" + i + "," + j + "";
                    btn[i, j].MouseHover += new System.EventHandler(this.button1_MouseHover);
                    if (dt.Rows[flag][12].ToString() == "Hoạt Động")
                    {
                        btn[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(39)))));
                    }
                    if (dt.Rows[flag][12].ToString() == "Không hoạt Động")
                    {
                        btn[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(41)))));
                    }
                    for (int u = 0; u < abc().Rows.Count; u++)
                    {
                        if (abc().Rows[u][0].ToString() == dt.Rows[flag][0].ToString())
                        {
                            btn[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(185)))), ((int)(((byte)(26)))));
                        }
                    }
                    grbDanhsach.Controls.Add(btn[i, j]);
                    flag++;
                }
            }
        }
    }
}