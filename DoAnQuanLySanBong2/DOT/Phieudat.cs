using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySanBong2.DOT
{
    internal class Phieudat
    {
        public int Masan { get => masan; set => masan = value; }
        public int Makhachhang { get => makhachhang; set => makhachhang = value; }
        public float Tiencoc { get => tiencoc; set => tiencoc = value; }
        public float Giodat { get => giodat; set => giodat = value; }
        public float Giotra { get => giotra; set => giotra = value; }
        public int Maphieudat { get => maphieudat; set => maphieudat = value; }
        public string Ngaydat { get => ngaydat; set => ngaydat = value; }

        private int masan;

        private int makhachhang;

        private int maphieudat;

        private float tiencoc;

        private float giodat;

        private float giotra;

        private string ngaydat;
        public Phieudat(int masan, int makhachhang, int maphieudat, float tiencoc, float giodat, float giotra, string ngaydat)
        {
            this.makhachhang = makhachhang;
            this.masan = masan;
            this.maphieudat = maphieudat;
            this.tiencoc = tiencoc;
            this.giodat = giodat;
            this.Giotra = giotra;
            this.Ngaydat = ngaydat;
        }
        public Phieudat(System.Data.DataRow row)
        {
            this.maphieudat = (int)row["mapds"];
            this.makhachhang = (int)row["makhachhang"];
            this.masan = (int)row["masan"];
            this.tiencoc = Int32.Parse(row["tiencoc"].ToString());
            this.Ngaydat = row["ngaydat"].ToString();
            this.giodat = float.Parse(row["giodat"].ToString());
            this.giotra = float.Parse(row["giotra"].ToString());
        }
        public Phieudat(Phieudat obj) 
        {
            this.maphieudat = obj.maphieudat;
            this.makhachhang = obj.makhachhang;
            this.masan = obj.masan;
            this.tiencoc = obj.tiencoc;
            this.giodat = obj.giodat;
            this.giotra = obj.giotra;
            this.ngaydat = obj.ngaydat;
        }
        public Phieudat() { }
    }

}
