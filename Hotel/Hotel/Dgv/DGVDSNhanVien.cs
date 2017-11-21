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
            text0.Visible = false;
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tên nhân viên";
            text1.DataPropertyName = "TenNV";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Ngày sinh";
            text2.DataPropertyName = "NgaySinh";
            DataGridViewTextBoxColumn text3 = new DataGridViewTextBoxColumn();
            text3.HeaderText = "Địa chỉ";
            text3.DataPropertyName = "DiaChi";
            DataGridViewTextBoxColumn text4 = new DataGridViewTextBoxColumn();
            text4.HeaderText = "Giới tính";
            text4.DataPropertyName = "gioitinh";
            DataGridViewTextBoxColumn text5 = new DataGridViewTextBoxColumn();
            text5.HeaderText = "Trạng thái";
            text5.DataPropertyName = "TrangThai";
            DataGridViewTextBoxColumn text6 = new DataGridViewTextBoxColumn();
            text6.HeaderText = "Số điện thoại";
            text6.DataPropertyName = "SDT";
            DataGridViewTextBoxColumn text7 = new DataGridViewTextBoxColumn();
            text7.HeaderText = "Email";
            text7.DataPropertyName = "Email";
            DataGridViewTextBoxColumn text8 = new DataGridViewTextBoxColumn();
            text8.HeaderText = "Ngày vào làm";
            text8.DataPropertyName = "NgayLam";
            DataGridViewTextBoxColumn text9 = new DataGridViewTextBoxColumn();
            text9.HeaderText = "Tên chức vụ";
            text9.DataPropertyName = "TenCV";
            DataGridViewTextBoxColumn text10 = new DataGridViewTextBoxColumn();
            text10.HeaderText = "Tên Phòng";
            text10.DataPropertyName = "TenPhongBan";
            DataGridViewTextBoxColumn text11 = new DataGridViewTextBoxColumn();
            text11.HeaderText = "Mã chức vụ";
            text11.DataPropertyName = "MaCV";
            text11.Visible = false;
            DataGridViewTextBoxColumn text12 = new DataGridViewTextBoxColumn();
            text12.HeaderText = "Mã phòng ban";
            text12.DataPropertyName = "MaPhongBan";
            text12.Visible = false;

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
            obj.TenNV = dgv.Rows[r].Cells[0].Value.ToString();
            obj.NgaySinh = dgv.Rows[r].Cells[1].Value.ToString();
            obj.DiaChi = dgv.Rows[r].Cells[2].Value.ToString();
            obj.GioiTinh = dgv.Rows[r].Cells[3].Value.ToString();
            obj.SDT = dgv.Rows[r].Cells[4].Value.ToString();
            obj.TenPhong = dgv.Rows[r].Cells[5].Value.ToString();
            obj.TenCV = dgv.Rows[r].Cells[6].Value.ToString();
            obj.NgayBDL = dgv.Rows[r].Cells[7].Value.ToString();
            obj.MaCV = dgv.Rows[r].Cells[8].Value.ToString();
            obj.MaPhongBan = dgv.Rows[r].Cells[9].Value.ToString();
            obj.MaNV = dgv.Rows[r].Cells[10].Value.ToString();
            obj.Email = dgv.Rows[r].Cells[11].Value.ToString();
            obj.TrangThai = dgv.Rows[r].Cells[12].Value.ToString();
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