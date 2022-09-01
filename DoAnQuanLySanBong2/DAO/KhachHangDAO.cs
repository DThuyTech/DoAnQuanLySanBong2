using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLySanBong2.DOT;
using System.Data;

namespace DoAnQuanLySanBong2.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instances
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }

        private KhachHangDAO() { }

        public Khachhang LoadSanbong(string tenkh)
        {
            Khachhang kh = new Khachhang();
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("select *  from KhachHang where tenkhachhang = N'" + tenkh + "'");
            foreach (DataRow iteam in data.Rows)
            {
                kh = new Khachhang(iteam);

            }
            return kh;

        }
    }
}
