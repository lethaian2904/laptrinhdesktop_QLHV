using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV
{
    abstract class HinhVe
    {
        protected string mauSac;
        protected float tamX;
        protected float tamY;

        public HinhVe()
        {
            this.mauSac = "";
            this.tamX = 0.0f;
            this.tamY = 0.0f;
        }

        public HinhVe(string mauSac, float tamX, float tamY)
        {
            this.mauSac = mauSac;
            this.tamX = tamX;
            this.tamY = tamY;
        }

        public virtual void nhap()
        {
            Console.WriteLine("Nhap mau sac cua hinh: ");
            mauSac = Console.ReadLine();
            Console.WriteLine("nhap toa do tam X: ");
            tamX = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do tam Y: ");
            tamY = float.Parse(Console.ReadLine());
        }

        abstract public float tinhDT();

        public virtual string loaiHV()
        {
            return "";
        }
    }
    
    
}
