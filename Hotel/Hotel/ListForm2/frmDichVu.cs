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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();

            if (!(Properties.Settings.Default.FlagLoaiPhong == 1))
            {
                DichVu obj = new DichVu();
                obj = Properties.Settings.Default.DichVuObj;
                txtTen.Text = obj.TenDV.ToString();
                txtGia.Text = obj.Gia.ToString();
                if (obj.TrangThai.ToString() == "1")
                {
                    cbTrangThai.Text = "Hoạt động";
                }
                cbTrangThai.Text = "Không hoạt động";
                if (obj.GhiChu.ToString() == "")
                {
                    txtGhiChu.Text = "";
                }
                txtGhiChu.Text = obj.GhiChu;
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
                if (CheckNULL() == true)
                {
                    DichVu obj = new DichVu();
                    DichVuBUS dvBUS = new DichVuBUS();
                    obj.TenDV = txtTen.Text;
                    obj.Gia = txtGia.Text;
                    if (cbTrangThai.Text == "Hoạt động")
                        obj.TrangThai = "1";
                    obj.TrangThai = "0";
                    if (txtGhiChu.Text == "")
                    {
                        obj.GhiChu = "";
                    }
                    obj.GhiChu = txtGhiChu.Text;
                    dvBUS.Add(obj);
                    this.Close();
                }
            }
            if (CheckNULL() == true)
            {
                DichVu obj = new DichVu();
                DichVuBUS dvBUS = new DichVuBUS();
                obj.MaDV = Properties.Settings.Default.DichVuObj.MaDV;
                obj.TenDV = txtTen.Text;
                obj.Gia = txtGia.Text;
                if (cbTrangThai.Text == "Hoạt động")
                    obj.TrangThai = "1";
                obj.TrangThai = "0";
                if (txtGhiChu.Text == "")
                {
                    obj.GhiChu = "";
                }
                obj.GhiChu = txtGhiChu.Text;
                dvBUS.Update(obj);
                this.Close();
            }
        }

        private bool CheckNULL()
        {
            if (txtTen.Text == "")
            {
                lbTen.Visible = true;
                return false;
            }
            if (txtGia.Text == "")
            {
                lbGHSL.Visible = true;
                return false;
            }
            if (cbTrangThai.Text == "")
            {
                lbTT.Visible = true;
                return false;
            }
            return true;
        }

        private void frmDichVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}