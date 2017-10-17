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
    public partial class MenuHotel : Form
    {
        public MenuHotel()
        {
            InitializeComponent();
        }

        public void labmenu(Button btn)
        {
            lbNutchay.Height = btn.Height;
            lbNutchay.Top = btn.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            labmenu(btnHome);
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            labmenu(btnHome1);
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            labmenu(btnHome2);
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            labmenu(btnHome3);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}