using Hotel.BUS;
using Hotel.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.ListForm2
{
    public partial class AddKhachHang : Form
    {
        private HotelEntities dbo = new HotelEntities();

        public AddKhachHang()
        {
            InitializeComponent();
        }

        private void AddKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddKhachHang_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FlagLoaiPhong != 1)
            {
                Model.KhachHang obj = new Model.KhachHang();
                obj = Properties.Settings.Default.KhachHangObj;
                txtDiaChi.Text = obj.DiaChi;
                txtEmail.Text = obj.Email;
                txtHoTen.Text = obj.TenKH;
                txtNamSinh.Text = obj.Ns;
                txtPass.Text = obj.CMT.ToString();
                txtSDT.Text = obj.SDT;
                cbGioiTinh.Text = obj.GioiTinh.ToString().Contains("1") ? "Nam" : "Nữ";
                cbTrangThai.Text = obj.TrangThai;
            }
            lbDiaChi.Visible = false;
            lbEmail.Visible = false;
            lbloiSDT.Visible = false;
            lbLoiTen.Visible = false;
            lbMatKhau.Visible = false;
            lbThem.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang obj = new KhachHang();
            Model.KhachHang obj1 = new Model.KhachHang();
            int n;
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                lbDiaChi.Visible = true;
            }
            else
            {
                obj.DiaChi = txtDiaChi.Text;
                obj1.DiaChi = txtDiaChi.Text;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lbloiSDT.Visible = true;
            }
            else
            {
                obj.Email = txtEmail.Text;
                obj1.Email = txtEmail.Text;
            }
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                lbLoiTen.Visible = true;
            }
            else
            {
                obj.TenKH = txtHoTen.Text;
                obj1.TenKH = txtHoTen.Text;
            }
            if (string.IsNullOrEmpty(txtNamSinh.Text))
            {
                lbloiSDT.Visible = true;
            }
            else
            {
                obj.NamSinh = int.Parse(txtNamSinh.Text);
                obj1.Ns = txtNamSinh.Text;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                lbMatKhau.Visible = true;
            }
            else
            {
                obj.CMT = int.Parse(txtPass.Text);
                obj1.CMT = txtPass.Text;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                lbloiSDT.Visible = true;
            }
            else
            {
                obj.SDT = txtSDT.Text;
                obj1.SDT = txtSDT.Text;
            }
            obj.TrangThai = cbTrangThai.Text.Contains("Hoạt động") ? "Hoạt động" : "Không hoạt động";
            obj1.TrangThai = cbTrangThai.Text.Contains("Hoạt động") ? "1" : "0";
            obj.GioiTinh = cbGioiTinh.Text.Contains("Nam") ? 1 : 0;
            obj1.GioiTinh = cbGioiTinh.Text.Contains("Nam") ? "1" : "0";
            obj1.MaKH = Properties.Settings.Default.KhachHangObj.MaKH;
            if (Properties.Settings.Default.FlagLoaiPhong == 1)
            {
                dbo.KhachHangs.Add(obj);
                dbo.SaveChanges();
            }
            else
            {
                KhachHangBUS khbus = new KhachHangBUS();
                khbus.Update(obj1);
            }
            lbThem.Visible = true;
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtNamSinh.Text = "";
            txtPass.Text = "";
            txtSDT.Text = "";
        }
    }
}