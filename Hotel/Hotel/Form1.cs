using Hotel.BUS;
using Hotel.ListForm;
using Hotel.ListForm1;
using Hotel.Repost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        private Button[,] btnTest;
        private Panel[,] pnThanh;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmNhanKhach frm = new frmNhanKhach();
            pnMenu.Controls.Add(frm);
        }
    }
}