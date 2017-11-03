using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Dgv
{
    public class DGV
    {
        public static void BaseDGV(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowTemplate.Height = 30;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
        }
    }
}