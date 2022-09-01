namespace DoAnQuanLySanBong2
{
    public partial class rfmHethongquanly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rfmHethongquanly));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbnDoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.bbnDatsan = new DevExpress.XtraBars.BarButtonItem();
            this.bbnThanhtoan = new DevExpress.XtraBars.BarButtonItem();
            this.bbnQuanlysan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbnThongke = new DevExpress.XtraBars.BarButtonItem();
            this.rfmHethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnDoimatkhau = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rfmNghiepvu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnDatsan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnThanhtoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnQuanlysan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnTrogiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bbnDoimatkhau,
            this.bbnDatsan,
            this.bbnThanhtoan,
            this.bbnQuanlysan,
            this.barButtonItem1,
            this.bbnThongke});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rfmHethong,
            this.rfmNghiepvu,
            this.rbnTrogiup});
            this.ribbon.Size = new System.Drawing.Size(1335, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbnDoimatkhau
            // 
            this.bbnDoimatkhau.Caption = "Đổi mật khẩu";
            this.bbnDoimatkhau.Id = 1;
            this.bbnDoimatkhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbnDoimatkhau.ImageOptions.SvgImage")));
            this.bbnDoimatkhau.Name = "bbnDoimatkhau";
            this.bbnDoimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbnDoimatkhau_ItemClick);
            // 
            // bbnDatsan
            // 
            this.bbnDatsan.Caption = "Đặt sân";
            this.bbnDatsan.Id = 2;
            this.bbnDatsan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbnDatsan.ImageOptions.SvgImage")));
            this.bbnDatsan.Name = "bbnDatsan";
            this.bbnDatsan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // bbnThanhtoan
            // 
            this.bbnThanhtoan.Caption = "Thanh toán";
            this.bbnThanhtoan.Id = 3;
            this.bbnThanhtoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbnThanhtoan.ImageOptions.SvgImage")));
            this.bbnThanhtoan.Name = "bbnThanhtoan";
            this.bbnThanhtoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbnThanhtoan_ItemClick);
            // 
            // bbnQuanlysan
            // 
            this.bbnQuanlysan.Caption = "Quản lý sân";
            this.bbnQuanlysan.Id = 4;
            this.bbnQuanlysan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbnQuanlysan.ImageOptions.SvgImage")));
            this.bbnQuanlysan.Name = "bbnQuanlysan";
            this.bbnQuanlysan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thống kê";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbnThongke
            // 
            this.bbnThongke.Caption = "Thống kê";
            this.bbnThongke.Id = 10;
            this.bbnThongke.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbnThongke.ImageOptions.SvgImage")));
            this.bbnThongke.Name = "bbnThongke";
            this.bbnThongke.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbnThongke_ItemClick);
            // 
            // rfmHethong
            // 
            this.rfmHethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnDoimatkhau});
            this.rfmHethong.Name = "rfmHethong";
            this.rfmHethong.Text = "Hệ thống";
            // 
            // rbnDoimatkhau
            // 
            this.rbnDoimatkhau.ItemLinks.Add(this.bbnDoimatkhau);
            this.rbnDoimatkhau.Name = "rbnDoimatkhau";
            // 
            // rfmNghiepvu
            // 
            this.rfmNghiepvu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnDatsan,
            this.rbnThanhtoan,
            this.rbnQuanlysan,
            this.ribbonPageGroup1});
            this.rfmNghiepvu.Name = "rfmNghiepvu";
            this.rfmNghiepvu.Text = "Nghiệp vụ";
            // 
            // rbnDatsan
            // 
            this.rbnDatsan.ItemLinks.Add(this.bbnDatsan);
            this.rbnDatsan.Name = "rbnDatsan";
            // 
            // rbnThanhtoan
            // 
            this.rbnThanhtoan.ItemLinks.Add(this.bbnThanhtoan);
            this.rbnThanhtoan.Name = "rbnThanhtoan";
            // 
            // rbnQuanlysan
            // 
            this.rbnQuanlysan.ItemLinks.Add(this.bbnQuanlysan);
            this.rbnQuanlysan.Name = "rbnQuanlysan";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbnThongke);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbnTrogiup
            // 
            this.rbnTrogiup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbnTrogiup.Name = "rbnTrogiup";
            this.rbnTrogiup.Text = "Trợ giúp";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 664);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1335, 30);
            // 
            // rfmHethongquanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 694);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rfmHethongquanly";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Hệ thống quản lý sân bóng";
            this.Load += new System.EventHandler(this.RibbonForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rfmHethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnDoimatkhau;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbnDoimatkhau;
        private DevExpress.XtraBars.BarButtonItem bbnDatsan;
        private DevExpress.XtraBars.BarButtonItem bbnThanhtoan;
        private DevExpress.XtraBars.BarButtonItem bbnQuanlysan;
        private DevExpress.XtraBars.Ribbon.RibbonPage rfmNghiepvu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnDatsan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnThanhtoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnQuanlysan;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnTrogiup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbnThongke;
    }
}