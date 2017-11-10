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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
            if (!(Properties.Settings.Default.FlagLoaiPhong == 1))
            {
                ChucVu obj = new ChucVu();
                obj = Properties.Settings.Default.ChucVuObj;
                txtTenChucVu.Text = obj.TenCV.ToString();
                txtHSL.Text = obj.HSLuong.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((Properties.Settings.Default.FlagLoaiPhong == 1))
            {
                if (checkNULL() == true)
                {
                    ChucVuBUS cvBUS = new ChucVuBUS();
                    ChucVu obj = new ChucVu();
                    obj.TenCV = txtTenChucVu.Text;
                    obj.HSLuong = txtHSL.Text;
                    cvBUS.Add(obj);
                    this.Close();
                }
            }
            if (checkNULL() == true)
            {
                ChucVuBUS cvBUS = new ChucVuBUS();
                ChucVu obj = new ChucVu();
                obj.TenCV = txtTenChucVu.Text;
                obj.HSLuong = txtHSL.Text;
                cvBUS.Update(obj);
                this.Close();
            }
        }

        private bool checkNULL()
        {
            float a;
            if (txtTenChucVu.Text == "")
            {
                lbTen.Visible = true;
                return false;
            }
            if (txtHSL.Text == "")
            {
                lbGHSL.Visible = true;
                return false;
            }
            //if (float.TryParse(txtHSL.Text, out a))
            //{
            //    lbGHSL.Visible = true;
            //    return false;
            //}
            return true;
        }

        private void clickNULL()
        {
            lbTen.Visible = false;
            lbGHSL.Visible = false;
        }

        private void frmChucVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtHSL_Click(object sender, EventArgs e)
        {
            clickNULL();
        }

        private void txtTenChucVu_Click(object sender, EventArgs e)
        {
            clickNULL();
        }
    }
}