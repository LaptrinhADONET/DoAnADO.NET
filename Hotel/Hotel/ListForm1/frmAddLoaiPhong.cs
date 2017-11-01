using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.ListForm2;
using Hotel.ListForm;
using Hotel.Model;

namespace Hotel.NewFolder1
{
    public partial class frmAddLoaiPhong : UserControl
    {
        public frmAddLoaiPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnContentAddLoaiPhong.Controls.Clear();
            frmADDTTLoaiPhong frmADDTT = new frmADDTTLoaiPhong();
            pnContentAddLoaiPhong.Controls.Add(frmADDTT);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            frmLoaiPhong frm = new frmLoaiPhong();
            pnMenu.Controls.Add(frm);
        }

        private void frmAddLoaiPhong_Load(object sender, EventArgs e)
        {
            pnContentAddLoaiPhong.Controls.Clear();
            frmADDTTLoaiPhong frmADDTT = new frmADDTTLoaiPhong();
            pnContentAddLoaiPhong.Controls.Add(frmADDTT);
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}