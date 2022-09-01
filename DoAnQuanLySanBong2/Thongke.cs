using DoAnQuanLySanBong2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLySanBong2
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void cbbThucthe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            DataProvider provide = new DataProvider(); 
            switch (cbbThucthe.SelectedIndex.ToString())
            {
                case "2":
                     query = "exec USP_Thongkesan";
                    
                    dtgthongke.DataSource = provide.ExecuteQuery(query);
                    txtdoanhthu.Clear();
                    loadTongdong();
                    
                    txttangtruong.Clear();
                    break;
                case "1":
                     query = "exec USP_getdsCTHD";
                    
                    dtgthongke.DataSource = provide.ExecuteQuery(query);
                    ccbthangdoahthu.Enabled= true;
                    txtdoanhthu.Text = loadtongtien().ToString();
                    ccbthangdoahthu.Enabled = false;
                    txthds.Enabled = false;
                    txttangtruong.Clear();
                    loadTongdong();
                    break;
                case "0":
                     query = "exec USP_getdsHOADON";
                    
                    dtgthongke.DataSource = provide.ExecuteQuery(query);
                    ccbthangdoahthu.Enabled = true;
                    txthds.Enabled = true;
                    txtdoanhthu.Text = loadtongtien().ToString();
                    loadTongdong();
                   
                    txttangtruong.Clear();


                    break;


            }
            
            

        }

        void loadtangtruong( int thang)
        {
            long tongtien = 0;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("exec USP_tinhtangtruong "+thang+"");
            foreach (DataRow iteam in data.Rows)
            {

                txttangtruong.Text  =iteam["tangtruong"].ToString();

            }
           
            
        }
        

        private void ccbthangdoahthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadhoadontheothang(ccbthangdoahthu.SelectedIndex+1);
            loadtangtruong(ccbthangdoahthu.SelectedIndex + 1);
            loadTongdong();
            
            
        }
        void loadTongdong()
        {
            txttongdong.Text=  (Int32.Parse(dtgthongke.RowCount.ToString())-1).ToString();
        }
        long loadtongtien()
        {
            long tongtien=0;
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery("exec USP_gettienthueHOADON");
            foreach (DataRow iteam in data.Rows)
            {
                tongtien = Int32.Parse( iteam["Tien thue"].ToString());

            }
            return tongtien;
        }
        void loadhoadontheothang(int thang)
        {
            DataProvider provide = new DataProvider();
            string query;
            if (cbbThucthe.SelectedIndex==0 && txthds.Text != null)
            {
                query = "exec USP_getdstheosanvoithangHOADON N'San " + txthds.Text + "', " + thang + "";

                dtgthongke.DataSource = provide.ExecuteQuery(query);
            }
            if (cbbThucthe.SelectedIndex == 0 &&ccbthangdoahthu.SelectedIndex >= 0 && ccbthangdoahthu.SelectedIndex <= 11)
            {
                query = "exec USP_getdstheothangHOADON " + thang + "";
               
                dtgthongke.DataSource = provide.ExecuteQuery(query);
                
                
              
                
            }
            txtdoanhthu.Clear();
            long tongtien = 0;
            string v = "Tiền thuê";
            for (int i = 0; i < dtgthongke.Rows.Count - 1; i++)
                tongtien += Int32.Parse(dtgthongke.Rows[i].Cells[v].Value.ToString());
            txtdoanhthu.Text = tongtien.ToString();

        }

        private void txthds_TextChanged(object sender, EventArgs e)
        {
            DataProvider provide = new DataProvider();
            string query;
            if (cbbThucthe.SelectedIndex == 0 && ccbthangdoahthu.SelectedIndex >= 0 && ccbthangdoahthu.SelectedIndex <= 11)
            {
                query = "exec USP_getdstheosanvoithangHOADON N'San " + txthds.Text + "', " + (ccbthangdoahthu.SelectedIndex + 1).ToString() + "";

                dtgthongke.DataSource = provide.ExecuteQuery(query);
            }
            else if ((cbbThucthe.SelectedIndex == 0 && ccbthangdoahthu.SelectedIndex ==12)|| cbbThucthe.SelectedIndex == 0)
            {
                 query = "exec USP_getdstheosanHOADON N'San "+txthds.Text+"'";
                
                dtgthongke.DataSource = provide.ExecuteQuery(query);
               
            }
            
            txtdoanhthu.Clear();
            long tongtien = 0;
            string v = "Tiền thuê";
            for (int i = 0; i < dtgthongke.Rows.Count - 1; i++)
                tongtien += Int32.Parse(dtgthongke.Rows[i].Cells[v].Value.ToString());
            txtdoanhthu.Text = tongtien.ToString();
        }
    }
}
