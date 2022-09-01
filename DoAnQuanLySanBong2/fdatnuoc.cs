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
using DoAnQuanLySanBong2.DOT;

namespace DoAnQuanLySanBong2
{
    public partial class fdatnuoc : Form
    {
        public fdatnuoc()
        {
            InitializeComponent();
            loadnuoc();
            loadccbnuuoc();
            
        }
        void loadnuoc()
        {
            DataProvider provider = new DataProvider();
            string query = "select * from Nuoc";
            dtgLoadnuoc.DataSource = provider.ExecuteQuery(query);
        }
        void loadtext()
        {

        }

        private void dtgLoadnuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        List<string> listItem;
        void loadccbnuuoc()
        {
            listItem = new List<string>();
           for(int i = 0; i< dtgLoadnuoc.RowCount-1; i++)
            {
                listItem.Add(dtgLoadnuoc.Rows[i].Cells[1].Value.ToString());
               
            }
            ccbNuoc.DataSource = listItem;
        }

        private void ccbNuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(ccbNuoc.SelectedItem.ToString());
        }
    }
}
