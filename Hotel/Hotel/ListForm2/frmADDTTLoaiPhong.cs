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
                lbTextTen.Text = "Bạn chưa nhập giá";
                lbTextTen.ForeColor = Color.Red;
                lbTen.Image = Properties.Resources.Loi;
            }
            else
            {
                if (txtMaLoaiPhong.Text == "")
                {
                    lbMa.Visible = true;
                    lbTextMa.Visible = true;
                    lbTextMa.Text = "Bạn chưa nhập giá";
                    lbTextMa.ForeColor = Color.Red;
                    lbMa.Image = Properties.Resources.Loi;
                }
                else
                {
                    if (txtDonGia.Text == "")
                    {
                        lbGia.Visible = true;
                        lbTextGia.Visible = true;
                        lbTextGia.Text = "Bạn chưa nhập giá";
                        lbTextGia.ForeColor = Color.Red;
                        lbGia.Image = Properties.Resources.Loi;
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
                            if (CheckKhoa())
                            {
                                lbCheckAdd.ForeColor = Color.Red;
                                lbCheckAdd.Text = "Mã loại phòng đã bị trùng";
                                lbCheckAdd.Visible = true;
                                lbIconCheckAdd.Image = Properties.Resources.Loi;
                                lbIconCheckAdd.Visible = true;
                                txtMaLoaiPhong.Text = "";
                            }
                            else
                            {
                                LoaiPhong obj = new LoaiPhong();
                                obj.MaLoaiPhong = txtMaLoaiPhong.Text;
                                obj.TenLoaiPhong = txtLoaiPhong.Text;
                                obj.GiaPhong = (txtDonGia.Text);
                                if (cbTrangThai.SelectedValue == "Hoạt động")
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
                                txtMaLoaiPhong.Text = " Mã Loại Phòng";
                                txtLoaiPhong.Text = " Tên Loại Phòng";
                            }
                        }
                    }
                }
            }
        }

        private bool CheckKhoa()
        {
            DataTable dt = new DataTable();
            dt = lpBUS.checkma(int.Parse(txtMaLoaiPhong.Text));
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private void checkLoi()
        {
            lbGia.Visible = false;
            lbMa.Visible = false;
            lbTen.Visible = false;
            lbTextMa.Visible = false;
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

        private void txtMaLoaiPhong_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaLoaiPhong.Text = "";
            checkLoi();
        }
    }
}