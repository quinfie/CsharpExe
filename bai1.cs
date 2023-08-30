//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace 2001216094_DinhLeThaoQuynh_Buoi7_LTHDT
//{
//    class PhanSo
//    {
//        private int tuso;
//        private int mauso;
//        public int TuSo
//        {
//            get { return tuso; }
//            set { tuso = value; }
//        }
//        public int MauSo
//        {
//            get { return mauso; }
//            set { mauso = value; }
//        }

//        public PhanSo()
//        {
//            tuso = 1;
//            mauso = 2;
//        }

//        public PhanSo(int tuso, int mauso)
//        {
//            this.tuso = tuso;
//            this.mauso = mauso;
//        }

//        public void Show()
//        {
//            Console.WriteLine("{0} / {1}", tuso, mauso);
//        }

//        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
//        {
//            PhanSo psn = new PhanSo();
//            psn.tuso = ps1.tuso * ps2.mauso + ps2.tuso * ps1.mauso;
//            psn.mauso = ps1.mauso * ps2.mauso;
//            return psn;
//        }

//        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
//        {
//            PhanSo psn = new PhanSo();
//            psn.tuso = ps1.tuso * ps2.mauso - ps2.tuso * ps1.mauso;
//            psn.mauso = ps1.mauso * ps2.mauso;
//            return psn;
//        }

//        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
//        {
//            PhanSo psn = new PhanSo();
//            psn.tuso = ps1.tuso * ps2.tuso;
//            psn.mauso = ps1.mauso * ps2.mauso;
//            return psn;
//        }

//        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
//        {
//            PhanSo psn = new PhanSo();
//            psn.tuso = ps1.tuso * ps2.mauso;
//            psn.mauso = ps1.mauso * ps2.tuso;
//            return psn;
//        }

//        public static bool operator ==(PhanSo ps1, PhanSo ps2)
//        {
//            double x, y;
//            x = (double)ps1.tuso / ps1.mauso;
//            y = (double)ps2.tuso / ps2.mauso;
//            if (x == y)
//                return true;
//            return false;
//        }

//        public static bool operator !=(PhanSo ps1, PhanSo ps2)
//        {
//            double x, y;
//            x = (double)ps1.tuso / ps1.mauso;
//            y = (double)ps2.tuso / ps2.mauso;
//            if (x != y)
//                return true;
//            return false;
//        }

//        public static bool operator <(PhanSo ps1, PhanSo ps2)
//        {
//            double x, y;
//            x = (double)ps1.tuso / ps1.mauso;
//            y = (double)ps2.tuso / ps2.mauso;
//            if (x < y)
//                return true;
//            return false;
//        }

//        public static bool operator >(PhanSo ps1, PhanSo ps2)
//        {
//            double x, y;
//            x = (double)ps1.tuso / ps1.mauso;
//            y = (double)ps2.tuso / ps2.mauso;
//            if (x > y)
//                return true;
//            return false;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int tu, mau;
//            Console.Write("Nhap vao gia tri Tu So : ");
//            tu = Int32.Parse(Console.ReadLine());
//            Console.Write("Nhap vao gia tri Mau So : ");
//            mau = Int32.Parse(Console.ReadLine());

//            PhanSo ps1 = new PhanSo(tu, mau);
//            PhanSo ps2 = new PhanSo();

//            Console.Write("\nPhan so 1 la : ");
//            ps1.Show();
//            Console.Write("\nPhan so 2 la : ");
//            ps2.Show();

//            Console.Write("\n\tCong 2 Phan So : ");
//            PhanSo ps3 = ps1 + ps2;
//            ps3.Show();

//            Console.Write("\tTru 2 Phan So : ");
//            ps3 = ps1 - ps2;
//            ps3.Show();

//            Console.Write("\tNhan 2 Phan So : ");
//            ps3 = ps1 * ps2;
//            ps3.Show();

//            Console.Write("\tChia 2 Phan So : ");
//            ps3 = ps1 / ps2;
//            ps3.Show();

//            if (ps1 == ps2)
//                Console.WriteLine("\n\tHai Phan So Bang Nhau !");
//            else
//                Console.WriteLine("\n\tHai Phan So Khac Nhau !");

//            if (ps1 != ps2)
//            {
//                if (ps1 < ps2)
//                    Console.WriteLine("\n\tPhan so {0} / {1} < Phan so {2} / {3} !", ps1.TuSo, ps1.MauSo, ps2.TuSo, ps2.MauSo);
//                else
//                    Console.WriteLine("\n\tPhan so {0} / {1} > Phan so {2} / {3} !", ps1.TuSo, ps1.MauSo, ps2.TuSo, ps2.MauSo);
//            }
//            else
//                Console.WriteLine("\n\tPhan so {0} / {1} = Phan so {2} / {3} !", ps1.TuSo, ps1.MauSo, ps2.TuSo, ps2.MauSo);
//            Console.ReadKey();
//        }
//    }
//}