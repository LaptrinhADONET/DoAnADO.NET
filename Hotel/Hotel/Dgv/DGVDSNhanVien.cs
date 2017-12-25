using Hotel.BUS;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Dgv
{
    public class DGVDSNhanVien
    {
        public static void dgv(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            DataGridViewTextBoxColumn text0 = new DataGridViewTextBoxColumn();
            text0.HeaderText = "Mã nhân viên";
            text0.DataPropertyName = "MaNV";
            text0.Name = "MaNV";
            text0.Visible = false;
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tên nhân viên";
            text1.DataPropertyName = "TenNV";
            text1.Name = "TenNV";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Ngày sinh";
            text2.DataPropertyName = "NgaySinh";
            text2.Name = "NgaySinh";
            DataGridViewTextBoxColumn text3 = new DataGridViewTextBoxColumn();
            text3.HeaderText = "Địa chỉ";
            text3.DataPropertyName = "DiaChi";
            text3.Name = "DiaChi";
            DataGridViewTextBoxColumn text4 = new DataGridViewTextBoxColumn();
            text4.HeaderText = "Giới tính";
            text4.DataPropertyName = "gioitinh";
            text4.Name = "GioiTinh";
            DataGridViewTextBoxColumn text5 = new DataGridViewTextBoxColumn();
            text5.HeaderText = "Trạng thái";
            text5.DataPropertyName = "TrangThai";
            text5.Name = "TrangThai";
            DataGridViewTextBoxColumn text6 = new DataGridViewTextBoxColumn();
            text6.HeaderText = "Số điện thoại";
            text6.DataPropertyName = "SDT";
            text6.Name = "SDT";
            DataGridViewTextBoxColumn text7 = new DataGridViewTextBoxColumn();
            text7.HeaderText = "Email";
            text7.DataPropertyName = "Email";
            text7.Name = "Email";
            DataGridViewTextBoxColumn text8 = new DataGridViewTextBoxColumn();
            text8.HeaderText = "Ngày vào làm";
            text8.DataPropertyName = "NgayBDL";
            text8.Name = "NgayLam";
            DataGridViewTextBoxColumn text9 = new DataGridViewTextBoxColumn();
            text9.HeaderText = "Tên chức vụ";
            text9.DataPropertyName = "TenCV";
            text9.Name = "TenCV";
            DataGridViewTextBoxColumn text10 = new DataGridViewTextBoxColumn();
            text10.HeaderText = "Tên Phòng";
            text10.DataPropertyName = "TenPhongBan";
            text10.Name = "TenPhongBan";
            DataGridViewTextBoxColumn text11 = new DataGridViewTextBoxColumn();
            text11.HeaderText = "Mã chức vụ";
            text11.DataPropertyName = "MaCV";
            text11.Visible = false;
            text11.Name = "MaCV";
            DataGridViewTextBoxColumn text12 = new DataGridViewTextBoxColumn();
            text12.HeaderText = "Mã phòng ban";
            text12.DataPropertyName = "MaPhongBan";
            text12.Visible = false;
            text12.Name = "MaPhongBan";
            DataGridViewTextBoxColumn text13 = new DataGridViewTextBoxColumn();
            text13.HeaderText = "Mật khẩu";
            text13.DataPropertyName = "Password";
            text13.Name = "Pass";
            text13.Visible = false;
            DataGridViewTextBoxColumn text14 = new DataGridViewTextBoxColumn();
            text14.HeaderText = "Lương";
            text14.DataPropertyName = "Luong";
            text14.Name = "luong";

            dgv.Columns.Add(text0);
            dgv.Columns.Add(text1);
            dgv.Columns.Add(text2);
            dgv.Columns.Add(text3);
            dgv.Columns.Add(text4);
            dgv.Columns.Add(text5);
            dgv.Columns.Add(text6);
            dgv.Columns.Add(text7);
            dgv.Columns.Add(text8);
            dgv.Columns.Add(text9);
            dgv.Columns.Add(text10);
            dgv.Columns.Add(text11);
            dgv.Columns.Add(text12);
            dgv.Columns.Add(text13);
        }

        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb, string tenbang)
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            DataTable dt = new DataTable();
            dt = nvBUS.GetByTop(top, where, order, tenbang);
            dgv.DataSource = dt;
            lb.Text = dt.Rows.Count.ToString();
        }

        public static void obj(DataGridView dgv, int r)
        {
            NhanVien obj = new NhanVien();
            obj.TenNV = dgv.Rows[r].Cells["TenNV"].Value.ToString();
            obj.NgaySinh = dgv.Rows[r].Cells["NgaySinh"].Value.ToString();
            obj.DiaChi = dgv.Rows[r].Cells["DiaChi"].Value.ToString();
            obj.GioiTinh = dgv.Rows[r].Cells["GioiTinh"].Value.ToString();
            obj.SDT = dgv.Rows[r].Cells["SDT"].Value.ToString();
            obj.TenPhong = dgv.Rows[r].Cells["TenPhongBan"].Value.ToString();
            obj.TenCV = dgv.Rows[r].Cells["TenCV"].Value.ToString();
            obj.NgayBDL = dgv.Rows[r].Cells["NgayLam"].Value.ToString();
            obj.MaCV = dgv.Rows[r].Cells["MaCV"].Value.ToString();
            obj.MaPhongBan = dgv.Rows[r].Cells["MaPhongBan"].Value.ToString();
            obj.MaNV = dgv.Rows[r].Cells["MaNV"].Value.ToString();
            obj.Email = dgv.Rows[r].Cells["Email"].Value.ToString();
            obj.TrangThai = dgv.Rows[r].Cells["TrangThai"].Value.ToString();
            obj.Password = dgv.Rows[r].Cells["Pass"].Value.ToString();
            obj.Luong = dgv.Rows[r].Cells["Luong"].Value.ToString();

            Properties.Settings.Default.NhanVienObj = obj;
        }

        public static void viewData(DataGridView dgv, Label lb)
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            DataTable dt = new DataTable();
            dt = nvBUS.ViewData();
            dgv.DataSource = dt;
            lb.Text = dt.Rows.Count.ToString();
        }
    }
}