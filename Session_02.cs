using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThuong._31231025355
{
    internal class Session_02
    {
        private static void Main()
        {
            Question_02();
            Console.ReadKey();
        }
        public static void Question_01()
        {
            Console.Write("Nhap so a : ");
            int a = int.Parse(Console.ReadLine()); ;
            Console.Write("Nhap so b : ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"Thuc hien phep cong : {a}+{b}={c}");
        }
        public static void Question_02()
        {
            Console.Write("Nhap so a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b : ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Sau hoan doi so a = {a} , b = {b} ");
        }
        public static void Question_03()
        {
            Console.Write("Nhap so a : ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b : ");
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"Ket qua : {a} * {b} = {c}");
        }
        public static void Question_04()
        {
            Console.Write("Nhap so feet : ");
            float f = float.Parse(Console.ReadLine());
            const float feetToMeter = 0.3048f;
            double m = f * feetToMeter;
            Console.WriteLine($"So feet da nhap doi quan meter : {f} feet = {m} meter ");
        }
        public static void Question_05()
        {
            Console.WriteLine("Chuyen doi nhiet do");
            Console.WriteLine("1. Chuyen tu Celsius sang Fahrenheit");
            Console.WriteLine("2. Chuyen tu Fahrenheit sang Celsius");
            Console.Write("Chon (1 or 2): ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Nhap do Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else if (choice == 2)
            {
                Console.Write("Nhap do Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
            }
            else
            {
                Console.WriteLine("Lua chon khong ton tai");
            }
        }
        public static void Question_06()
        {
            Console.WriteLine("Size of basic data types in C#:");
            Console.WriteLine($"Size of bool: {sizeof(bool)} byte");
            Console.WriteLine($"Size of byte: {sizeof(byte)} byte");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of short: {sizeof(short)} bytes");
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of long: {sizeof(long)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of decimal: {sizeof(decimal)} bytes");
        }
        public static void Question_07()
        {
            Console.Write("Nhap chu muon chon : ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int asciiValue = (int)inputChar;
            Console.WriteLine($"{inputChar} in ASCII = {asciiValue}");
        }
        public static void Question_08()
        {
            Console.WriteLine("Nhap ban kinh duong tron ");
            float r = float.Parse(Console.ReadLine());
            double area = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine($"Dien tich hinh tron la : {area} ");
        }
        public static void Question_09()
        {
            Console.Write("Nhap do dai canh hinh vuong : ");
            float a = float.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine($"Dien tich hinh vuong :{area}");
        }
        public static void Question_10()
        {
            Console.WriteLine("Nhap so ngay can tinh : ");
            int days = int.Parse(Console.ReadLine());
            int year = days / 365;
            int week = (days - year * 365) / 7;
            int day = (days - year * 365) % 7;
            Console.WriteLine($" {days} days = {year} years, {week} weeks, {day} days");
            
        }
    }
}
