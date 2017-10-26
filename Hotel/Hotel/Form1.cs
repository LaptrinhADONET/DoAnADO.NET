using Hotel.BUS;
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

        public void CreateListMenu(int n)
        {
            btnTest = new Button[n, n];
            pnThanh = new Panel[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    btnTest[i, j] = new Button();
                    btnTest[i, j].Location = new System.Drawing.Point(10, 10 + 42 * i);
                    btnTest[i, j].Name = "btnTest" + i + "." + j;
                    btnTest[i, j].Size = new System.Drawing.Size(200, 40);
                    btnTest[i, j].Text = "(" + i + ", " + j + ")";
                    btnTest[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
                    btnTest[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    btnTest[i, j].FlatStyle = FlatStyle.Flat;
                    btnTest[i, j].FlatAppearance.BorderSize = 0;
                    btnTest[i, j].UseVisualStyleBackColor = false;
                    btnTest[i, j].Tag = "" + i + "," + j + "";
                    btnTest[i, j].MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTest_MouseMove);
                    btnTest[i, j].MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
                    // btnTest[i, j].Click += new System.EventHandler(this.btnTest_Click);

                    pnThanh[i, j] = new Panel();
                    pnThanh[i, j].Location = new System.Drawing.Point(10, 10 + 42 * i);
                    pnThanh[i, j].Name = "pbThanh" + i + "." + j;
                    pnThanh[i, j].Size = new System.Drawing.Size(10, 40);
                    pnThanh[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
                    pnThanh[i, j].Visible = false;

                    pnMenu.Controls.Add(pnThanh[i, j]);
                    pnMenu.Controls.Add(btnTest[i, j]);
                }
            }
        }

        public void data()
        {
            PhanQuyenBUS pq = new PhanQuyenBUS();

            dataGridView1.DataSource = pq.Get_By_Top1("admin", "1234");
        }

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            Button test = (Button)sender;
            string[] vt = test.Tag.ToString().Split(',');
            int i = int.Parse(vt[0]);
            int j = int.Parse(vt[1]);
            pnThanh[i, j].Visible = false;
        }

        private void btnTest_MouseMove(object sender, MouseEventArgs e)
        {
            Button test = (Button)sender;
            string[] vt = test.Tag.ToString().Split(',');
            int i = int.Parse(vt[0]);
            int j = int.Parse(vt[1]);
            pnThanh[i, j].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data();
            //CreateListMenu(8);
            /////Button test = (Button)sender;
            ////string[] vt = test.Tag.ToString().Split(',');
            ////int i = int.Parse(vt[0]);
            ////int j = int.Parse(vt[1]);
            //btnTest[1, 0].Text = "Trang chủ";
            button2.Enabled = false;
            //button2.Visible = false;
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}