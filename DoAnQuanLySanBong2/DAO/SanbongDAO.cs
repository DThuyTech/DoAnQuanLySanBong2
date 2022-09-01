using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLySanBong2.DOT;
using System.Data;

namespace DoAnQuanLySanBong2.DAO
{
    class SanbongDAO
    {
        private static SanbongDAO instance;
        internal static SanbongDAO Instance {
            get { if (instance == null) instance = new SanbongDAO(); return SanbongDAO.instance; }
            private set { SanbongDAO.instance = value; }
        }
        public int Weigh = 80;
        public int Heigh = 80;

        public List<Sanbong> LoadDSSan()
        {
            List<Sanbong> sbList = new List<Sanbong>();
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("select * from San");
            foreach(DataRow iteam in data.Rows)
            {
                Sanbong sb = new Sanbong(iteam);
              
                sbList.Add(sb);
            }
            return sbList;
                
        }
        public Sanbong LoadSanbong(string tensan)
        {
            Sanbong sb = new Sanbong();
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("select * from San where tensan = N'"+tensan+"'");
            foreach (DataRow iteam in data.Rows)
            {
                sb = new Sanbong(iteam);
               
            }
            return sb;
            
        }
    }
}
