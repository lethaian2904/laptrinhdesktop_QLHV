using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV
{
    internal class HinhTamGiac:HinhVe
    {
        protected float canhA;
        protected float canhB;
        protected float canhC;
        protected float ChieuCao;

        public HinhTamGiac() : base()
        {
            this.canhA = 0.0f;
            this.canhB = 0.0f;
            this.canhC = 0.0f;
        }

        public HinhTamGiac(string mauSac, float tamX, float tamY, float canhA,float canhB, float canhC) : base(mauSac, tamX, tamY)
        {
            this.canhA = canhA;
            this.canhB = canhB;
            this.canhC = canhC;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Chieu dai cua canh A: ");
            canhA = float.Parse(Console.ReadLine());
            Console.WriteLine("Chieu dai cua canh B: ");
            canhB = float.Parse(Console.ReadLine());
            Console.WriteLine("Chieu dai cua canh C: ");
            canhC = float.Parse(Console.ReadLine());

        }
        public override float tinhDT()
        {
            float p = (canhA + canhB + canhC) / 2;
            return (float)Math.Sqrt(p * (p - canhA) * (p - canhB) * (p - canhC));
        }
        public override string loaiHV()
        {
            return "Day la hinh tam giac";
        }
    }
}
