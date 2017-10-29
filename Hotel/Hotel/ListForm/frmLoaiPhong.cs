using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Model;
using Hotel.BUS;
using System.Reflection;
using Hotel.NewFolder1;
using System.Threading;

namespace Hotel.ListForm
{
    public partial class frmLoaiPhong : UserControl
    {
        public static LoaiPhong objLoai = new LoaiPhong();
        private DataTable data = new DataTable();
        private List<LoaiPhong> lp = new List<LoaiPhong>();
        private LoaiPhongBUS lpBUS = new LoaiPhongBUS();

        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnMenuLoaiPhong.Controls.Clear();
            frmAddLoaiPhong frm = new frmAddLoaiPhong();
            pnMenuLoaiPhong.Controls.Add(frm);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string a = Properties.Settings.Default.MaLoaiPhong.ToString();
            //MessageBox.Show(a);
            lpBUS.Delete(int.Parse(a));
            lbCheck.Visible = true;
            lbCheck.ForeColor = Color.Green;
            lbCheck.Text = "Xóa thành công";
            getData();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Properties.Settings.Default.MaLoaiPhong = int.Parse(dgvLoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            lp = lpBUS.Get_By_Top("", "", "");
            dgvLoaiPhong.DataSource = lp;
            lbSoLuong.Text = lp.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            lbCheck.Visible = false;
        }

        private void txtMa_MouseClick(object sender, MouseEventArgs e)
        {
            txtMa.Text = "";
        }

        private void txtTen_MouseClick(object sender, MouseEventArgs e)
        {
            txtTen.Text = "";
        }
    }
}