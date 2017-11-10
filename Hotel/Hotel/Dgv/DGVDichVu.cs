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
    public class DGVDichVu
    {
        public static void dgv(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            DataGridViewTextBoxColumn text0 = new DataGridViewTextBoxColumn();
            text0.HeaderText = "Mã dịch vụ";
            text0.DataPropertyName = "MaDV";
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tên dịch vụ";
            text1.DataPropertyName = "TenDv";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Giá";
            text2.DataPropertyName = "Gia";
            DataGridViewTextBoxColumn text3 = new DataGridViewTextBoxColumn();
            text3.HeaderText = "Trạng thái";
            text3.DataPropertyName = "TrangThai";
            DataGridViewTextBoxColumn text4 = new DataGridViewTextBoxColumn();
            text4.HeaderText = "Ghi chú";
            text4.DataPropertyName = "GhiChu";
            dgv.Columns.Add(text0);
            dgv.Columns.Add(text1);
            dgv.Columns.Add(text2);
            dgv.Columns.Add(text3);
            dgv.Columns.Add(text4);
        }

        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb, string tenbang)
        {
            DichVuBUS obj = new DichVuBUS();
            dgv.DataSource = obj.GetByTop(top, where, order, tenbang);
            lb.Text = obj.GetByTop(top, where, order, tenbang).Count.ToString();
        }

        public static void obj(DataGridView dgv, int r)
        {
            DichVu obj = new DichVu();
            obj.MaDV = dgv.Rows[r].Cells[2].Value.ToString();
            obj.TenDV = dgv.Rows[r].Cells[3].Value.ToString();
            if (dgv.Rows[r].Cells[4].Value.ToString() == "True")
                obj.TrangThai = "1";
            obj.TrangThai = "0";
            obj.Gia = dgv.Rows[r].Cells[1].Value.ToString();
            obj.GhiChu = dgv.Rows[r].Cells[0].Value.ToString();
            Properties.Settings.Default.DichVuObj = obj;
        }
    }
}