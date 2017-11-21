using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Dgv
{
    public class DGVThucDon
    {
        public static void dgv(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            DataGridViewTextBoxColumn text0 = new DataGridViewTextBoxColumn();
            text0.HeaderText = "Mã đặt phòng";
            text0.DataPropertyName = "MaBookRoom";
            text0.Visible = false;
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tên phòng";
            text1.DataPropertyName = "TenPhong";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Mã món ăn";
            text2.DataPropertyName = "MaMonAn";
            DataGridViewTextBoxColumn text3 = new DataGridViewTextBoxColumn();
            text3.HeaderText = "Tên món ăn";
            text3.DataPropertyName = "TenMonAn";
            text3.Visible = false;
            DataGridViewTextBoxColumn text4 = new DataGridViewTextBoxColumn();
            text4.HeaderText = "Số lượng";
            text4.DataPropertyName = "SoLuong";
            DataGridViewTextBoxColumn text5 = new DataGridViewTextBoxColumn();
            text5.HeaderText = "Thành tiền";
            text5.DataPropertyName = "ThanhTien";
            DataGridViewTextBoxColumn text6 = new DataGridViewTextBoxColumn();
            text6.HeaderText = "Trạng thái";
            text6.DataPropertyName = "TrangThai";
            dgv.Columns.Add(text0);
            dgv.Columns.Add(text1);
            dgv.Columns.Add(text2);
            dgv.Columns.Add(text3);
            dgv.Columns.Add(text4);
            dgv.Columns.Add(text5);
            dgv.Columns.Add(text6);
        }

        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb, string tenbang)
        {
        }

        public static void obj(DataGridView dgv, int r)
        {
        }
    }
}