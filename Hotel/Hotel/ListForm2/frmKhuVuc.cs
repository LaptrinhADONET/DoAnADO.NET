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
    public partial class frmKhuVuc : Form
    {
        public frmKhuVuc()
        {
            InitializeComponent();
            if (!(Properties.Settings.Default.FlagLoaiPhong == 1))
            {
                KhuVuc obj = new KhuVuc();
                obj = Properties.Settings.Default.KhuVucObj;
                txtTenKhuVuc.Text = obj.TenKV;
                if (obj.MoTa.ToString() == "")
                    txtMoTa.Text = "";
                txtMoTa.Text = obj.MoTa;
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
                    KhuVuc obj = new KhuVuc();
                    KhuVucBUS kvBUS = new KhuVucBUS();
                    obj.TenKV = txtTenKhuVuc.Text;
                    if (txtMoTa.Text == "")
                    {
                        obj.MoTa = "";
                    }
                    obj.MoTa = txtMoTa.Text;
                    kvBUS.Add(obj);
                    this.Close();
                }
            }
            if (checkNULL() == true)
            {
                KhuVuc obj = new KhuVuc();
                KhuVucBUS kvBUS = new KhuVucBUS();
                obj.MaKV = Properties.Settings.Default.ChucVuObj.MaCV;
                obj.TenKV = txtTenKhuVuc.Text;
                if (txtMoTa.Text == "")
                {
                    obj.MoTa = "";
                }
                obj.MoTa = txtMoTa.Text;
                kvBUS.Update(obj);
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
            return true;
        }

        private void frmKhuVuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}