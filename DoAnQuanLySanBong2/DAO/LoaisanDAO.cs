using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLySanBong2.DOT;
using System.Data;

namespace DoAnQuanLySanBong2.DAO
{
    class LoaisanDAO
    {
        private static LoaisanDAO instance;
        internal static LoaisanDAO Instance { 
            get { if (instance == null) instance = new LoaisanDAO(); return LoaisanDAO.instance; }
            private set { LoaisanDAO.instance = value; }
        }

        public Loaisan Loadloaisan(string tenloai)
        {
            Loaisan ls = new Loaisan();
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("select * from Loaisan where tenloai = N'" + tenloai + "'");
            foreach (DataRow iteam in data.Rows)
            {
                ls = new Loaisan(iteam);

            }
            return ls;

        }
    }
}
