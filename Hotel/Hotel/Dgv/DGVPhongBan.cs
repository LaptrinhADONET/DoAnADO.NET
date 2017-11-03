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
    public class DGVPhongBan
    {
        public static void dgv(DataGridView dgv)
        {
            DGV.BaseDGV(dgv);
            DataGridViewTextBoxColumn text0 = new DataGridViewTextBoxColumn();
            text0.HeaderText = "Mã phòng ban";
            text0.DataPropertyName = "MaPhongBan";
            DataGridViewTextBoxColumn text1 = new DataGridViewTextBoxColumn();
            text1.HeaderText = "Tên phòng ban";
            text1.DataPropertyName = "TenPhongBan";
            DataGridViewTextBoxColumn text2 = new DataGridViewTextBoxColumn();
            text2.HeaderText = "Trạng thái";
            text2.DataPropertyName = "TrangThai";
            dgv.Columns.Add(text0);
            dgv.Columns.Add(text1);
            dgv.Columns.Add(text2);
        }

        public static void GetData(DataGridView dgv, string top, string where, string order, Label lb, string tenbang)
        {
            List<PhongBan> lst = new List<PhongBan>();
            PhongBanBUS pbBUS = new PhongBanBUS();
            dgv.DataSource = pbBUS.Get_By_Top(top, where, order, tenbang);
            lb.Text = pbBUS.Get_By_Top(top, where, order, tenbang).Count.ToString();
        }
    }
}