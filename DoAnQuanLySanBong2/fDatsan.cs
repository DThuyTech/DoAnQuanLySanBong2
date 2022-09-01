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
    public partial class fDatsan : Form
    {
        public fDatsan()
        {
            InitializeComponent();
            LoadflpTaisan();


        }

        struct bDatSan
        {
            public Khachhang kh;
            public Phieudat pdat;
            public Hoadon hdon;

        }
        bDatSan bds = new bDatSan();



        private void LoadflpTaisan()
        {
            List<Sanbong> sbl = SanbongDAO.Instance.LoadDSSan();
            foreach (Sanbong item in sbl)
            {
                Button btn = new Button() { Width = SanbongDAO.Instance.Weigh, Height = SanbongDAO.Instance.Heigh };
                btn.Text = item.Tensan;
                btn.Click += Btn_Click;
                if (item.Trangthai.ToString() == "False")
                {
                    btn.BackColor = Color.Green;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
                flpTaiSandat.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btnSan = (Button)sender;
            Sanbong sb = new Sanbong(SanbongDAO.Instance.LoadSanbong(btnSan.Text));
            txtTensan.Text = sb.Tensan;
            txtLoaisan.Text = sb.Maloai.ToString();
            LoadSan(btnSan.Text);


            //enable
            txtCccd.Enabled = true;
            txtTenkhachhang.Enabled = true;
            txtTiencoc.Enabled = true;
            txtGiodat.Enabled = true;
            txtPhutdat.Enabled = true;
            txtSogiothue.Enabled = true;
            txtSdt.Enabled = true;
            dtpNgaydat.Enabled = true;


        }

        //tai hao don len  datagrid view
        void LoadSan(string tensan)
        {

            string query = "exec USP_getCTHD N'" + txtTensan.Text + "'";
;
            DataProvider provider = new DataProvider();

            dtgThongtinsan.DataSource = provider.ExecuteQuery(query);
            


        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        bool checkgiodatsan(string tensan,int giodat,int giotra,DateTime ngaydat)
        {
            DataProvider procvider = new DataProvider();
            DataTable data = procvider.ExecuteQuery("exec USP_timphieudatsan '" + ngaydat + "' ," + giodat + "," + giotra + ", N'" + tensan + "'");
            if(data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime();
            bds.kh = new Khachhang();
            bds.pdat = new Phieudat();
            bds.hdon = new Hoadon();
            DataProvider provider = new DataProvider();

            if (txtCccd.TextLength >= 12 && txtGiodat.TextLength > 0 && txtPhutdat.TextLength > 0 && txtSdt.TextLength >= 10 && txtSdt.TextLength < 15 && txtTenkhachhang.TextLength
               > 0 && txtSogiothue.TextLength > 0 && Int32.Parse(txtGiodat.Text) > 4 && Int32.Parse(txtGiodat.Text)<=23 && !checkgiodatsan(txtTensan.Text, Int32.Parse(txtGiodat.Text),
                (Int32.Parse(txtTiencoc.Text)+ Int32.Parse(txtSogiothue.Text)),dtpNgaydat.Value))
            {
                Sanbong sb = new Sanbong(SanbongDAO.Instance.LoadSanbong(txtTensan.Text));
                bds.pdat.Tiencoc = Int32.Parse(txtTiencoc.Text);

                bds.pdat.Giodat = Int32.Parse(txtGiodat.Text) + Int32.Parse(txtPhutdat.Text) / 60;
                bds.pdat.Giotra = bds.pdat.Giodat + Int32.Parse(txtSogiothue.Text);
                time = new DateTime(dtpNgaydat.Value.Year, dtpNgaydat.Value.Month, dtpNgaydat.Value.Day);

                bds.pdat.Ngaydat = time.ToString();
                bds.kh.Sdt = txtSdt.Text;
                bds.kh.Tenkhachhang = txtTenkhachhang.Text;
                bds.kh.Cccd = txtCccd.Text;
                string query = "exec  USP_insertKhachHang N'" + bds.kh.Tenkhachhang + "', N'" + bds.kh.Sdt + "', N'" + bds.kh.Cccd + "' ";

                int data = provider.Executenonquery(query);
                bds.kh = new Khachhang(KhachHangDAO.Instances.LoadSanbong(txtTenkhachhang.Text));


                bds.pdat.Makhachhang = bds.kh.Makhachhang;
                bds.pdat.Masan = Int32.Parse(sb.Masan.ToString());

                //load laoi san
                Loaisan ls = new Loaisan(LoaisanDAO.Instance.Loadloaisan(sb.Maloai.ToString()));








                //insert phieudat san
                string query2 = "insert into Phieudatsan values(" + bds.kh.Makhachhang + "," + bds.pdat.Masan + "," + bds.pdat.Tiencoc + ",'" + bds.pdat.Ngaydat + "',"+bds.pdat.Giodat+"," + bds.pdat.Giotra + ",0)";
                data = provider.Executenoquery(query2);
                flpTaiSandat.Controls.Clear();

                bds.pdat = new Phieudat(PhieudatsanDAO.Instance.Loadlastestpds());


                //insert hoadon

              
                
                HoadonDAO.Instance.Insert_hoadon(bds.pdat.Ngaydat, Convert.ToInt32(bds.pdat.Maphieudat), bds.pdat.Giodat, bds.pdat.Giotra, bds.kh.Makhachhang,
                    ls.Giatien * Int32.Parse(txtSogiothue.Text) - bds.pdat.Tiencoc);
                LoadflpTaisan();


                //clear textbox
                cleartextbox();



            }
            else
            {
                MessageBox.Show("Thong tin khong hop le");
            }

          

            
        }

        void cleartextbox()
        {
            txtTiencoc.Clear();
            txtTensan.Clear();
            txtTenkhachhang.Clear();
            txtGiodat.Clear();
            txtSogiothue.Clear();
            txtSdt.Clear();
            txtCccd.Clear();
            txtPhutdat.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cleartextbox();
        }
    }
}
