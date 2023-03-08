using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Thong Tin Cua 1 Nguoi");
            Nguoi n = new Nguoi();
            //1
            n.Nhap();

            Console.WriteLine("***************************************");
            //2
            Console.WriteLine(n.Xuat());
            Console.WriteLine("***************************************");

            //3
            List<NhanVien> DSNV = new List<NhanVien>();
            Console.WriteLine("Nhap Thong Tin Cho n Nhan Vien");
            Console.Write("Nhap n = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Nhap Thong Tin Cho Nhan Vien " + (i+1));

                NhanVien NV = new();
                NV.Nhap();
                DSNV.Add(NV);

            }
            Console.WriteLine("***************************************");
            //4
            Console.WriteLine(string.Format("Danh Sach {0} Nhan Vien", N));
            foreach(NhanVien NV in DSNV)
            {
                Console.WriteLine(NV.Xuat());
            }
            Console.WriteLine("***************************************");

            //5
            Console.WriteLine("Danh Sach Nhan Vien Sau Khi Sap Sep Theo Luong");
            DSNV.Sort(new SoSanhNV());
            foreach (NhanVien NV in DSNV)
            {
                Console.WriteLine(NV.Xuat());
            }
        }
    }
}
