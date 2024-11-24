using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenThiThuong._31231025355
{
    internal class Session_04

    {
        public static void Main()
        {
            Question08_P22();
        }
        public static void Question02_Page09()
        {
            //Write a C# Sharp program to display certain values of the function x = y2 +2y + 1(using integer numbers for y, ranging from - 5 to + 5).
            Console.WriteLine("Tinh x = y^2 + 2y + 1 khi y chay tu -5 toi +5:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(" y  |   x");
            Console.WriteLine("----|-------");

            for (int y = -5; y <= 5; y++)
            {
                // Tinh gia tri cua x
                int x = y * y + 2 * y + 1;

                // In ket qua
                Console.WriteLine($" {y,2} | {x,5}");
            }
        }
        public static void Question03_Page09()
        {
            //Write a C# Sharp program that takes distance and time (hours, minutes,seconds) as input and displays speed in kilometers per hour(km / h) and miles per hour(miles/ h).

            Console.WriteLine("Nhap khoang cach theo Km :");
            int kcKm = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so gio :");
            int gio = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so phut :");
            int phut = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so giay : ");
            int giay = int.Parse(Console.ReadLine());
            // Tinh thoi gian tong
            double tongtg = gio + (phut / 60.0) + (giay / 3600.0);
            // Tinh toc do theo Km
            double SpeedKm = kcKm / tongtg;
            // Tinh toc do theo Miles
            double KcMiles = kcKm * 0.621371;
            double SpeedMiles = KcMiles / tongtg;
            Console.WriteLine($"Toc do theo Km : {SpeedKm} Km/h");
            Console.WriteLine($"Toc do theo Miles : {SpeedMiles} Miles/h");
        }
        public static void Question05_Page09()
        {
            //Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (IsVowel(input))
            {
                Console.WriteLine("The character is a vowel.");
            }
            else if (char.IsDigit(input))
            {
                Console.WriteLine("The character is a digit.");
            }
            else
            {
                Console.WriteLine("The character is a symbol or consonant.");
            }
        }


            static bool IsVowel(char c)
            {
                char lowerChar = char.ToLower(c);
                return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';


            }
        
        public static void Question01_Page21()
        {
            //Write a C# Sharp program to check whether a given number is even or odd.
            Console.Write("Nhap so muon kiem tra : ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            { Console.WriteLine("So ban nhap la so chan"); }
            else
            { Console.WriteLine("So ban nhap la so le "); }
        }
        public static void Question02_Page21()
        {
            //Write a C# Sharp program to find the largest of three numbers.
            Console.Write("Nhap so a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine($"So lon nhat la:{max}");
        }
        public static void Question03_Page21()
        {
            //Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            Console.Write("Nhap toa do x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y = ");
            int y = int.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Toa do nam o goc toa do ");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Toa do nam o phan tu thu nhat ");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Toa do nam o phan tu thu hai ");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Toa do nam o phan tu thu ba ");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Toa do nam o phan tu thu tu ");
            }
            else if (x == 0)
            {
                Console.WriteLine("Toa do nam tren truc y ");
            }
            else if (y == 0)
            {
                Console.WriteLine("Toa do nam tren truc x ");
            }
        }
        public static void Question01_P22()
        {
            Console.Write("Nhap canh thu nhat a : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh thu hai b : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh thu ba c : ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c || a + c > b || b + c > a)
            {
                if (a == b && b == c)
                { Console.WriteLine("Tam giac nay la tam giac deu "); }
                else if (a == b || a == c || b == c)
                { Console.WriteLine("Tam giac nay la tam giac deu "); }
                else
                { Console.WriteLine("Tam giac nay la tam giac thuong "); }
            }
            else
            { Console.WriteLine("So canh nhap vao khong thoa man hinh nay la mot tam giac "); }
        }
        public static void Question02_P22()
        {
            double sum = 0;
            int count = 10;
            Console.WriteLine("Nhap 10 so vao he thong : ");
            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

            }
            double average = (double)sum / count;

            Console.WriteLine("Tong 10 so da nhap la :" + sum);
            Console.WriteLine("Trung binh cua 10 so la :" + average);
        }
        public static void Question03_P22()
        {
            Console.WriteLine("Nhap vao so nguyen : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Bang nhan cua so nguyen : ");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
        public static void Question0405_P22()
        {
            Console.WriteLine("Nhap so hang cua tam giac : ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Dang tam giac so 1");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine(" ");
            }
            Console.WriteLine("Dang tam giac so 2 :");
            int num = 1;
            for (int i = 1; i <= rows; i++)  // Number of lines for the pattern
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Dang tam giac so 3 :");
            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces
                for (int space = rows - i; space > 0; space--)
                {
                    Console.Write("  ");
                }

                // Print numbers in each row
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
        public static void Question06_P22()
        {
            {
                Console.Write("Nhap so so trong chuoi (n): ");
                int n = int.Parse(Console.ReadLine());
                double sum = 0.0;

                Console.WriteLine("Chuoi so hang: ");
                for (int i = 1; i <= n; i++)
                {
                    if (i == 1)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("+ 1/" + i + " ");
                    }
                    sum += 1.0 / i;
                }

                Console.WriteLine("\nTong cua chuoi " + n + " phan tu la " + sum);
            }

        }
        public static void Question07_P22()
        {
            Console.WriteLine("Nhap gioi han khoang duoi:");
            int lowerBound = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gioi han khoang tren:");
            int upperBound = int.Parse(Console.ReadLine());

            Console.WriteLine($"So hoan hao giua  {lowerBound} va {upperBound}:");

            // Find and display perfect numbers in the range
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (IsPerfectNumber(i))
                    Console.WriteLine(i);
            }
        }
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            // Find all divisors and calculate their sum
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            // Check if the sum of divisors equals the number
            return sum == number;
        }
        public static void Question08_P22()
        {
            Console.WriteLine("Nhap so muon kiem tra:");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
                Console.WriteLine($"{number} la so nguyen to.");
            else
                Console.WriteLine($"{number} khong phai la so nguyen to");
        }

     static bool IsPrime(int number)
        {
            // 0 and 1 are not prime numbers
            if (number <= 1)
                return false;

            // Check divisors from 2 to the square root of the number
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false; // Number is not prime
            }

            return true; // Number is prime
        }

       
        }
           
    }

