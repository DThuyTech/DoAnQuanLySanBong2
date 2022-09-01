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
using DevExpress.XtraBars.Ribbon;
using DoAnQuanLySanBong2.DOT;
using DoAnQuanLySanBong2.DAO;

namespace DoAnQuanLySanBong2
{
    public partial class fDangnhap : DevExpress.XtraEditors.XtraForm
    {
        public fDangnhap()
        {
            InitializeComponent();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo",
               MessageBoxButtons.OKCancel)
               != System.Windows.Forms.DialogResult.OK) ;
            {
                this.Close();
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (Login(username, password) == true && Cateaccount(username)== "True" )
            {
                rfmHethongquanly f = new rfmHethongquanly();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (Login(username, password) == true && Cateaccount(username) == "False")
             {
                fDatnuocvadungcu f = new fDatnuocvadungcu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
        }
        public bool Login (string username, string password)
        {
            return TaiKhoanDAO.Instances.Login(username,password);
        }
        public string Cateaccount(string username)
        {
            return TaiKhoanDAO.Instances.Category(username);
        }

        private void fDangnhap_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
        }
    }
}