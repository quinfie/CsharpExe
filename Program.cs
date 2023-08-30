using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhLeThaoQuynh
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon;
            Console.WriteLine("Nhap lua chon : ");
            chon = Int32.Parse(Console.ReadLine());
            switch(chon)
            {
                case 1:
                    ToaDo td = new ToaDo();
                    td.nhap();
                    td.xuat();
                    Console.ReadLine();
                    break;
                case 2:
                    SinhVien sv1 = new SinhVien(001, "Nguyen Van A", 7.5, 6.5);
                    SinhVien sv2 = new SinhVien(002, "Tran Van B", 5.5, 8.5);
                    SinhVien sv3 = new SinhVien();
                    sv3.nhap();
                    sv1.xuat();
                    sv2.xuat();
                    sv3.xuat();
                    Console.ReadLine();
                    break;
                case 3:
                    TamGiac hinh1 = new TamGiac(2, 1, 1);
                    TamGiac hinh2 = new TamGiac(1, 2, 5);
                    TamGiac hinh3 = new TamGiac(3, 3, 3);
                    TamGiac hinh4 = new TamGiac(2, 4, 5);
                    TamGiac hinh5 = new TamGiac(3, 3, 5);
                    Console.Write("Hinh 1: ");
                    hinh1.xuat();
                    Console.Write("\n\nHinh 2: ");
                    hinh2.xuat();
                    Console.Write("\n\nHinh 3: ");
                    hinh3.xuat();
                    Console.Write("\n\nHinh 4: ");
                    hinh4.xuat();
                    Console.Write("\n\nHinh 5: ");
                    hinh5.xuat();
                    Console.ReadLine();
                    break;
                case 4:
                    DangKyXe xe1 = new DangKyXe("Nguyen Thu Loan","Future Neo",35000000,100);
                    DangKyXe xe2 = new DangKyXe("Le Minh Tinh", "Ford Ranger", 250000000, 3000);
                    DangKyXe xe3 = new DangKyXe("Nguyen Minh Triet", "Landscape", 1000000000, 1500);
                    Console.Write("Ten chu xe\t\tLoai xe\t\t\tDung tich\tTri gia\t\tThue phai nop");
                    Console.Write("\n=======================================================================================================\n");
                    xe1.xuat();
                    xe2.xuat();
                    xe3.xuat();
                    Console.ReadLine();
                    break;
            }
            
        }
    }
}
