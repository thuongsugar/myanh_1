using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Nguoi
    {
        String MaDD { set; get; }
        String HoTen { set; get; }

        public Nguoi() { }
        public Nguoi(String MaDD, String HoTen)
        {
            this.MaDD = MaDD;
            this.HoTen = HoTen;
        }
        ~Nguoi()
        {
            Console.WriteLine("Ham huy");
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap Ma DD: ");
            this.MaDD = Console.ReadLine();

            Console.WriteLine();
            
            Console.Write("Nhap Ho Ten: ");
            this.HoTen = Console.ReadLine();

            Console.WriteLine();
        }
        public virtual String  Xuat()
        {
            return string.Format("Ma DD: {0}, HoTen: {1}",MaDD,HoTen);
        }
    }
}
