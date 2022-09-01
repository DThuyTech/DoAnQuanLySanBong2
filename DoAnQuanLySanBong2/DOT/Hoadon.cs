using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLySanBong2.DOT
{
    internal class Hoadon
    {
        private int mahoadon;
        private string ngaylap;
        private float giobatdau;
        private float gioketthuc;
        private int makhachang;
        private int tongtien;
        private int mapds;

        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string NgayLap { get => ngaylap; set => ngaylap = value; }
        public float Giobatdau { get => giobatdau; set => giobatdau = value; }
        public float Gioketthuc { get => gioketthuc; set => gioketthuc = value; }
        public int Makhachhang { get => makhachang; set => makhachang = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int Mapds { get => mapds; set => mapds = value; }

        public Hoadon(int mahoadon, string ngaylap, float giobatdau, float gioketthuc, int makhachang, int tongtien,int mapds)
        {
            Mahoadon = mahoadon;
            NgayLap = ngaylap;
            Giobatdau = giobatdau;
            Gioketthuc = gioketthuc;
            Makhachhang = makhachang;
            Tongtien = tongtien;
            Mapds = mapds;
        }

        public Hoadon(System.Data.DataRow row)
        {
            this.mahoadon = (int)row["mahoadon"];
            this.ngaylap = row["ngaylap"].ToString();
            this.giobatdau = (float)row["giobatdau"];
            this.gioketthuc = (float)row["gioketthuc"];
            this.makhachang = (int)row["makhachhang"];
            this.tongtien = (int)row["tongtien"];
            this.mapds = (int)row["mapds"];
        }
        public Hoadon()
        {

        }
    }
}
