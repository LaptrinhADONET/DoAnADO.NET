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
using System.Reflection;
using Hotel.NewFolder1;

namespace Hotel.ListForm
{
    public partial class frmLoaiPhong : UserControl
    {
        private DataTable data = new DataTable();
        private List<LoaiPhong> lp = new List<LoaiPhong>();
        private LoaiPhongBUS lpBUS = new LoaiPhongBUS();

        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        public void AddCheckBoxColumn(DataGridView gridDanhSach, string headerText, string propertyName, int Width, string image)
        {
            var newColumn = new DataGridViewImageColumn();
            // newColumn.DataPropertyName = propertyName;
            newColumn.Name = propertyName;
            newColumn.HeaderText = headerText;
            newColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            newColumn.Resizable = DataGridViewTriState.False;
            newColumn.Width = Width;
            // newColumn.Image = Bitmap.FromFile(image, true);
            gridDanhSach.Columns.AddRange(new DataGridViewColumn[] { newColumn });
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnMenuLoaiPhong.Controls.Clear();
            frmAddLoaiPhong frm = new frmAddLoaiPhong();
            pnMenuLoaiPhong.Controls.Add(frm);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            lp = lpBUS.Get_By_Top("", "", "");
            dgvLoaiPhong.DataSource = lp;
            lbSoLuong.Text = lp.Count.ToString();
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
        }
    }
}