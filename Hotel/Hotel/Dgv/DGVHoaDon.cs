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
    public class DGVHoaDon
    {
        public static void dgv(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            DataGridViewTextBoxColumn text0 = new DataGridViewTextBoxColumn();
            text0.HeaderText = "Mã hóa đơn";
            text0.DataPropertyName = "MaHD";
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tổng tiền";
            text1.DataPropertyName = "TongTien";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Ngày thanh toán";
            text2.DataPropertyName = "NgayThanhToan";

            dgv.Columns.Add(text0);
            dgv.Columns.Add(text1);
            dgv.Columns.Add(text2);
        }

        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb, string tenbang)
        {
            HoaDonBUS hdBUS = new HoaDonBUS();
            DataTable dt = new DataTable();
            dt = hdBUS.GetByTop(top, where, order, tenbang);
            dgv.DataSource = dt;
            lb.Text = dt.Rows.Count.ToString();
        }

        public static void obj(DataGridView dgv, int r)
        {
            HoaDon obj = new HoaDon();
            MessageBox.Show(dgv.Rows[r].Cells[0].Value.ToString());
            MessageBox.Show(dgv.Rows[r].Cells[1].Value.ToString());
            MessageBox.Show(dgv.Rows[r].Cells[2].Value.ToString());
        }
    }
}