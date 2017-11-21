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
    public class DGVDanhSachKhach
    {
        public static void dgv(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            DataGridViewTextBoxColumn text0 = new DataGridViewTextBoxColumn();
            text0.HeaderText = "Mã khách hàng";
            text0.DataPropertyName = "MaKH";
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tên khách hàng";
            text1.DataPropertyName = "TenKH";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Số điện thoại";
            text2.DataPropertyName = "SDT";
            DataGridViewTextBoxColumn text3 = new DataGridViewTextBoxColumn();
            text3.HeaderText = "Email";
            text3.DataPropertyName = "Email";
            DataGridViewTextBoxColumn text4 = new DataGridViewTextBoxColumn();
            text4.HeaderText = "Địa chỉ";
            text4.DataPropertyName = "DiaChi";
            DataGridViewTextBoxColumn text5 = new DataGridViewTextBoxColumn();
            text5.HeaderText = "Trạng thái";
            text5.DataPropertyName = "TrangThai";
            DataGridViewTextBoxColumn text6 = new DataGridViewTextBoxColumn();
            text6.HeaderText = "Chứng minh thư";
            text6.DataPropertyName = "CMT";
            DataGridViewTextBoxColumn text7 = new DataGridViewTextBoxColumn();
            text7.HeaderText = "Năm sinh";
            text7.DataPropertyName = "NamSinh";

            dgv.Columns.Add(text0);
            dgv.Columns.Add(text1);
            dgv.Columns.Add(text2);
            dgv.Columns.Add(text3);
            dgv.Columns.Add(text4);
            dgv.Columns.Add(text5);
            dgv.Columns.Add(text6);
            dgv.Columns.Add(text7);
        }

        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb, string tenbang)
        {
            KhachHangBUS khBUS = new KhachHangBUS();
            DataTable dt = new DataTable();
            dt = khBUS.GetByTop(top, where, order, tenbang);
            dgv.DataSource = dt;
            lb.Text = dt.Rows.Count.ToString();
        }

        public static void obj(DataGridView dgv, int r)
        {
            KhachHang obj = new KhachHang();
            obj.MaKH = dgv.Rows[r].Cells[0].Value.ToString();
            obj.TenKH = dgv.Rows[r].Cells[1].Value.ToString();
            obj.DiaChi = (dgv.Rows[r].Cells[2].Value.ToString());
            obj.SDT = dgv.Rows[r].Cells[3].Value.ToString();
            obj.Email = dgv.Rows[r].Cells[4].Value.ToString();
            obj.TrangThai = dgv.Rows[r].Cells[5].Value.ToString();
            obj.CMT = dgv.Rows[r].Cells[6].Value.ToString();
            obj.Ns = dgv.Rows[r].Cells[7].Value.ToString();
            Properties.Settings.Default.KhachHangObj = obj;
        }
    }
}