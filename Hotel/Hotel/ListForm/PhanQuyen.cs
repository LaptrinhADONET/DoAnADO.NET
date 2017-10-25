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

        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void CheckOrUncheck(CheckBox ck, DataGridView dgv, int index, int cell)
        {
            if (dgv.Rows[index].Cells[cell].Value.ToString() == "True")
                ck.Checked = true;
            else ck.Checked = false;
        }

        private void ckTiepNhanKhach_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dgvPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaTK.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaNV.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenNV.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                CheckOrUncheck(ckTrangChu, dgvPhanQuyen, e.RowIndex, 3);
                CheckOrUncheck(ckTiepNhanKhach, dgvPhanQuyen, e.RowIndex, 4);
                CheckOrUncheck(ckDSPhong, dgvPhanQuyen, e.RowIndex, 5);
                CheckOrUncheck(ckLoaiPhong, dgvPhanQuyen, e.RowIndex, 6);
                CheckOrUncheck(ckDichVu, dgvPhanQuyen, e.RowIndex, 7);
                CheckOrUncheck(ckThucDon, dgvPhanQuyen, e.RowIndex, 8);
                CheckOrUncheck(ckPhongBan, dgvPhanQuyen, e.RowIndex, 9);
                CheckOrUncheck(ckKhuVuc, dgvPhanQuyen, e.RowIndex, 10);
                CheckOrUncheck(ckTTKhach, dgvPhanQuyen, e.RowIndex, 11);
                CheckOrUncheck(ckThongTinNV, dgvPhanQuyen, e.RowIndex, 12);
                CheckOrUncheck(ckDSHD, dgvPhanQuyen, e.RowIndex, 13);
                CheckOrUncheck(ckChucVu, dgvPhanQuyen, e.RowIndex, 14);
                CheckOrUncheck(ckLichDonPhong, dgvPhanQuyen, e.RowIndex, 15);
                CheckOrUncheck(ckTaiKhoan, dgvPhanQuyen, e.RowIndex, 16);
                CheckOrUncheck(ckPhanQuyen, dgvPhanQuyen, e.RowIndex, 17);
            }
        }

        private void GetData()
        {
            DataTable dt = new DataTable();
            PhanQuyenBUS PQ = new PhanQuyenBUS();
            dt = PQ.Get_By_Top();
            dgvPhanQuyen.DataSource = dt;
        }
    }
}