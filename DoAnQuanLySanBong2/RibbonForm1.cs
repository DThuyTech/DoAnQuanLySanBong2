using DevExpress.XtraBars;
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
    public partial class rfmHethongquanly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public rfmHethongquanly()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            fMain f = new fMain();
            f.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            fDatsan f = new fDatsan();
            f.ShowDialog();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }

        private void bbnDoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            fDoimatkhau f = new fDoimatkhau();
            f.ShowDialog();
        }

        private void bbnThanhtoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            fThanhtoan f = new fThanhtoan();
            f.ShowDialog();
        }

        private void bbnThongke_ItemClick(object sender, ItemClickEventArgs e)
        {
            Thongke f = new Thongke();
            f.ShowDialog();
        }
    }
}