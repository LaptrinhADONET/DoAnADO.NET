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
using Hotel.Model;
using System.Diagnostics.Contracts;
using Hotel.BUS;

namespace Hotel.ListForm2
{
    public partial class AddNV : Form
    {
        public HotelEntities dbo = new HotelEntities();

        public AddNV()
        {
            InitializeComponent();
        }

        private void AddNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddNV_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FlagLoaiPhong != 1)
            {
                Model.NhanVien obj = new Model.NhanVien();
                obj = Properties.Settings.Default.NhanVienObj;
                txtHoTen.Text = obj.TenNV;
                txtDiaChi.Text = obj.DiaChi;
                txtEmail.Text = obj.Email;
                txtPass.Text = obj.Password;
                txtSDT.Text = obj.SDT;
                cbGioiTinh.Text = obj.GioiTinh;
                cbTrangThai.Text = obj.TrangThai;
                txtPass.Text = obj.Password;
                //MessageBox.Show(obj.Password);
            }

            cbChucVu.DataSource = dbo.ChucVus.ToList();
            cbPhongBan.DataSource = dbo.PhongBans.ToList();

            lbloiSDT.Visible = false;
            lbLoiTen.Visible = false;
            lbDiaChi.Visible = false;
            lbEmail.Visible = false;
            lbMatKhau.Visible = false;
            lbThem.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NewFolder1.NhanVien obj = new NewFolder1.NhanVien();
            Model.NhanVien obj1 = new Model.NhanVien();
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                lbLoiTen.Visible = true;
            }
            else
            {
                obj.TenNV = txtHoTen.Text;
                obj1.TenNV = txtHoTen.Text;
            }
            int n;
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                lbloiSDT.Visible = true;
            }
            else
            {
                obj.SDT = int.Parse(txtSDT.Text);
                obj1.SDT = txtSDT.Text.ToString();
            }

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
                lbEmail.Visible = true;
            }
            else
            {
                obj.Email = txtEmail.Text;
                obj1.Email = txtEmail.Text;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                lbMatKhau.Visible = true;
            }
            else
            {
                obj.Password = txtPass.Text;
                obj1.Password = txtPass.Text;
            }
            obj.MaPhongBan = int.Parse(cbPhongBan.SelectedValue.ToString());
            obj1.MaPhongBan = cbPhongBan.SelectedValue.ToString();
            obj.MaCV = int.Parse(cbChucVu.SelectedValue.ToString());
            obj1.MaCV = cbChucVu.SelectedValue.ToString();
            obj.TrangThai = cbTrangThai.Text.ToString().Contains("Hoạt động") ? true : false;
            obj1.TrangThai = cbTrangThai.Text.ToString().Contains("Hoạt động") ? "Hoạt động" : "Không hoạt động";
            obj.GioiTinh = cbGioiTinh.Text.ToString().Contains("Nam") ? 1 : 0;
            obj1.GioiTinh = cbGioiTinh.Text.ToString().Contains("Nam") ? "Nam" : "Nữ";
            obj.NgayBDL = DateTime.Parse(dateNgayBatDau.Value.ToString());
            obj1.NgayBDL = dateNgayBatDau.Value.ToString();
            obj.NgaySinh = DateTime.Parse(dateNgaySinh.Value.ToString());
            obj1.NgaySinh = dateNgaySinh.Value.ToString();
            obj1.MaNV = Properties.Settings.Default.NhanVienObj.MaNV;

            if (Properties.Settings.Default.FlagLoaiPhong == 1)
            {
                dbo.NhanViens.Add(obj);
                dbo.SaveChanges();
            }
            else
            {
                NhanVienBUS nvbus = new NhanVienBUS();
                nvbus.Update(obj1);
                this.Close();
            }

            lbThem.Visible = true;
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtPass.Text = "";
            txtSDT.Text = "";
            lbloiSDT.Visible = false;
            lbLoiTen.Visible = false;
            lbDiaChi.Visible = false;
            lbEmail.Visible = false;
            lbMatKhau.Visible = false;
            lbThem.Visible = false;
        }
    }
}