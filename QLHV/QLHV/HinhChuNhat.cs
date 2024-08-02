using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV
{
    internal class HinhChuNhat:HinhVe
    {
        protected float chieuDai;
        protected float chieuRong;

        public HinhChuNhat() : base()
        {
            this.chieuDai = 0.0f;
            this.chieuRong = 0.0f;
        }

        public HinhChuNhat(string mauSac, float tamX, float tamY, float chieuDai, float chieuRong) : base(mauSac, tamX, tamY)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Chieu dai cua hinh chu nhat la: ");
            chieuDai = float.Parse(Console.ReadLine());
            Console.WriteLine("Chieu rong cua hinh chu nhat la: ");
            chieuRong = float.Parse(Console.ReadLine());
        }
        public override float tinhDT()
        {
            return (float)(chieuDai * chieuRong);
        }
        public override string loaiHV()
        {
            return "Day la hinh chu nhat";
        }
    }
}
