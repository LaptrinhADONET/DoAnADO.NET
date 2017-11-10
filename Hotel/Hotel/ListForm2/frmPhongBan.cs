using Hotel.BUS;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.ListForm2
{
    public partial class frmphongban : Form
    {
        public frmphongban()
        {
            InitializeComponent();
            PhongBan obj = new PhongBan();
            obj = Properties.Settings.Default.PhongBanObj;
            if (!(Properties.Settings.Default.FlagLoaiPhong == 1))
            {
                txtTenKhuVuc.Text = obj.TenPhongBan;
                if (obj.TrangThai.ToString() == "1")
                    cbTrangThai.Text = "Hoạt động";
                cbTrangThai.Text = "Không hoạt động";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FlagLoaiPhong == 1)
            {
                if (checkNULL() == true)
                {
                    PhongBan obj = new PhongBan();
                    PhongBanBUS pbBUS = new PhongBanBUS();
                    obj.TenPhongBan = txtTenKhuVuc.Text;
                    if (cbTrangThai.Text == "Hoạt động")
                    {
                        obj.TrangThai = "0";
                    }
                    obj.TrangThai = "1";
                    pbBUS.Add(obj);
                    this.Close();
                }
            }
            if (checkNULL() == true)
            {
                PhongBan obj = new PhongBan();
                PhongBanBUS pbBUS = new PhongBanBUS();
                obj.MaPhongBan = Properties.Settings.Default.PhongBanObj.MaPhongBan;
                obj.TenPhongBan = txtTenKhuVuc.Text;
                if (cbTrangThai.Text == "Hoạt động")
                {
                    obj.TrangThai = "0";
                }
                obj.TrangThai = "1";
                pbBUS.Update(obj);
                this.Close();
            }
        }

        private bool checkNULL()
        {
            if (txtTenKhuVuc.Text == "")
            {
                lbTen.Visible = true;
                return false;
            }
            if (cbTrangThai.Text == "")
            {
                lbTrangThai.Visible = true;
                return false;
            }
            return true;
        }

        private void frmphongban_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}