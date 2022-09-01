using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DoAnQuanLySanBong2.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instances {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        public bool Login(string userName,string passWord)
        {
            string query = "select * from Account where username	=N'" + userName + "' and pass = N'" + passWord + "'";
            DataProvider provider = new DataProvider();
            DataTable result = provider.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public string Category(string username)
        {
            string query = "exec USP_phanloaitaikhoan " + username + "";
            DataProvider provider = new DataProvider();
            string result = provider.ExecuteoneQuery(query,"loaiaccount");
            
            return result;
        }
    }
}
