using Hotel.BUS;
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
            Phong obj = new Phong();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FlagLoaiPhong == 1)
            {
                if (checkNull() == true)
                {
                    AddData();
                    this.Close();
                }
            }
            if (Properties.Settings.Default.FlagLoaiPhong == 2)
            {
                if (checkNull() == true)
                {
                    update();
                    this.Close();
                }
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
        }

        private void cbMaLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbTenKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbTT_Click(object sender, EventArgs e)
        {
            hidelb();
        }

        private void cbTT_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private bool checkNull()
        {
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
            //if (float.TryParse(txtGia.Text, out n))
            //{
            //    lbGiaPhong.Visible = true;
            //    return false;
            //}
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
            if (Properties.Settings.Default.FlagLoaiPhong == 2)
            {
                Phong obj = new Phong();
                obj = Properties.Settings.Default.Phong;
                txtTen.Text = obj.TenPhong;
                txtViTri.Text = obj.ViTri;
                if (obj.TrangThai == "1")
                {
                    cbTT.Text = "Hoạt động";
                }
                cbTT.Text = "Không hoạt động";
                numNguoiLon.Value = int.Parse(obj.NguoiLon);
                numTreEm.Value = int.Parse(obj.TreEm);
                txtGia.Text = obj.Gia;
                cbTenKhuVuc.DisplayMember = obj.TenKhuVuc;
                cbMaLoaiPhong.DisplayMember = obj.MaLoaiPhong;
                byte[] imgData = obj.AnhPhong;
                MemoryStream stream = new MemoryStream(imgData);
                picPhong.Image = Image.FromStream(stream);
                txtMoTa.Text = obj.MoTa;
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void lbGiaPhong_Click(object sender, EventArgs e)
        {
        }

        private void lbImage_Click(object sender, EventArgs e)
        {
        }

        private void lbTen_Click(object sender, EventArgs e)
        {
        }

        private void lbTT_Click(object sender, EventArgs e)
        {
        }

        private void lbViTri_Click(object sender, EventArgs e)
        {
        }

        private void numNguoiLon_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numTreEm_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void picPhong_Click(object sender, EventArgs e)
        {
        }

        private void pnContentAddLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtGia_Click(object sender, EventArgs e)
        {
            hidelb();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTen_MouseClick(object sender, MouseEventArgs e)
        {
            hidelb();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtViTri_Click(object sender, EventArgs e)
        {
            hidelb();
        }

        private void txtViTri_TextChanged(object sender, EventArgs e)
        {
        }

        private void update()
        {
            Phong obj = new Phong();
            obj.MaPhong = Properties.Settings.Default.Phong.MaPhong;
            obj.TenPhong = txtTen.Text;
            if (txtMoTa.Text == "")
            {
                obj.MoTa = "";
            }
            obj.MoTa = txtMoTa.Text;
            obj.ViTri = txtViTri.Text;
            obj.AnhPhong = Properties.Settings.Default.Phong.AnhPhong;
            if (cbTT.Text == "Hoạt động")
            {
                obj.TrangThai = "1";
            }
            else obj.TrangThai = "0";
            obj.NguoiLon = numNguoiLon.Value.ToString();
            obj.TreEm = numTreEm.Value.ToString();
            obj.MaKV = cbTenKhuVuc.SelectedValue.ToString();
            obj.MaLoaiPhong = cbMaLoaiPhong.SelectedValue.ToString();
            pBUS.Update(obj);
        }
    }
}