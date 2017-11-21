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
using Hotel.ListForm2;
using Hotel.Repost;

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
                    btnXoa.Visible = true;
                    break;

                case 4:
                    label2.Text = "Dịch vụ";
                    btnIn.Visible = false;
                    DGVDichVu.dgv(dgvPhong);
                    DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "DichVu");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 5:
                    label2.Text = "Thực đơn";
                    btnIn.Visible = false;
                    DGVThucDon.dgv(dgvPhong);
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 6:
                    label2.Text = "Phòng ban";
                    btnIn.Visible = false;
                    DGVPhongBan.dgv(dgvPhong);
                    DGVPhongBan.GetData(dgvPhong, "", "", "", lbSoLuong, "PhongBan");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 7:
                    label2.Text = "Thông tin khách hàng";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 8:
                    label2.Text = "Thông tin nhân viên";
                    DGVDSNhanVien.dgv(dgvPhong);
                    DGVDSNhanVien.viewData(dgvPhong, lbSoLuong);
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 9:
                    label2.Text = "Khu vực";
                    btnIn.Visible = false;
                    DGVKhuVuc.dgv(dgvPhong);
                    DGVKhuVuc.GetData(dgvPhong, "", "", "", lbSoLuong, "KhuVuc");
                    Properties.Settings.Default.Flag = 2;

                    break;

                case 10:
                    label2.Text = "Thông tin hóa đơn";
                    btnSua.Visible = false;
                    btnThem.Visible = false;
                    DGVHoaDon.dgv(dgvPhong);
                    DGVHoaDon.GetData(dgvPhong, "", "", "", lbSoLuong, "HoaDon");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 11:
                    label2.Text = "Chức vụ";
                    btnIn.Visible = false;
                    DGVChucVu.dgv(dgvPhong);
                    DGVChucVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ChucVu");
                    Properties.Settings.Default.Flag = 2;
                    break;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 2:
                    Form1123 frmPhong = new Form1123();
                    frmPhong.ShowDialog();
                    break;

                case 4:
                    //DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "DichVu");
                    //txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 5:
                    //DGVThucDon.GetData(dgvPhong, "", "", "", lbSoLuong, "");
                    //txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 6:
                    //DGVPhongBan.GetData(dgvPhong, "", "", "", lbSoLuong, "PhongBan");
                    //txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 7:
                    KhachHang_rp frmkh = new KhachHang_rp();
                    frmkh.ShowDialog();
                    break;

                case 8:
                    NhanVien_rp frNVRP = new NhanVien_rp();
                    frNVRP.ShowDialog();
                    break;

                case 9:
                    //DGVKhuVuc.GetData(dgvPhong, "", "", "", lbSoLuong, "KhuVuc");
                    //txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 10:
                    HoaDon_RP HDRP = new HoaDon_RP();
                    HDRP.ShowDialog();
                    break;

                case 11:
                    //DGVChucVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ChucVu");
                    //txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 2:
                    Properties.Settings.Default.FlagLoaiPhong = 2;
                    DanhSachPhong frm = new DanhSachPhong();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DGVPhong.GetData(dgvPhong, "", "", "", lbSoLuong);
                    }
                    break;

                case 4:
                    Properties.Settings.Default.FlagLoaiPhong = 2;
                    frmDichVu frm4 = new frmDichVu();
                    if (frm4.ShowDialog() == DialogResult.OK)
                    {
                        DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "DichVu");
                    }
                    break;

                case 5:
                    //frmDichVu frm4 = new frmDichVu();
                    //if (frm4.ShowDialog() == DialogResult.OK)
                    //{
                    //    DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ThucDon");
                    //}
                    break;

                case 6:
                    Properties.Settings.Default.FlagLoaiPhong = 2;
                    frmphongban frm6 = new frmphongban();
                    if (frm6.ShowDialog() == DialogResult.OK)
                    {
                        DGVPhongBan.GetData(dgvPhong, "", "", "", lbSoLuong, "PhongBan");
                    }
                    break;

                case 7:
                    //if (frm4.ShowDialog() == DialogResult.OK)
                    //{
                    //    DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "Danhsachkhach");
                    //}
                    break;

                case 8:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 9:

                    Properties.Settings.Default.FlagLoaiPhong = 2;
                    frmKhuVuc frm9 = new frmKhuVuc();
                    if (frm9.ShowDialog() == DialogResult.OK)
                    {
                        DGVKhuVuc.GetData(dgvPhong, "", "", "", lbSoLuong, "KhuVuc");
                    }
                    break;

                case 10:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 11:

                    Properties.Settings.Default.FlagLoaiPhong = 2;
                    frmChucVu frm11 = new frmChucVu();
                    if (frm11.ShowDialog() == DialogResult.OK)
                    {
                        DGVChucVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ChucVu");
                    }
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 2:
                    Properties.Settings.Default.FlagLoaiPhong = 1;
                    DanhSachPhong frm = new DanhSachPhong();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DGVPhong.GetData(dgvPhong, "", "", "", lbSoLuong);
                    }
                    break;

                case 4:
                    Properties.Settings.Default.FlagLoaiPhong = 1;
                    frmDichVu frm4 = new frmDichVu();
                    if (frm4.ShowDialog() == DialogResult.OK)
                    {
                        DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "DichVu");
                    }
                    break;

                case 5:
                    Properties.Settings.Default.FlagLoaiPhong = 1;
                    //frmDichVu frm4 = new frmDichVu();
                    //if (frm4.ShowDialog() == DialogResult.OK)
                    //{
                    //    DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ThucDon");
                    //}
                    break;

                case 6:
                    Properties.Settings.Default.FlagLoaiPhong = 1;
                    frmphongban frm6 = new frmphongban();
                    if (frm6.ShowDialog() == DialogResult.OK)
                    {
                        DGVPhongBan.GetData(dgvPhong, "", "", "", lbSoLuong, "PhongBan");
                    }
                    break;

                case 7:
                    Properties.Settings.Default.FlagLoaiPhong = 1;

                    //if (frm4.ShowDialog() == DialogResult.OK)
                    //{
                    //    DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "Danhsachkhach");
                    //}
                    break;

                case 8:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 9:

                    Properties.Settings.Default.FlagLoaiPhong = 1;
                    frmKhuVuc frm9 = new frmKhuVuc();
                    if (frm9.ShowDialog() == DialogResult.OK)
                    {
                        DGVKhuVuc.GetData(dgvPhong, "", "", "", lbSoLuong, "KhuVuc");
                    }
                    break;

                case 10:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 11:

                    Properties.Settings.Default.FlagLoaiPhong = 1;
                    frmChucVu frm11 = new frmChucVu();
                    if (frm11.ShowDialog() == DialogResult.OK)
                    {
                        DGVChucVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ChucVu");
                    }
                    break;
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

                case 7:
                    label2.Text = "Danh sách khách";
                    Properties.Settings.Default.Flag = 0;
                    break;

                case 8:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 9:
                    label2.Text = "Khu vực";
                    Properties.Settings.Default.Flag = 0;
                    break;

                case 10:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
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
                    DGVDichVu.GetData(dgvPhong, "", "", "", lbSoLuong, "DichVu");
                    lbCheck.Text = "Xóa thành công";
                    lbCheck.ForeColor = Color.Green;
                    lbCheck.Visible = true;
                    break;

                case 5:
                    DGVThucDon.GetData(dgvPhong, "", "", "", lbSoLuong, "");
                    lbCheck.Text = "Xóa thành công";
                    lbCheck.ForeColor = Color.Green;
                    lbCheck.Visible = true;
                    break;

                case 6:
                    DGVPhongBan.GetData(dgvPhong, "", "", "", lbSoLuong, "PhongBan");
                    lbCheck.Text = "Xóa thành công";
                    lbCheck.ForeColor = Color.Green;
                    lbCheck.Visible = true;
                    break;

                case 7:
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "");
                    lbCheck.Text = "Xóa thành công";
                    lbCheck.ForeColor = Color.Green;
                    lbCheck.Visible = true;
                    break;

                case 8:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 9:
                    DGVKhuVuc.GetData(dgvPhong, "", "", "", lbSoLuong, "KhuVuc");
                    lbCheck.Text = "Xóa thành công";
                    lbCheck.ForeColor = Color.Green;
                    lbCheck.Visible = true;
                    break;

                case 10:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 11:
                    DGVChucVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ChucVu");
                    lbCheck.Text = "Xóa thành công";
                    lbCheck.ForeColor = Color.Green;
                    lbCheck.Visible = true;
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
                    txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 5:
                    DGVThucDon.GetData(dgvPhong, "", "", "", lbSoLuong, "");
                    txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 6:
                    DGVPhongBan.GetData(dgvPhong, "", "", "", lbSoLuong, "PhongBan");
                    txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 7:
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "");
                    txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 8:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 9:
                    DGVKhuVuc.GetData(dgvPhong, "", "", "", lbSoLuong, "KhuVuc");
                    txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;

                case 10:
                    label2.Text = "Thông tin nhân viên";
                    DGVDanhSachKhach.dgv(dgvPhong);
                    DGVDanhSachKhach.GetData(dgvPhong, "", "", "", lbSoLuong, "KhachHang");
                    Properties.Settings.Default.Flag = 2;
                    break;

                case 11:
                    DGVChucVu.GetData(dgvPhong, "", "", "", lbSoLuong, "ChucVu");
                    txtTimKiem.Text = "Nhập tìm kiếm...";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && a == 2)
            {
                DGVPhong.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 4)
            {
                DGVDichVu.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 5)
            {
                DGVThucDon.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 6)
            {
                DGVPhongBan.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 7)
            {
                DGVDanhSachKhach.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 8)
            {
                DGVDSNhanVien.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 9)
            {
                DGVKhuVuc.obj(dgvPhong, r);
            }
            if (r >= 0 && a == 11)
            {
                DGVChucVu.obj(dgvPhong, r);
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