using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhLeThaoQuynh
{
    class TamGiac
    {
         protected int ma, mb, mc;

        public int MC
        {
            get { return mc; }
            set { mc = value;
            if (mc < 0)
                throw new Exception("gia tri phai lon hon 0");
            }
        }

        public int MB
        {
            get { return mb; }
            set { mb = value;
            if (mb < 0)
                throw new Exception("gia tri phai lon hon 0");
            }
        }

        public int MA
        {
            get { return ma; }
            set { ma = value;
            if (ma < 0)
                throw new Exception("gia tri phai lon hon 0");
            }
        }
        public TamGiac()
        {
            this.ma = 2;
            this.mb = 5;
            this.mc = 4;
        }
        public TamGiac(int mA, int mB, int mC)
        {
            if (mA > 0 && mB > 0 && mC > 0 && (mA + mB) > mC && (mC + mB) > mA && (mA + mC) > mB)
            {
                this.ma = mA;
                this.mb = mB;
                this.mc = mC;
            }
            else
            {
                this.ma = 0;
                this.mb = 0; 
                this.mc = 0;
            }
        }
        public int tinhChuVi()
        {
            return ma + mb + mc;
        }
        public double tinhDienTich()
        {
            double p = tinhChuVi() / 2;
            return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
        }
        public string loaiTamGiac()
        {
            if (ma == 0 && mb == 0 && mc == 0)
                return "Khong phai tam giac";
            else if (ma == mb && ma == mc)
                return "Tam giac deu";
            else if (ma == mb || mb == mc || mc== ma)
                return "Tam giac can";
            else
                return "Tam giac thuong";
        }
        public void xuat()
        {
            Console.Write("mA: {0}\tmB: {1}\tmC: {2}", ma, mb, mc);
            Console.Write("\nLoai tam giac: {0}", loaiTamGiac());
            Console.Write("\nChu vi: {0}", tinhChuVi());
            Console.Write("\nDien tich: {0}", tinhDienTich());
        }
    }
}
