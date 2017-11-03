using Hotel.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Dgv
{
    public class DGVKhuVuc
    {
        public static void dgv(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            DataGridViewTextBoxColumn text0 = new DataGridViewTextBoxColumn();
            text0.HeaderText = "Mã khu vực";
            text0.DataPropertyName = "MaKV";
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tên khu vực";
            text1.DataPropertyName = "TenKV";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Mô tả";
            text2.DataPropertyName = "MoTa";
            dgv.Columns.Add(text0);
            dgv.Columns.Add(text1);
            dgv.Columns.Add(text2);
        }

        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb, string tenbang)
        {
            KhuVucBUS obj = new KhuVucBUS();
            dgv.DataSource = obj.Get_By_Top(top, where, order, tenbang);
            lb.Text = obj.Get_By_Top(top, where, order, tenbang).Count.ToString();
        }
    }
}