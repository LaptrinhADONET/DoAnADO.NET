using Hotel.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Dgv
{
    public class DGVChucVu
    {
        public static void dgv(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            DataGridViewTextBoxColumn text0 = new DataGridViewTextBoxColumn();
            text0.HeaderText = "Mã chức vụ";
            text0.DataPropertyName = "MaCV";
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tên chức vụ";
            text1.DataPropertyName = "TenCV";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Hệ số lương";
            text2.DataPropertyName = "HSLuong";
            dgv.Columns.Add(text0);
            dgv.Columns.Add(text1);
            dgv.Columns.Add(text2);
        }

        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb, string tenbang)
        {
            ChucVuBUS cvBUS = new ChucVuBUS();
            dgv.DataSource = cvBUS.Get_By_Top(top, where, order, tenbang);
            lb.Text = cvBUS.Get_By_Top(top, where, order, tenbang).Count.ToString();
        }
    }
}