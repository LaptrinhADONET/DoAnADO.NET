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
using Hotel.Dgv;

namespace Hotel.ListForm1
{
    public partial class frmDanhSachPhong : UserControl
    {
        private int a = Properties.Settings.Default.Flag;

        public frmDanhSachPhong()
        {
            InitializeComponent();
            switch (a)
            {
                case 2:
                    label2.Text = "Danh sách phòng";
                    DGVPhong.PhongDGV(dgvPhong);
                    DGVPhong.GetData(dgvPhong, "", "", "", lbSoLuong);
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 4:
                    label2.Text = "Dịch vụ";
                    DGVDichVu.dgv(dgvPhong);
                    DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "DichVu");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 5:
                    label2.Text = "Thực đơn";
                    DGVThucDon.dgv(dgvPhong);
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 6:
                    label2.Text = "Phòng ban";
                    DGVPhongBan.dgv(dgvPhong);
                    DGVPhongBan.GetData(dgvPhong, "", "", "", lbSoLuong, "PhongBan");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 9:
                    label2.Text = "Khu vực";
                    DGVKhuVuc.dgv(dgvPhong);
                    DGVKhuVuc.GetData(dgvPhong, "", "", "", lbSoLuong, "KhuVuc");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 11:
                    label2.Text = "Chức vụ";
                    DGVChucVu.dgv(dgvPhong);
                    DGVChucVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ChucVu");
                    Properties.Settings.Default.Flag = 2;
                    break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FlagLoaiPhong = 2;
            DanhSachPhong frm = new DanhSachPhong();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DGVPhong.GetData(dgvPhong, "", "", "", lbSoLuong);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FlagLoaiPhong = 1;
            DanhSachPhong frm = new DanhSachPhong();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DGVPhong.GetData(dgvPhong, "", "", "", lbSoLuong);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 2:
                    string str = " TenPhong LIKE '%" + txtTimKiem.Text + "%'";
                    DGVPhong.GetData(dgvPhong, "", str, "", lbSoLuong);
                    break;

                case 4:
                    label2.Text = "Dịch vụ";
                    Properties.Settings.Default.Flag = 0;
                    break;

                case 5:
                    label2.Text = "Thực đơn";
                    Properties.Settings.Default.Flag = 0;
                    break;

                case 6:
                    label2.Text = "Phòng ban";
                    Properties.Settings.Default.Flag = 0;
                    break;

                case 9:
                    label2.Text = "Khu vực";
                    Properties.Settings.Default.Flag = 0;
                    break;

                case 11:
                    label2.Text = "Chức vụ";
                    Properties.Settings.Default.Flag = 0;
                    break;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 2:
                    PhongBUS pBUS = new PhongBUS();
                    pBUS.Delete(int.Parse(Properties.Settings.Default.Phong.MaPhong));
                    DGVPhong.GetData(dgvPhong, "", "", "", lbSoLuong);
                    lbCheck.Text = "Xóa thành công";
                    lbCheck.ForeColor = Color.Green;
                    lbCheck.Visible = true;
                    break;

                case 4:

                    break;

                case 5:
                    label2.Text = "Thực đơn";
                    break;

                case 6:
                    label2.Text = "Phòng ban";
                    break;

                case 9:
                    label2.Text = "Khu vực";
                    break;

                case 11:
                    label2.Text = "Chức vụ";
                    break;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 2:
                    DGVPhong.GetData(dgvPhong, "", "", "", lbSoLuong);
                    txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 4:
                    DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "DichVu");
                    break;

                case 5:
                    break;

                case 6:

                    DGVPhongBan.GetData(dgvPhong, "", "", "", lbSoLuong, "PhongBan");

                    break;

                case 9:

                    DGVKhuVuc.GetData(dgvPhong, "", "", "", lbSoLuong, "KhuVuc");

                    break;

                case 11:

                    DGVChucVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ChucVu");

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Phong obj = new Phong();
            int r = e.RowIndex;
            if (r >= 0 && a == 2)
            {
                DGVPhong.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 4)
            {
                DGVPhong.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 5)
            {
                DGVPhong.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 6)
            {
                DGVPhong.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 9)
            {
                DGVPhong.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 11)
            {
                DGVPhong.obj(dgvPhong, r);
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmDanhSachPhong_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            lbCheck.Visible = false;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}