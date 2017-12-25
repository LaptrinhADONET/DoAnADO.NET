using Hotel.DATABASE;
using Hotel.Dgv;
using Hotel.Model;
using Hotel.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.ListForm1
{
    public partial class frm_DatPhong : Form
    {
        private static int gia;
        private static NewFolder1.DichVu objDichVu;
        private HotelEntities dbo = new HotelEntities();

        public frm_DatPhong()
        {
            InitializeComponent();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            List<NewFolder1.DichVu> obj = new List<NewFolder1.DichVu>();
            obj = dbo.DichVus.Where(x => x.MaDV.ToString().Contains(cbDichVu.SelectedValue.ToString())).ToList();
            int n = dgvLoadCmbDichVu.Rows.Add();
            foreach (var item in obj)
            {
                dgvLoadCmbDichVu.Rows[n].Cells[0].Value = item.TenDv;
                dgvLoadCmbDichVu.Rows[n].Cells[1].Value = item.Gia;
                dgvLoadCmbDichVu.Rows[n].Cells[2].Value = item.GhiChu;
                dgvLoadCmbDichVu.Rows[n].Cells[3].Value = item.MaDV;
                gia += int.Parse(item.Gia.ToString());
            }
            txtTongTien.Text = gia.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(dgvLoadCmbDichVu.Rows.Value.ToString());
            int tongtien = int.Parse(txtTongTien.Text);
            if (objDichVu.MaDV != 0)
            {
                tongtien -= int.Parse(objDichVu.Gia.ToString());
                dgvLoadCmbDichVu.Rows.RemoveAt(objDichVu.MaDV);
                dgvLoadCmbDichVu.Refresh();
                txtTongTien.Text = tongtien.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewFolder1.BookRoom obj = new NewFolder1.BookRoom();
            obj.MaPhong = int.Parse(cbPhong.SelectedValue.ToString());
            obj.BookRoomStart = DateTime.Parse(dateNgayDen.Value.ToString());
            obj.BookRoomTill = DateTime.Parse(dateNgayDi.Value.ToString());
            obj.TrangThai = 1;
            obj.SoLuongKhach = 0;
            dbo.BookRooms.Add(obj);
            dbo.SaveChanges();
            lbResurt.Text = "Thêm thánh công";
            lbResurt.ForeColor = Color.Red;
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var str = from maloaip in dbo.Phongs where maloaip.MaPhong.ToString().Contains(cbPhong.SelectedValue.ToString()) select maloaip.MaLoaiPhong;
            //foreach (var item in str)
            //{
            //int x = int.Parse(cbPhong.SelectedItem.ToString());
            if (cbDichVu.SelectedIndex != null)
            {
                //var obj = from loaiphong in dbo.Phongs where loaiphong.MaLoaiPhong.ToString().Contains(x) select new { ma = loaiphong.MaLoaiPhong };
                //var k = from gia in dbo.LoaiPhongs where gia.MaLoaiPhong.ToString().Contains(obj.ToString()) select new { giaP = gia.GiaPhong };
                //txtGia.Text = k.ToString();
                var giaphong = from a in dbo.LoaiPhongs join b in dbo.Phongs on a.MaLoaiPhong equals b.MaLoaiPhong where b.MaPhong.ToString().Contains(cbPhong.SelectedValue.ToString()) select new { gia = a.GiaPhong };

                foreach (var item in giaphong)
                {
                    txtGia.Text = item.gia.ToString();
                    //MessageBox.Show(item.gia.ToString());
                }
            }
        }

        private void dgvLoadCmbDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            NewFolder1.DichVu obj = new NewFolder1.DichVu();
            if (n >= 0)
            {
                obj.MaDV = int.Parse(dgvLoadCmbDichVu.Rows[n].Cells["MaDV"].Value.ToString());
                obj.Gia = int.Parse(dgvLoadCmbDichVu.Rows[n].Cells["GiaDV"].Value.ToString());
                objDichVu = obj;
            }
        }

        private void frm_DatPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_LT_NetDataSet.Phong' table. You can move, or remove it, as needed.
            khachHangBindingSource.DataSource = dbo.KhachHangs.ToList();
            phongBindingSource.DataSource = dbo.Phongs.ToList();
            dichVuBindingSource.DataSource = dbo.DichVus.ToList();
            lbResurt.Text = "";
        }
    }
}