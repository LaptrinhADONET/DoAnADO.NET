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

        private void ckTiepNhanKhach_Load(object sender, EventArgs e)
        {
            GetData();
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