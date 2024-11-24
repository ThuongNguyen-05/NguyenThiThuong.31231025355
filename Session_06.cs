using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThuong._31231025355
{
    internal class Session_06
    {
        private static void Main(string[] args)
        {
            Exercise02_P19();
        }
        public static void Exercise01()
        {
            Console.Write("Nhap so phan tu trong mang : ");
            int N = int.Parse(Console.ReadLine());
            int[] mang = new int[N];
            Console.WriteLine("Nhap phan tu cua mang  ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Phan tu {i + 1} :");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nMang ban dau la: ");
            foreach (int phanTu in mang)
            {
                Console.Write(phanTu + ",");
            }
            TangThemHai(mang);
            Console.Write("\nMang sau khi tang len 2 :");
            foreach (int phanTu in mang)
            { Console.Write(phanTu + ","); }
        }

        static void TangThemHai(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                mang[i] += 2;
            }
        }
        public static void Exercise01_P18()
        {  // Tạo mảng ngẫu nhiên
            int[] mangNgauNhien = TaoMangNgauNhien(10, 1, 100);
            Console.WriteLine("Mang ngau nhien:");
            InMang(mangNgauNhien);

            // 1. Tính giá trị trung bình
            Console.WriteLine($"\nGia tri trung binh: {TinhGiaTriTrungBinh(mangNgauNhien):F2}");

            // 2. Kiểm tra giá trị trong mảng
            Console.WriteLine("\nNhap gia tri can kiem tra:");
            int giaTri = int.Parse(Console.ReadLine());
            Console.WriteLine($"Mang {(KiemTraGiaTri(mangNgauNhien, giaTri) ? "co" : "khong co")} gia tri {giaTri}.");

            // 3. Tìm chỉ số của một giá trị
            Console.WriteLine($"Chi so cua gia tri {giaTri}: {TimChiSo(mangNgauNhien, giaTri)}");

            // 4. Xóa giá trị khỏi mảng
            Console.WriteLine("\nMang sau khi xoa gia tri:");
            int[] mangSauXoa = XoaGiaTri(mangNgauNhien, giaTri);
            InMang(mangSauXoa);

            // 5. Tìm giá trị lớn nhất và nhỏ nhất
            (int max, int min) = TimMaxMin(mangNgauNhien);
            Console.WriteLine($"\nGia tri lon nhat: {max}, Gia tri nho nhat: {min}");

            // 6. Đảo ngược mảng
            Console.WriteLine("\nMang dao nguoc:");
            int[] mangDaoNguoc = DaoNguocMang(mangNgauNhien);
            InMang(mangDaoNguoc);

            // 7. Tìm các giá trị trùng lặp
            Console.WriteLine("\nGia tri trung lap:");
            int[] trungLap = TimGiaTriTrungLap(mangNgauNhien);
            InMang(trungLap);

            // 8. Xóa giá trị trùng lặp
            Console.WriteLine("\nMang sau khi xoa trung lap:");
            int[] khongTrungLap = XoaGiaTriTrungLap(mangNgauNhien);
            InMang(khongTrungLap);
        }
        // Hàm in mảng
        static void InMang(int[] mang) => Console.WriteLine(string.Join(", ", mang));

        // 1. Tạo mảng ngẫu nhiên
        static int[] TaoMangNgauNhien(int kichThuoc, int min, int max)
        {
            Random rand = new Random();
            return Enumerable.Range(0, kichThuoc).Select(_ => rand.Next(min, max)).ToArray();
        }

        // 2. Tính giá trị trung bình của các phần tử mảng
        static double TinhGiaTriTrungBinh(int[] mang) => mang.Average();

        // 3. Kiểm tra giá trị có tồn tại trong mảng
        static bool KiemTraGiaTri(int[] mang, int giaTri) => mang.Contains(giaTri);

        // 4. Tìm chỉ số của một phần tử
        static int TimChiSo(int[] mang, int giaTri) => Array.IndexOf(mang, giaTri);

        // 5. Xóa một phần tử khỏi mảng
        static int[] XoaGiaTri(int[] mang, int giaTri) => mang.Where(x => x != giaTri).ToArray();

        // 6. Tìm giá trị lớn nhất và nhỏ nhất
        static (int max, int min) TimMaxMin(int[] mang) => (mang.Max(), mang.Min());

        // 7. Đảo ngược mảng
        static int[] DaoNguocMang(int[] mang) => mang.Reverse().ToArray();

        // 8. Tìm các giá trị trùng lặp
        static int[] TimGiaTriTrungLap(int[] mang) => mang.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToArray();

        // 9. Xóa các phần tử trùng lặp
        static int[] XoaGiaTriTrungLap(int[] mang) => mang.Distinct().ToArray();
        public static void Exercise02_P19()
        {
            // 1. Bubble Sort: Sắp xếp mảng số nguyên
            Console.WriteLine("Nhap 10 so nguyen:");
            int[] numbers = NhapMangSoNguyen(10);
            Console.WriteLine("\nMang truoc khi sap xep:");
            Inmang(numbers);

            Console.WriteLine("\nSap xep mang bang Bubble Sort:");
            BubbleSort(numbers);
            Inmang(numbers);

            // 2. Linear Search: Tìm từ trong câu
            Console.WriteLine("\nNhap mot cau:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Nhap mot tu can tim trong cau:");
            string word = Console.ReadLine();

            bool found = LinearSearch(sentence, word);
            Console.WriteLine($"Tu '{word}' {(found ? "co" : "khong")} xuat hien trong cau.");
        }
        // Hàm nhập mảng số nguyên từ người dùng
        static int[] NhapMangSoNguyen(int kichThuoc)
        {
            int[] mang = new int[kichThuoc];
            for (int i = 0; i < kichThuoc; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            return mang;
        }

        // Hàm in mảng
        static void Inmang(int[] mang) => Console.WriteLine(string.Join(", ", mang));

        // 1. Thuật toán Bubble Sort
        static void BubbleSort(int[] mang)
        {
            int n = mang.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (mang[j] > mang[j + 1])
                    {
                        // Hoán đổi 2 phần tử
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                    }
                }
            }
        }

        // 2. Linear Search: Tìm từ trong câu
        static bool LinearSearch(string sentence, string word)
        {
            // Chia câu thành các từ
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase)) // So sánh không phân biệt hoa thường
                    return true;
            }
            return false;
        }
        }
}










