using Hotel.BUS;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Dgv
{
    public class DGVPhong
    {
        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb)
        {
            PhongBUS pBUS = new PhongBUS();
            dgv.DataSource = pBUS.GetByTop(top, where, order);
            lb.Text = pBUS.GetByTop(top, where, order).Rows.Count.ToString();
        }

        public static void obj(DataGridView dgv, int r)
        {
            Phong obj = new Phong();
            string tt = dgv.Rows[r].Cells[12].Value.ToString();
            if (tt == "Hoạt động")
            {
                obj.TrangThai = "1";
            }
            obj.TrangThai = "2";
            obj.MaPhong = dgv.Rows[r].Cells[0].Value.ToString();
            obj.TenPhong = dgv.Rows[r].Cells[1].Value.ToString();
            obj.MaLoaiPhong = dgv.Rows[r].Cells[2].Value.ToString();
            obj.AnhPhong = (byte[])(dgv.Rows[r].Cells[3].Value);
            obj.MoTa = dgv.Rows[r].Cells[4].Value.ToString();
            obj.ViTri = dgv.Rows[r].Cells[5].Value.ToString();
            obj.NguoiLon = dgv.Rows[r].Cells[6].Value.ToString();
            obj.TreEm = dgv.Rows[r].Cells[7].Value.ToString();
            obj.MaKV = dgv.Rows[r].Cells[8].Value.ToString();
            obj.TenKhuVuc = dgv.Rows[r].Cells[9].Value.ToString();
            obj.Gia = dgv.Rows[r].Cells[10].Value.ToString();
            obj.TenLoaiPhong = dgv.Rows[r].Cells[11].Value.ToString();
            Properties.Settings.Default.Phong = obj;
        }

        public static void PhongDGV(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            dgv.RowTemplate.Height = 80;
            DataGridViewImageColumn text0 = new DataGridViewImageColumn();
            text0.HeaderText = "Ảnh phòng";
            text0.DataPropertyName = "Anh";
            text0.ImageLayout = DataGridViewImageCellLayout.Stretch;
            text0.Visible = true;
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Mã phòng";
            text1.DataPropertyName = "MaPhong";
            text1.Visible = false;
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Tên phòng";
            text2.DataPropertyName = "TenPhong";
            text2.Visible = true;
            DataGridViewTextBoxColumn text3 = new DataGridViewTextBoxColumn();
            text3.HeaderText = "Giá phòng";
            text3.DataPropertyName = "GiaPhong";
            text3.Visible = true;
            DataGridViewTextBoxColumn text4 = new DataGridViewTextBoxColumn();
            text4.HeaderText = "Tên khu vực";
            text4.DataPropertyName = "TenKV";
            text4.Visible = true;
            DataGridViewTextBoxColumn text5 = new DataGridViewTextBoxColumn();
            text5.HeaderText = "Mã loại phòng";
            text5.DataPropertyName = "MaLoaiPhong";
            text5.Visible = false;
            DataGridViewTextBoxColumn text6 = new DataGridViewTextBoxColumn();
            text6.HeaderText = "Tên loại phòng";
            text6.DataPropertyName = "TenLoaiPhong";
            text6.Visible = true;
            DataGridViewTextBoxColumn text7 = new DataGridViewTextBoxColumn();
            text7.HeaderText = "Mô tả";
            text7.DataPropertyName = "MoTa";
            text7.Visible = true;
            DataGridViewTextBoxColumn text8 = new DataGridViewTextBoxColumn();
            text8.HeaderText = "Vị trí";
            text8.DataPropertyName = "ViTri";
            text8.Visible = true;
            DataGridViewTextBoxColumn text9 = new DataGridViewTextBoxColumn();
            text9.HeaderText = "Số người lớn";
            text9.DataPropertyName = "NguoiLon";
            text9.Visible = true;
            DataGridViewTextBoxColumn text10 = new DataGridViewTextBoxColumn();
            text10.HeaderText = "Số trẻ em";
            text10.DataPropertyName = "TreEm";
            text10.Visible = true;
            DataGridViewTextBoxColumn text11 = new DataGridViewTextBoxColumn();
            text11.HeaderText = "Mã khu vực";
            text11.DataPropertyName = "MaKV";
            text11.Visible = false;
            DataGridViewTextBoxColumn text12 = new DataGridViewTextBoxColumn();
            text12.HeaderText = "Trạng thái";
            text12.DataPropertyName = "TrangThai";
            text12.Visible = true;

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
            dgv.Columns[4].DisplayIndex = 12;
        }
    }
}