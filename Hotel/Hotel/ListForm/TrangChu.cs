using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Hotel.ListForm
{
    public partial class TrangChu : UserControl
    {
        private int fCount = Directory.GetFiles(@"..\..\Images\abc", "*", SearchOption.AllDirectories).Length;
        private int i = 0;
        private Label[,] lb;

        public TrangChu()
        {
            InitializeComponent();
            lbel(5);
            check();
            LstTinTuc frm = new LstTinTuc();
            pnLST.Controls.Add(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void check()
        {
            i++;
            if (i > fCount)
                i = 1;
            pixb.ImageLocation = @"..\..\Images\abc\Product" + i + ".jpg";
            lb[i - 1, 0].BackColor = System.Drawing.Color.Blue;
            if ((i - 2) == -1)
            {
                lb[fCount - 1, 0].BackColor = System.Drawing.Color.Gray;
            }
            else lb[i - 2, 0].BackColor = System.Drawing.Color.Gray;
        }

        private void lbel(int n)
        {
            lb = new Label[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    lb[i, j] = new Label();
                    lb[i, j].Location = new System.Drawing.Point(471 + 15 * i, 265);
                    lb[i, j].BackColor = System.Drawing.Color.Gray;
                    lb[i, j].Size = new System.Drawing.Size(10, 10);
                    lb[i, j].Name = "lb" + i + "." + j;
                    lb[i, j].Visible = true;
                    lb[i, j].FlatStyle = FlatStyle.Flat;
                    //MessageBox.Show("i=" + i.ToString() + ",j = " + j.ToString());
                    pixb.Controls.Add(lb[i, j]);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            check();
            timer1.Start();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
        }
    }
}