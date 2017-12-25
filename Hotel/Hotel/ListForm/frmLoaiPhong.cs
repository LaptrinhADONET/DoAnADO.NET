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
        public static bool flag;
        public static Model.LoaiPhong objLoai = new Model.LoaiPhong();
        private DataTable data = new DataTable();
        private List<Model.LoaiPhong> lp = new List<Model.LoaiPhong>();
        private LoaiPhongBUS lpBUS = new LoaiPhongBUS();

        public frmLoaiPhong()
        {
            InitializeComponent();
            btnXoa.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = true;
            pnMenuLoaiPhong.Controls.Clear();
            frmAddLoaiPhong frm = new frmAddLoaiPhong();
            pnMenuLoaiPhong.Controls.Add(frm);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Model.LoaiPhong lp = new Model.LoaiPhong();

            lp.TenLoaiPhong = txtTen.Text;
            // lpBUS.Get_By_Top("", "", "");
            string sql = "TenLoaiPhong LIKE '%" + txtTen.Text + "%'";
            getData("", sql, "");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!(objLoai == null))
            {
                lpBUS.Delete(int.Parse(objLoai.MaLoaiPhong));
                lbCheck.Visible = true;
                lbCheck.ForeColor = Color.Green;
                lbCheck.Text = "Xóa thành công";
                getData("", "", "");
            }
            else
            {
                objLoai = Properties.Settings.Default.LoaiPhong;
                lbCheck.ForeColor = Color.Red;
                lbCheck.Text = "Bạn chưa chọn dữ liệu để xóa";
                lbCheck.Visible = true;
                getData("", "", "");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            txtTen.Text = "Nhập tên loại...";
            getData("", "", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(objLoai == null))
            {
                flag = false;
                pnMenuLoaiPhong.Controls.Clear();
                frmAddLoaiPhong frm = new frmAddLoaiPhong();
                pnMenuLoaiPhong.Controls.Add(frm);
            }
            else
            {
                objLoai = Properties.Settings.Default.LoaiPhong;
                lbCheck.ForeColor = Color.Red;
                lbCheck.Text = "Bạn chưa chọn dữ liệu";
                lbCheck.Visible = true;
            }
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                objLoai.MaLoaiPhong = dgvLoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                objLoai.TenLoaiPhong = dgvLoaiPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                objLoai.GiaPhong = dgvLoaiPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                objLoai.TrangThai = dgvLoaiPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
                Properties.Settings.Default.LoaiPhong = objLoai;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            getData("", "", "");
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void getData(string top, string where, string order)
        {
            lp = lpBUS.Get_By_Top(top, where, order);
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
        }

        private void txtTen_MouseClick(object sender, MouseEventArgs e)
        {
            txtTen.Text = "";
        }
    }
}