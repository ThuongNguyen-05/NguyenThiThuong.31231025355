using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThuong._31231025355
{
    internal class Session_03
    {
        public static void Main()
        {
            Question_02();
        }
     
        public static void Question_01()
        {
            Console.Write(" Nhap do C : ");
            float celcius = float.Parse(Console.ReadLine());
            float K = (float)celcius + 273;
            double F = (float)celcius * 18 / 10 + 32;
            Console.WriteLine("Do k tuong ung la = {0}", K);
            Console.WriteLine("Do F tuong ung la = {0}", F);
            Console.ReadKey();

        }
        public static void Question_02()
        {
            Console.Write(" Nhap ban kinh = ");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double S = 4 * pi * Math.Pow(r,2);
            double V = (4 / 3) * pi * Math.Pow(r,3);
            Console.WriteLine(" Dien tich hinh cau = {0}", S);
            Console.WriteLine(" The tich hinh cau  = {0}", V);
        }
        public static void Question_03()
        {
            Console.Write("Nhap so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            double b = double.Parse(Console.ReadLine());
            double cong = a + b;
            double tru = a - b;
            double nhan = a * b;
            double chia = a / b;
            double mod = a % b;
            Console.WriteLine();
            Console.WriteLine($"{a} + {b} = {cong}");
            Console.WriteLine($"{a} - {b} = {tru}");
            Console.WriteLine($"{a} x {b} = {nhan}");
            Console.WriteLine($"{a} / {b} = {chia}");
            Console.WriteLine($"{a} % {b} = {mod}");
        }

    }
}
