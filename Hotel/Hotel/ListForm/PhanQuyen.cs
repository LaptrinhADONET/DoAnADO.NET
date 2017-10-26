using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hotel.Model;
using Hotel.BUS;

namespace Hotel.ListForm
{
    public partial class frmPhanQuyen : UserControl
    {
        private DBContect db = new DBContect();
        private DataTable dt = new DataTable();
        private PhanQuyenBUS PQ = new PhanQuyenBUS();

        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTK.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtChucVu.Text = "";
            ckTrangChu.Checked = false;
            ckTiepNhanKhach.Checked = false;
            ckDSPhong.Checked = false;
            ckLoaiPhong.Checked = false;
            ckDichVu.Checked = false;
            ckThucDon.Checked = false;
            ckPhongBan.Checked = false;
            ckKhuVuc.Checked = false;
            ckTTKhach.Checked = false;
            ckThongTinNV.Checked = false;
            ckDSHD.Checked = false;
            ckChucVu.Checked = false;
            ckLichDonPhong.Checked = false;
            ckTaiKhoan.Checked = false;
            ckPhanQuyen.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dt = PQ.Insearch_PQ(txtMaTK.Text, Int32.Parse(txtMaNV.Text), CKBox(ckTrangChu), CKBox(ckTiepNhanKhach), CKBox(ckDSPhong), CKBox(ckLoaiPhong), CKBox(ckDichVu), CKBox(ckThucDon), CKBox(ckPhongBan), CKBox(ckKhuVuc), CKBox(ckTTKhach), CKBox(ckThongTinNV), CKBox(ckDSHD), CKBox(ckChucVu),
            CKBox(ckLichDonPhong), CKBox(ckTaiKhoan), CKBox(ckPhanQuyen));
            GetData();
        }

        private void CheckOrUncheck(CheckBox ck, DataGridView dgv, int index, int cell)
        {
            if (dgv.Rows[index].Cells[cell].Value.ToString() == "True")
                ck.Checked = true;
            else ck.Checked = false;
        }

        private int CKBox(CheckBox ck)
        {
            if (ck.Checked) return 1;
            return 0;
        }

        private void ckTiepNhanKhach_Load(object sender, EventArgs e)
        {
            GetData();
            txtMaTK.Enabled = false;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtChucVu.Enabled = false;
        }

        private void dgvPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaTK.Text = dgvPhanQuyen.Rows[r].Cells[0].Value.ToString();
                txtMaNV.Text = dgvPhanQuyen.Rows[r].Cells[2].Value.ToString();
                txtTenNV.Text = dgvPhanQuyen.Rows[r].Cells[1].Value.ToString();
                txtChucVu.Text = dgvPhanQuyen.Rows[r].Cells[3].Value.ToString();
                CheckOrUncheck(ckTrangChu, dgvPhanQuyen, e.RowIndex, 4);
                CheckOrUncheck(ckTiepNhanKhach, dgvPhanQuyen, r, 5);
                CheckOrUncheck(ckDSPhong, dgvPhanQuyen, r, 6);
                CheckOrUncheck(ckLoaiPhong, dgvPhanQuyen, r, 7);
                CheckOrUncheck(ckDichVu, dgvPhanQuyen, r, 8);
                CheckOrUncheck(ckThucDon, dgvPhanQuyen, r, 9);
                CheckOrUncheck(ckPhongBan, dgvPhanQuyen, r, 10);
                CheckOrUncheck(ckKhuVuc, dgvPhanQuyen, r, 11);
                CheckOrUncheck(ckTTKhach, dgvPhanQuyen, r, 12);
                CheckOrUncheck(ckThongTinNV, dgvPhanQuyen, r, 13);
                CheckOrUncheck(ckDSHD, dgvPhanQuyen, r, 14);
                CheckOrUncheck(ckChucVu, dgvPhanQuyen, r, 15);
                CheckOrUncheck(ckLichDonPhong, dgvPhanQuyen, r, 16);
                CheckOrUncheck(ckTaiKhoan, dgvPhanQuyen, r, 17);
                CheckOrUncheck(ckPhanQuyen, dgvPhanQuyen, r, 18);
            }
        }

        private void GetData()
        {
            dt.Clear();
            dt = PQ.Get_By_Top();
            dgvPhanQuyen.DataSource = dt;
            lbSoLuong.Text = dt.Rows.Count.ToString();
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Tìm kiếm...";
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}