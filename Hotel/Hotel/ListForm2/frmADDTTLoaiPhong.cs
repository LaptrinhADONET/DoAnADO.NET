using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Model;
using Hotel.BUS;

namespace Hotel.ListForm2
{
    public partial class frmADDTTLoaiPhong : UserControl
    {
        private DataTable dt = new DataTable();
        private LoaiPhongBUS lpBUS = new LoaiPhongBUS();
        private List<LoaiPhong> lst = new List<LoaiPhong>();

        public frmADDTTLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLoaiPhong.Text == "")
            {
                lbTen.Visible = true;
                lbTextTen.Visible = true;
                lbTextTen.Text = "Bạn chưa nhập tên";
                lbTextTen.ForeColor = Color.Red;
                lbTen.Image = Properties.Resources.Loi;
            }
            else
            {
                if (cbTrangThai.Text == "")
                {
                    lbTextCB.Visible = true;
                    lbcbTT.Visible = true;
                    lbTextCB.Text = "Bạn chưa chọn trạng thái";
                    lbTextGia.ForeColor = Color.Red;
                    lbcbTT.Image = Properties.Resources.Loi;
                }
                else
                {
                    if (txtDonGia.Text == "")
                    {
                        lbTextGia.Visible = true;
                        lbTextGia.Text = "Bạn chưa nhập giá";
                        lbTextGia.ForeColor = Color.Red;
                        lbGia.Visible = true;
                        lbGia.Image = Properties.Resources.Loi;
                    }
                    else
                    {
                        float num;
                        if (float.TryParse(txtDonGia.Text, out num))
                        {
                            LoaiPhong obj = new LoaiPhong();
                            obj.TenLoaiPhong = txtLoaiPhong.Text;
                            obj.GiaPhong = (txtDonGia.Text);
                            if (cbTrangThai.Text == "Hoạt động")
                            {
                                obj.TrangThai = "1";
                            }
                            else obj.TrangThai = "0";
                            lpBUS.Add(obj);
                            lbCheckAdd.Visible = true;
                            lbIconCheckAdd.Visible = true;
                            lbCheckAdd.ForeColor = Color.Green;
                            lbCheckAdd.Text = "Thêm mới thành công";
                            lbIconCheckAdd.Image = Properties.Resources.Ok_20px;
                            txtLoaiPhong.Text = " Tên Loại Phòng";
                            txtDonGia.Text = " Đơn giá";
                        }
                        else
                        {
                            lbTextGia.Visible = true;
                            lbTextGia.Text = "Bạn nhập sai kiểu";
                            lbTextGia.ForeColor = Color.Red;
                            lbGia.Visible = true;
                            lbGia.Image = Properties.Resources.Loi;
                        }
                    }
                }
            }
        }

        private void checkLoi()
        {
            lbGia.Visible = false;
            lbTen.Visible = false;
            lbTextTen.Visible = false;
            lbTextGia.Visible = false;
            lbIconCheckAdd.Visible = false;
            lbCheckAdd.Visible = false;
            lbTextCB.Visible = false;
            lbcbTT.Visible = false;
        }

        private void frmADDTTLoaiPhong_Load(object sender, EventArgs e)
        {
            checkLoi();
            cbTrangThai.Items.Add("Hoạt động");
            cbTrangThai.Items.Add("Không hoạt động");
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtDonGia.Text = "";
            checkLoi();
        }

        private void txtLoaiPhong_MouseClick(object sender, MouseEventArgs e)
        {
            txtLoaiPhong.Text = "";
            checkLoi();
        }
    }
}