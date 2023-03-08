using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NhanVien : Nguoi
    {
        public static double TienPhuCap = 10;
        public string NamSinh { set; get; }
        public double HeSoLuong { set; get; }

        public NhanVien(): base("MDD_01", "Ten Mac Dinh")
        {
            this.NamSinh = "2000";
            this.HeSoLuong = 2;
        }

        public NhanVien(String MaDD, String HoTen, string NamSinh, double HeSoLuong) : base(MaDD, HoTen)
        {
            this.NamSinh = NamSinh;
            this.HeSoLuong = HeSoLuong;
        }

        public double TinhLuong()
        {
            return HeSoLuong * 1550 + TienPhuCap;
        }
        public static bool operator > (NhanVien a, NhanVien b)
        {
            
            return a.HeSoLuong > b.HeSoLuong;
        }
        public static bool operator <(NhanVien a, NhanVien b)
        {

            return a.HeSoLuong < b.HeSoLuong;
        }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Nhap Nam Sinh: ");
            this.NamSinh = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Nhap He So Luong: ");
            this.HeSoLuong = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
        }

        public override string Xuat()
        {
            return base.Xuat() +  ", " +string.Format("Nam Sinh: {0}, He So Luong: {1}, Luong: {2}",NamSinh, HeSoLuong, this.TinhLuong());
        }

       
    }

    public class SoSanhNV : IComparer<NhanVien>
    {
        public int Compare(NhanVien x, NhanVien y)
        {
            if (x > y) return -1;
            else if (x < y) return 1;
            else return 0;
        }
    }
}
