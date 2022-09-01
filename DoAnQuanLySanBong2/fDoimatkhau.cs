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
using DoAnQuanLySanBong2.DAO;
namespace DoAnQuanLySanBong2
{
    public partial class fDoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        public fDoimatkhau()
        {
            InitializeComponent();
        }
        /*private int KiemTraTK()
        {
            string query = "exec proc_kiemTraTK'" + txtUsername.Text + "', '" + txtMatkhaucu.Text + "'";
            DataProvider provid = new DataProvider();
            int data = provid.Executenoquery(query);
            if (data == 1)
                return 1;
            return 0;
        }*/
        public bool Login(string username, string password)
        {
            return TaiKhoanDAO.Instances.Login(username, password);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtMatkhaucu.Text;
            if (txtUsername.Text == "") MessageBox.Show("Chưa nhập tên đăng nhập", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMatkhaucu.Text == "") MessageBox.Show("Chưa nhập mật khẩu cũ", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMatkhaumoi.Text == "") MessageBox.Show("Chưa nhập mật khẩu mới", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtNhaplaimatkhau.Text == "") MessageBox.Show("Chưa xác nhận mật khẩu", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMatkhaumoi.Text != txtNhaplaimatkhau.Text) MessageBox.Show("Mật khẩu mới chưa trùng khớp", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Login(username, password) == true)
                {
                    if (txtMatkhaumoi.Text == txtMatkhaucu.Text)
                    {
                        MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ. Hãy chọn mật khẩu khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (txtMatkhaumoi.Text.Length > 5 && txtMatkhaumoi.Text.Length < 19)
                        {
                            string query = "exec proc_doiMatKhau'" + txtUsername.Text + "', '" + txtMatkhaucu.Text + "','" + txtMatkhaumoi.Text + "'";
                            DataProvider provid = new DataProvider();
                            provid.Executenoquery(query);
                            MessageBox.Show("Đã đổi mật khẩu", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập mật khẩu có độ dài từ 6 đến 18 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fDoimatkhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo)
               == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtMatkhaucu.Text = "";
            txtMatkhaumoi.Text = "";
            txtNhaplaimatkhau.Text = "";
            txtMatkhaumoi.Text = "";
        }
    }

}