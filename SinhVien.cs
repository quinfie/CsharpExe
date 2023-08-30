using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhLeThaoQuynh
{
    class SinhVien
    {
        protected int maSV;
        protected string hoTen;
        protected double diemLT, diemTH;
        public int MaSV
        {
            get { return maSV; }
            set
            {
                maSV = value;
                if (maSV < 0)
                    throw new Exception("Ma sinh vien phai lon 0");
            }
        }
        public string HoTen
        {
            get { return hoTen; }
            set
            {
                hoTen = value;
                if (hoTen == null)
                    throw new Exception("Ho ten khong duoc rong");
            }
        }
        public double DiemLT
        {
            get { return diemLT; }
            set
            {
                diemLT = value;
                if (diemLT < 0.0 || diemLT > 10.0)
                    throw new Exception("Khong hop le");
            }
        }
        public double DiemTH
        {
            get { return diemTH; }
            set
            {
                diemTH = value;
                if (diemTH < 0.0 || diemTH > 10.0)
                    throw new Exception("Khong hop le");
            }
        }
        public SinhVien()
        {
            this.maSV = 2001216070;
            this.hoTen = "Nguyen Van A";
            this.diemLT = 7.5;
            this.diemTH = 6.5;
        }
        public SinhVien(int maSV, string hoTen, double diemLT, double diemTH)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        }
        public double tinhDTB()
        {
            return (diemLT + diemTH) / 2;
        }
        public void nhap()
        {
            Console.Write("Nhap ma sv: ");
            MaSV = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem ly thuyet: ");
            DiemLT = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem thuc hanh: ");
            DiemTH = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("\nMa sinh vien: {0}", maSV);
            Console.WriteLine("\nHo ten: {0}", hoTen);
            Console.WriteLine("\nDiem ly thuyet: {0}", diemLT);
            Console.WriteLine("\nDiem thuc hanh: {0}", diemTH);
            Console.WriteLine("\nDiem trung binh: {0}", tinhDTB());
        }
    }
}
