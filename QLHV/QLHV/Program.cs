using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSHV list = new DSHV();
            HinhVe hv;
            int chon;
            string tieptuc;

            do
            {
                Console.WriteLine("Nhap hinh:(1_HinhChuNhat, 2_HinhTron, 3_HinhTamGiac):");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        hv = new HinhChuNhat();
                        
                        Console.WriteLine("Nhap chieu rong:");
                        ((HinhChuNhat)hv).chieuRong = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap chieu dai:");
                        ((HinhChuNhat)hinh).ChieuDai = float.Parse(Console.ReadLine());
                        list.them(hinh);
                        break;
                    case 2:
                        hinh = new HinhTron();
                        Console.WriteLine("Nhap mau sac:");
                        hinh.MauSac = Console.ReadLine();
                        Console.WriteLine("Nhap toa do tam (X):");
                        hinh.TamX = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap toa do tam (Y):");
                        hinh.TamY = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap ban kinh:");
                        ((HinhTron)hinh).BanKinh = float.Parse(Console.ReadLine());
                        list.them(hinh);
                        break;
                    case 3:
                        hinh = new HinhTamGiac();
                        Console.WriteLine("Nhap mau sac:");
                        hinh.MauSac = Console.ReadLine();
                        Console.WriteLine("Nhap toa do tam (X):");
                        hinh.TamX = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap toa do tam (Y):");
                        hinh.TamY = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap canh A:");
                        ((HinhTamGiac)hinh).CanhA = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap canh B:");
                        ((HinhTamGiac)hinh).CanhB = float.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap canh C:");
                        ((HinhTamGiac)hinh).CanhC = float.Parse(Console.ReadLine());
                        list.them(hinh);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
                Console.WriteLine("Ban co muon tiep tuc khong? (Y/N)");
                tieptuc = Console.ReadLine();
            } while (tieptuc.Equals("Y", StringComparison.OrdinalIgnoreCase));

            list.hienThi();
            list.SoLuongMoiLoai();
            list.HinhDienTichLonNhat();

            Console.ReadKey();
        }
    }
}
