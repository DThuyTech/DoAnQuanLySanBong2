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
using DoAnQuanLySanBong2.DAO;
using DoAnQuanLySanBong2.DOT;

namespace DoAnQuanLySanBong2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            Loadinfor();
        }
        SqlConnection ketnoi;
        SqlCommand thuchien;
        int truonghop = 0;

        private void btnSuasan_Click(object sender, EventArgs e)
        {
            btnLuusan.Enabled = true;
            btnHuyluusan.Enabled = true;
            btnThem.Enabled = false;
            btnXoasan.Enabled = false;
            txtLoaisan.ReadOnly = false;
            truonghop = 1;
        }
        private void Loadinfor()
        {
            string query = "select * from San";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSBDataSet1.San' table. You can move, or remove it, as needed.
            Loadinfor();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtMasan.ReadOnly = true;
            txtTensan.ReadOnly = true;
            txtTrangthai.ReadOnly = true;
            txtLoaisan.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtTensan.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtMasan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTrangthai.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtLoaisan.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

            btnSuasan.Enabled = true;

        }

        private void btnHuyluusan_Click(object sender, EventArgs e)
        {
            btnLuusan.Enabled = false;
            btnHuyluusan.Enabled = false;
            btnThem.Enabled = true;
            btnXoasan.Enabled = true;
        }


        
        private void btnLuusan_Click(object sender, EventArgs e)
        {
            if (txtMasan.Text.Length > 0 && txtTensan.Text.Length > 0 && txtLoaisan.Text.Length > 0)
            {
                switch (truonghop)
                {
                    case 1:
                        try
                        {
                            string query = "update San set tensan = '" + txtTensan.Text + "', maloai = '" + txtLoaisan.Text + "' where tensan = '" + txtTensan.Text + "' ";
                            DataProvider provider = new DataProvider();
                            provider.Executenonquery(query);
                            MessageBox.Show("Đã sửa");

                            Loadinfor();



                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hãy nhập loại sân là 1 hoặc 2", "Thông báo");
                        }
                        break;
                    case 2:
                        if (txtLoaisan.Text != null && txtTensan.Text != null)
                        {
                            ThemSan(txtLoaisan.Text, txtTensan.Text);


                        }
                        break;
                        btnLuusan.Enabled = false;
                        btnHuyluusan.Enabled = false;
                        btnThem.Enabled = true;
                        btnXoasan.Enabled = true;


                }
            }
            else
                MessageBox.Show("Thông tin không hợp lệ");
            txtclear();
           
        }

        private void btnXoasan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Thông báo",
               MessageBoxButtons.OKCancel)
               == System.Windows.Forms.DialogResult.OK)
            {
                string query = "delete from San where tensan='" + txtTensan.Text + "' ";
                DataProvider provider = new DataProvider();
                int data = provider.Executenonquery(query);
            }
            Loadinfor();
            {
                
            }
            
        }

        private void txtMasan_TextChanged(object sender, EventArgs e)
        {

        }
        bool checktensan(string tensan)
        {
            string query = "select *from San where tensan = N'" + tensan + "'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;

        }
        bool checknull()
        {
            if (txtLoaisan.Text != null && txtMasan.Text != null && txtTrangthai.Text != null)
                return true;
            return false;
        }
        void txtclear()
        {
            txtTrangthai.Clear();
            txtTensan.Clear();
            txtMasan.Clear();
            txtLoaisan.Clear();
        }
        public void ThemSan(string maloai,string tensan)
        {

            txtTensan.Enabled = true;
            txtLoaisan.Enabled = true;
           
            if (checktensan(txtTensan.Text) == false && checknull() == true)
            {
                string sql = string.Format("Insert Into San Values(N'{0}', 0, {1})", tensan, maloai);
                DataProvider provider = new DataProvider();
                provider.Executenonquery(sql);
                MessageBox.Show("Đã thêm");
                Loadinfor();
            }
            else
                MessageBox.Show("Thông tin điền không hợp lệ");
           
            
        }
        public bool themmoi = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            truonghop = 2;
            themmoi = true;
            setButton(false);
            txtMasan.Focus();
            txtclear();
            Sanbong sb = new Sanbong();
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("select * from San where masan =(select max(masan) from San)");
           
            foreach (DataRow iteam in data.Rows)
            {
                sb = new Sanbong(iteam);

            }
            sb.Masan++;
            txtMasan.Text = sb.Masan.ToString();
            txtMasan.Enabled = false;
            txtTrangthai.Text = "Tốt";
            txtTrangthai.Enabled = false;
            txtTensan.Enabled = true;
            txtLoaisan.Enabled = true;
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoasan.Enabled = val;
            btnSuasan.Enabled = val;
            btnLuusan.Enabled = !val;
            btnHuyluusan.Enabled = !val;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
  
        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rt = MessageBox.Show("Bạn có muốn thoát không", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (rt == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
