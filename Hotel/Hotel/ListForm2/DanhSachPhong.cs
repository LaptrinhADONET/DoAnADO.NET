﻿using Hotel.BUS;
using Hotel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.ListForm1
{
    public partial class DanhSachPhong : Form
    {
        private Image file;
        private string Imglocation = "";
        private Phong obj = new Phong();
        private PhongBUS pBUS = new PhongBUS();

        public DanhSachPhong()
        {
            InitializeComponent();
        }

        public bool checkpicnull(PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }

        private void AddData()
        {
            byte[] image = null;

            FileStream Stream = new FileStream(picPhong.ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            image = brs.ReadBytes((int)Stream.Length);
            obj.TenPhong = txtTen.Text;
            if (txtMoTa.Text == "")
            {
                obj.MoTa = "";
            }
            obj.MoTa = txtMoTa.Text;
            obj.ViTri = txtViTri.Text;
            obj.AnhPhong = image;
            if (cbTT.Text == "Hoạt động")
            {
                obj.TrangThai = "1";
            }
            else obj.TrangThai = "0";
            obj.NguoiLon = numNguoiLon.Value.ToString();
            obj.TreEm = numTreEm.Value.ToString();
            obj.MaKV = cbTenKhuVuc.SelectedValue.ToString();
            obj.MaLoaiPhong = cbMaLoaiPhong.SelectedValue.ToString();
            pBUS.Add(obj);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            hidelb();
            string Imglocation = "";
            OpenFileDialog opimage = new OpenFileDialog();
            opimage.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (opimage.ShowDialog() == DialogResult.OK)
            {
                Imglocation = opimage.FileName.ToString();
                picPhong.ImageLocation = Imglocation;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNull() == true)
            {
                AddData();
                this.Close();
            }
        }

        private void cbTT_Click(object sender, EventArgs e)
        {
            hidelb();
        }

        private bool checkNull()
        {
            float n;
            if (txtTen.Text == "")
            {
                lbTen.Visible = true;
                return false;
            }
            if (txtViTri.Text == "")
            {
                lbViTri.Visible = true;
                return false;
            }

            if (cbTT.Text == "")
            {
                lbTT.Visible = true;
                return false;
            }
            if (txtGia.Text == "")
            {
                lbGiaPhong.Visible = true;
                return false;
            }
            if (checkpicnull(picPhong) == true)
            {
                lbImage.Visible = true;
                return false;
            }
            if (float.TryParse(txtGia.Text, out n))
            {
                lbGiaPhong.Visible = true;
                return false;
            }
            return true;
        }

        private void DanhSachPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DanhSachPhong_Load(object sender, EventArgs e)
        {
            GetCMB(cbTenKhuVuc, "MaKV", "TenKV", "KhuVuc");
            GetCMB(cbMaLoaiPhong, "MaLoaiPhong", "TenLoaiPhong", "LoaiPhong");
        }

        private void GetCMB(ComboBox cb, string ma, string ten, string tenbang)
        {
            cb.DataSource = pBUS.loadcb(ma, ten, tenbang);
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
        }

        private void hidelb()
        {
            lbTen.Visible = false;
            lbGiaPhong.Visible = false;
            lbImage.Visible = false;
            lbTT.Visible = false;
            lbViTri.Visible = false;
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtGia_Click(object sender, EventArgs e)
        {
            hidelb();
        }

        private void txtTen_MouseClick(object sender, MouseEventArgs e)
        {
            hidelb();
        }

        private void txtViTri_Click(object sender, EventArgs e)
        {
            hidelb();
        }
    }
}