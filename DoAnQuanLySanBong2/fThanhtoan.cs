using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLySanBong2.DOT;
using DoAnQuanLySanBong2.DAO;

namespace DoAnQuanLySanBong2
{
    public partial class fThanhtoan : DevExpress.XtraEditors.XtraForm
    {
        public fThanhtoan()
        {
            InitializeComponent();
            loadHoadon();
        }

        void loadHoadon()
        {
            string query = "exec USP_getHOADON";
            DataProvider provider = new DataProvider();
            dtgHoadon.DataSource = provider.ExecuteQuery(query);

        }

        private void dtgHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgHoadon.CurrentCell.RowIndex;
            txtbTenKH.Text = dtgHoadon.Rows[i].Cells[0].Value.ToString();
            txtTensan.Text = dtgHoadon.Rows[i].Cells[1].Value.ToString();
            txtbGiobatdau.Text = dtgHoadon.Rows[i].Cells[3].Value.ToString();
            txtbGioketthuc.Text = dtgHoadon.Rows[i].Cells[4].Value.ToString();
            txtbTongtien.Text = dtgHoadon.Rows[i].Cells[7].Value.ToString();
            txtbNgaydatsan.Text = dtgHoadon.Rows[i].Cells[2].Value.ToString();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string queryUdhd = "exec USP_thanhtoan N'" + txtTensan.Text + "' , '" + txtbNgaydatsan.Text + "'," + txtbGiobatdau.Text + "," + txtbGioketthuc.Text + "";


            DataProvider provider = new DataProvider();
            int data = provider.Executenonquery(queryUdhd);

            txtbTenKH.Clear();
            txtTensan.Clear();
            txtbGiobatdau.Clear();
            txtbGioketthuc.Clear();
            txtbTongtien.Clear();
            MessageBox.Show("thanh toan thanh cong");
            loadHoadon();
        }
    }
}