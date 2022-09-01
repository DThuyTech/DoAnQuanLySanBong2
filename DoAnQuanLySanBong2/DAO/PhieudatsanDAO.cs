using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAnQuanLySanBong2.DOT;

namespace DoAnQuanLySanBong2.DAO
{
    internal class PhieudatsanDAO
    {
        private static PhieudatsanDAO instance;
        public static PhieudatsanDAO Instance
        {
            get { if (instance == null) instance = new PhieudatsanDAO(); return PhieudatsanDAO.instance; }
            private set { PhieudatsanDAO.instance = value; }
        }

        public Phieudat Loadlastestpds()
        {   
            Phieudat pd = new Phieudat();
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("select * from Phieudatsan where mapds = (select max(mapds) from Phieudatsan)");
            foreach  (DataRow iteam in  data.Rows)
            {
                pd = new Phieudat(iteam);
            }
            return pd;
        }
    }
}
