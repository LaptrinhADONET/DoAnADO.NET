using Hotel.Dgv;
using Hotel.Model;
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
        private dgvDatPhong dgv = new dgvDatPhong();

        public frm_DatPhong()
        {
            InitializeComponent();

            dgv.getcmbPhong(cbPhong);
            dgv.getcmbKH(cbKH);
            dgv.getcmbDichVu(cbDichVu);
        }

        private void cbKH_TextChanged(object sender, EventArgs e)
        {
            getdataCB();
        }

        private void getdataCB()
        {
            DataTable dt = new DataTable();
            dt = dgv.getKH(cbKH.SelectedValue.ToString());
            MessageBox.Show(dt.Rows[0][0].ToString());
            MessageBox.Show(dt.Rows[0][1].ToString());
            MessageBox.Show(dt.Rows[0][2].ToString());
            MessageBox.Show(dt.Rows[0][3].ToString());
            MessageBox.Show(dt.Rows[0][4].ToString());
            MessageBox.Show(dt.Rows[0][5].ToString());
            MessageBox.Show(dt.Rows[0][6].ToString());
            MessageBox.Show(dt.Rows[0][7].ToString());
            MessageBox.Show(dt.Rows[0][8].ToString());
        }
    }
}