using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLHV
{
    internal class DSHV
    {
        private ArrayList list;

        public DSHV()
        {
            list = new ArrayList();
        }
        public void them(HinhVe hv)
        {
            list.Add(hv);
        }
        public void hienThi()
        {
            foreach (HinhVe hv in list)
            {
                Console.WriteLine("Loai hinh: {0}", hv.loaiHV());
                Console.WriteLine("DienTich:{0}", hv.tinhDT());
            }
        }
        public void SoLuongMoiLoai()
        {
            int soHinhChuNhat = 0, soHinhTron = 0, soHinhTamGiac = 0;
            foreach (HinhVe hv in list)
            {
                if (hv is HinhChuNhat) soHinhChuNhat++;
                if (hv is HinhTron) soHinhTron++;
                if (hv is HinhTamGiac) soHinhTamGiac++;
            }

            Console.WriteLine("So luong hinh chu nhat: " + soHinhChuNhat);
            Console.WriteLine("So luong hinh tron: " + soHinhTron);
            Console.WriteLine("So luong hinh tam giac: " + soHinhTamGiac);
        }

        public void HinhDienTichLonNhat()
        {
            HinhVe maxHinhChuNhat = null, maxHinhTron = null, maxHinhTamGiac = null;
            foreach (HinhVe hv in list)
            {
                if (hv is HinhChuNhat && (maxHinhChuNhat == null || hv.tinhDT() > maxHinhChuNhat.tinhDT()))
                {
                    maxHinhChuNhat = hv;
                }
                if (hv is HinhTron && (maxHinhTron == null || hv.tinhDT() > maxHinhTron.tinhDT()))
                {
                    maxHinhTron = hv;
                }
                if (hv is HinhTamGiac && (maxHinhTamGiac == null || hv.tinhDT() > maxHinhTamGiac.tinhDT()))
                {
                    maxHinhTamGiac = hv;
                }
            }

            Console.WriteLine("Hinh chu nhat co dien tich lon nhat:");
            if (maxHinhChuNhat != null)
            {
                Console.WriteLine("Dien tich: " + maxHinhChuNhat.tinhDT());
            }

            Console.WriteLine("Hinh tron co dien tich lon nhat:");
            if (maxHinhTron != null)
            {
                Console.WriteLine("Dien tich: " + maxHinhTron.tinhDT());
            }

            Console.WriteLine("Hinh tam giac co dien tich lon nhat:");
            if (maxHinhTamGiac != null)
            {
                Console.WriteLine("Dien tich: " + maxHinhTamGiac.tinhDT());
            }
        }
    }
}
