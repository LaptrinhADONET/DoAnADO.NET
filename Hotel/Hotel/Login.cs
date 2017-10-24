using Hotel.BUS;
using Hotel.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public List<NhanVien> login()
        {
            NhanVienBUS nv = new NhanVienBUS();
            List<NhanVien> lst = new List<NhanVien>();
            lst = nv.Login(txtUser.Text, txtPass.Text);
            return lst;
        }

        public void PQNguoiDUng()
        {
            ChucVuBUS cv = new ChucVuBUS();
            List<ChucVu> lst = new List<ChucVu>();
            Hashtable hst = new Hashtable();
            lst = cv.Get_By_Top("", "", "");
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            List<NhanVien> list = login();
            NhanVien nv = new NhanVien();
            if (list.Count() == 1)
            {
                Properties.Settings.Default.Email = txtUser.Text;
                Properties.Settings.Default.Pass = txtPass.Text;
                foreach (var i in list)
                {
                    Properties.Settings.Default.Name = i.TenNV.ToString();
                }
                Menu mn = new Hotel.Menu();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không đúng");
            }
        }

        private void lcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}