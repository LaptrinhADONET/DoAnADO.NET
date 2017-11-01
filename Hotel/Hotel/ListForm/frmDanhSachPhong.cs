using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Model;
using Hotel.BUS;

namespace Hotel.ListForm1
{
    public partial class frmDanhSachPhong : UserControl
    {
        public frmDanhSachPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DanhSachPhong frm = new DanhSachPhong();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                getdata("", "", "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            getdata("", "", "");
        }

        private void frmDanhSachPhong_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void getdata(string top, string where, string order)
        {
            PhongBUS pBUS = new PhongBUS();
            dgvPhong.DataSource = pBUS.Get_By_Top1(top, where, order);
            lbSoLuong.Text = pBUS.Get_By_Top1(top, where, order).Rows.Count.ToString();
        }
    }
}