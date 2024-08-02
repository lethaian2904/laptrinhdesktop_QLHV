using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV
{
    internal class HinhTron:HinhVe
    {
        protected float banKinh;

        public HinhTron() : base()
        {
            this.banKinh = 0.0f;
        }

        public HinhTron(string mauSac, float tamX, float tamY, float banKinh) : base(mauSac, tamX, tamY)
        {
            this.banKinh = banKinh;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Ban kinh hinh tron la: ");
            banKinh = float.Parse(Console.ReadLine());
            
        }
        public override float tinhDT()
        {
            return (float)(banKinh*banKinh*3.14);
        }
        public override string loaiHV()
        {
            return "Day la hinh tron";
        }
    }
}
