using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThuong._31231025355
{
    internal class Session_05
    {
        static void Main(string[] args)
        {
            Question02_P21();
            Console.ReadKey();
        }
        public static void Question01_P21()
        {
            Console.WriteLine("Nhap so thu nhat :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu ba : ");
            int c = int.Parse(Console.ReadLine());
            int max = maxOfThreeNumber(a, b, c);
            Console.WriteLine($"So lon nhat trong ba so la : {max}");
        }
        static int maxOfThreeNumber(int a, int b, int c)//question01.P21
        {
            int max = 0;
            if (a > b && a > c)
                max = a;
            else if (b > c && b > a)
                max = b;
            else 
                max = c;
            return max;
        }
        public static void Question02_P21()
        {
            Console.WriteLine("Nhap mot so nguyen khong am:");
            int input = int.Parse(Console.ReadLine());

            try
            {
                long result = CalculateFactorial(input);
                Console.WriteLine($"Giai thua cua {input} là: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static long CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("So phai la mot so nguyen khong am.");

            if (number == 0 || number == 1)
                return 1; // Trường hợp cơ sở: 0! = 1 và 1! = 1

            return number * CalculateFactorial(number - 1); // Gọi đệ quy
        }

        public static void Question03_P21()
        {
            Console.WriteLine("Nhap mot so de kiem tra co phai so nguyen to khong:");
            int number = int.Parse(Console.ReadLine());

            if (isPrime(number))
                Console.WriteLine($"{number} la so nguyen to.");
            else
                Console.WriteLine($"{number} khong phai la so nguyen to.");
        }
        static bool isPrime(int number)
        {
            if (number <2 ) return false;
            for (int i = 2; i <= number/2; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
        public static void Question04_P21()
        {
            Console.Write("Nhap so gioi han:");
            int limit = int.Parse(Console.ReadLine());
            PrintPrimesLessThan(limit);

            Console.Write("Nhap so so nguyen to dau tien muon in ra :");
            int n = int.Parse(Console.ReadLine());
            printFisrtNprime(n);
        }
        static void PrintPrimesLessThan(int limit)
        {
            Console.WriteLine($"Cac so nguyen to be hon {limit}:");
            for (int i = 2; i < limit; i++)
            {
                if (isPrime(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void printFisrtNprime(int n)
        {
            int so = 2;
            int dem = 0;
            while (dem<n)
            {
                if (isPrime(so))
                { Console.Write(so + ",");
                    dem++;
                }
                so++;
            }
        }
        public static void Question05_P21()
        {
            Console.WriteLine("Nhap so de kiem tra co phai so hoan hao khong:");
            int input = int.Parse(Console.ReadLine());

            if (IsPerfect(input))
                Console.WriteLine($"{input} la so hoan hao.");
            else
                Console.WriteLine($"{input} khong phai la so hoan hao.");
            PrintPerfectNumbersLessThan(1000);
        }
        static bool IsPerfect(int number)
        {
            if (number <= 1)
                return false;

            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum == number;
        }
        static void PrintPerfectNumbersLessThan(int limit)
        {
            Console.WriteLine($"So hoan hao be hon {limit}:");
            for (int i = 2; i < limit; i++)
            {
                if (IsPerfect(i))
                    Console.WriteLine(i);
            }
        }
        public static void Question06_P21()
        {
            Console.WriteLine("Nhap mot chuoi de kiem tra co phai pangram hay khong:");
            string input = Console.ReadLine();

            if (IsPangram(input))
                Console.WriteLine("Chuoi nay la 1  pangram.");
            else
                Console.WriteLine("Chuoi nay khong phai la 1 pangram.");
        }
        static bool IsPangram(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Tạo một mảng boolean để theo dõi sự xuất hiện của từng chữ cái (26 chữ cái)
            bool[] alphabetTracker = new bool[26];
            int index;

            // Chuyển chuỗi sang chữ thường để kiểm tra không phân biệt chữ hoa/chữ thường
            input = input.ToLower();

            foreach (char c in input)
            {
                // Kiểm tra nếu ký tự là chữ cái
                if (c >= 'a' && c <= 'z')
                {
                    index = c - 'a'; // Map 'a' to 0, 'b' to 1, ..., 'z' to 25
                    alphabetTracker[index] = true;
                }
            }

            // Kiểm tra nếu tất cả chữ cái được đánh dấu là xuất hiện
            foreach (bool letterPresent in alphabetTracker)
            {
                if (!letterPresent)
                    return false;
            }

            return true;
        }

    }
}
