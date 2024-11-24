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
            Exercise05_P33();
            Console.ReadKey();
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
        public static void Exercise01_P18()//Single Dimension Arrays
        {
            // Tạo mảng ngẫu nhiên
            int[] mang = TaoMangNgauNhien(10);

            // In mảng ban đầu
            Console.WriteLine("Mang ban dau: " + string.Join(", ", mang));

            // 1. Tinh gia tri trung binh
            Console.WriteLine("Trung binh cua mang: " + TinhTrungBinh(mang));

            // 2. Kiem tra xem mang co chua gia tri x hay khong
            Console.WriteLine("Mang co chua gia tri 5: " + KiemTraGiaTri(mang, 5));

            // 3. Tim chi so cua mot phan tu trong mang
            Console.WriteLine("Chi so cua gia tri 5: " + TimChiSo(mang, 5));

            // 4. Xoa mot phan tu khoi mang
            mang = XoaPhanTu(mang, 5);
            Console.WriteLine("Mang sau khi xoa gia tri 5: " + string.Join(", ", mang));

            // 5. Tim gia tri lon nhat va nho nhat
            Console.WriteLine("Gia tri lon nhat trong mang: " + TimMax(mang));
            Console.WriteLine("Gia tri nho nhat trong mang: " + TimMin(mang));

            // 6. Dao nguoc mang
            mang = DaoNguocMang(mang);
            Console.WriteLine("Mang sau khi dao nguoc: " + string.Join(", ", mang));

            // 7. Tim gia tri trung lap trong mang
            var duplicates = TimGiaTriTrungLap(mang);
            Console.WriteLine("Gia tri trung lap: " + string.Join(", ", duplicates));

            // 8. Xoa cac gia tri trung lap trong mang
            mang = XoaGiaTriTrungLap(mang);
            Console.WriteLine("Mang sau khi xoa gia tri trung lap: " + string.Join(", ", mang));
        }
        // Tao mang ngau nhien
        static int[] TaoMangNgauNhien(int soPhanTu)
        {
            Random rand = new Random();
            int[] mang = new int[soPhanTu];
            for (int i = 0; i < soPhanTu; i++)
            {
                mang[i] = rand.Next(1, 101); // Giá trị ngẫu nhiên từ 1 đến 100
            }
            return mang;
        }

        // Tinh trung binh cua mang
        static double TinhTrungBinh(int[] mang)
        {
            return mang.Average();
        }

        // Kiem tra xem mang co chua gia tri x
        static bool KiemTraGiaTri(int[] mang, int giaTri)
        {
            return mang.Contains(giaTri);
        }

        // Tim chi so cua mot phan tu trong mang
        static int TimChiSo(int[] mang, int giaTri)
        {
            return Array.IndexOf(mang, giaTri);
        }

        // Xoa mot phan tu khoi mang
        static int[] XoaPhanTu(int[] mang, int giaTri)
        {
            return mang.Where(val => val != giaTri).ToArray();
        }

        // Tim gia tri lon nhat trong mang
        static int TimMax(int[] mang)
        {
            return mang.Max();
        }

        // Tim gia tri nho nhat trong mang
        static int TimMin(int[] mang)
        {
            return mang.Min();
        }

        // Dao nguoc mang
        static int[] DaoNguocMang(int[] mang)
        {
            Array.Reverse(mang);
            return mang;
        }

        // Tim gia tri trung lap trong mang
        static int[] TimGiaTriTrungLap(int[] mang)
        {
            var duplicates = mang.GroupBy(x => x)
                                 .Where(g => g.Count() > 1)
                                 .Select(g => g.Key)
                                 .ToArray();
            return duplicates;
        }

        // Xoa gia tri trung lap trong mang
        static int[] XoaGiaTriTrungLap(int[] mang)
        {
            return mang.Distinct().ToArray();
        }
        public static void Exercise02_P19()//Algorithms on Single Dimension Arrays
        {
            // Bước 1: Yêu cầu người dùng nhập 10 số nguyên và sắp xếp chúng bằng thuật toán sắp xếp nổi bọt (Bubble Sort)
            int[] soNguyen = NhapSoNguyen(10);
            Console.WriteLine("Mang ban dau: " + string.Join(", ", soNguyen));
            BubbleSort(soNguyen);
            Console.WriteLine("Mang sau khi sap xep theo Bubble Sort: " + string.Join(", ", soNguyen));

            // Bước 2: Yêu cầu người dùng nhập một câu và tìm kiếm một từ trong câu bằng thuật toán tìm kiếm tuyến tính (Linear Search)
            Console.Write("\nNhap mot cau: ");
            string cau = Console.ReadLine();
            Console.Write("Nhap tu can tim: ");
            string tu = Console.ReadLine();
            bool ketQua = LinearSearch(cau, tu);
            Console.WriteLine("Tu '{0}' {1} trong cau.", tu, ketQua ? "co" : "khong co");
        }
        // Hàm nhập mảng số nguyên
        static int[] NhapSoNguyen(int soLuong)
        {
            int[] mang = new int[soLuong];
            Console.WriteLine($"Nhap {soLuong} so nguyen:");
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write($"So {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            return mang;
        }

        // Hàm thực hiện thuật toán Bubble Sort
        static void BubbleSort(int[] mang)
        {
            int n = mang.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (mang[j] > mang[j + 1])
                    {
                        // Hoán đổi hai phần tử nếu chúng không đúng thứ tự
                        int tam = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = tam;
                    }
                }
            }
        }

        // Hàm thực hiện thuật toán Linear Search
        static bool LinearSearch(string cau, string tu)
        {
            string[] tuTrongCau = cau.Split(' ');
            foreach (string tuTrong in tuTrongCau)
            {
                if (tuTrong.Equals(tu, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        public static void Exercise03_P26()//Two-Dimensional Arrays - exercises
        {
            // Nhap so hang va so cot
            Console.Write("Nhap so hang (N): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot (M): ");
            int m = int.Parse(Console.ReadLine());

            // Tao ma tran ngau nhien
            int[,] maTran = TaoMaTran(n, m);

            // In ma tran
            Console.WriteLine("\nMa tran ngau nhien:");
            InMaTran(maTran);

            // In hang/cot
            Console.Write("\nNhap chi so hang/cot (i): ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("In hang (Row) hay cot (Column)? (R/C): ");
            string loai = Console.ReadLine().ToUpper();
            bool laHang = loai == "R";
            InHangCot(maTran, i, laHang);

            // Tim gia tri lon nhat
            Console.WriteLine("\nGia tri lon nhat trong ma tran: " + TimMax(maTran));

            // Tim gia tri nho nhat trong hang/cot i
            Console.WriteLine("\nGia tri nho nhat trong hang/cot " + i + ": " + TimMin(maTran, i, laHang));

            // Chuyen vi ma tran va in
            int[,] maTranChuyenVi = ChuyenViMaTran(maTran);
            Console.WriteLine("\nMa tran chuyen vi:");
            InMaTran(maTranChuyenVi);

            // In cac gia tri cheo chinh va cheo phu
            Console.WriteLine("\nCheo chinh va cheo phu:");
            InCheo(maTran);
        }
        // Ham tao ma tran ngau nhien
        static int[,] TaoMaTran(int soHang, int soCot)
        {
            Random rand = new Random();
            int[,] maTran = new int[soHang, soCot];
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    maTran[i, j] = rand.Next(1, 101); // Gia tri ngau nhien trong khoang [1, 100]
                }
            }
            return maTran;
        }

        // Ham in ma tran
        static void InMaTran(int[,] maTran)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(maTran[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Ham in hang hoac cot
        static void InHangCot(int[,] maTran, int chiSo, bool inHang)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);

            // Kiểm tra chỉ số hợp lệ
            if (chiSo < 0 || (inHang && chiSo >= soHang) || (!inHang && chiSo >= soCot))
            {
                Console.WriteLine("Chi so hang/cot khong hop le.");
                return;
            }

            if (inHang) // In hang
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(maTran[chiSo, j] + "\t");
                }
                Console.WriteLine();
            }
            else // In cot
            {
                for (int j = 0; j < soHang; j++)
                {
                    Console.Write(maTran[j, chiSo] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Ham tim gia tri lon nhat trong ma tran
        static int TimMax(int[,] maTran)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);
            int max = maTran[0, 0];
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (maTran[i, j] > max)
                        max = maTran[i, j];
                }
            }
            return max;
        }

        // Ham tim gia tri nho nhat trong hang/cot
        static int TimMin(int[,] maTran, int chiSo, bool inHang)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);
            int min = inHang ? maTran[chiSo, 0] : maTran[0, chiSo];

            if (inHang)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (maTran[chiSo, j] < min)
                        min = maTran[chiSo, j];
                }
            }
            else
            {
                for (int j = 0; j < soHang; j++)
                {
                    if (maTran[j, chiSo] < min)
                        min = maTran[j, chiSo];
                }
            }

            return min;
        }

        // Ham chuyen vi ma tran
        static int[,] ChuyenViMaTran(int[,] maTran)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);
            int[,] maTranChuyenVi = new int[soCot, soHang];

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    maTranChuyenVi[j, i] = maTran[i, j];
                }
            }
            return maTranChuyenVi;
        }

        // Ham in cheo chinh va cheo phu
        static void InCheo(int[,] maTran)
        {
            int soHang = maTran.GetLength(0);
            int soCot = maTran.GetLength(1);

            // In cheo chinh
            Console.Write("Cheo chinh: ");
            for (int i = 0; i < Math.Min(soHang, soCot); i++)
            {
                Console.Write(maTran[i, i] + "\t");
            }
            Console.WriteLine();

            // In cheo phu
            Console.Write("Cheo phu: ");
            for (int i = 0; i < Math.Min(soHang, soCot); i++)
            {
                Console.Write(maTran[i, soCot - 1 - i] + "\t");
            }
            Console.WriteLine();
        }
        public static void Exercise04_P32()//Jagged Array – exercises 1

        {
            // Bước 1: Tạo mảng răng cưa với giá trị cố định
            int[][] mangRangCua = {
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 2, 2 },
                new int[] { 3, 3, 3, 3 },
                new int[] { 4, 4 }
            };
            Console.WriteLine("Mang rang cua ban dau:");
            InMangRangCua(mangRangCua);

            // Bước 2: Tạo mảng răng cưa ngẫu nhiên (hoặc nhập từ người dùng)
            int[][] mangNgauNhien = TaoMangRangCua();
            Console.WriteLine("\nMang rang cua ngau nhien:");
            InMangRangCua(mangNgauNhien);

            // Tìm giá trị lớn nhất của từng hàng và của toàn bộ mảng
            Console.WriteLine("\nGia tri lon nhat cua tung hang:");
            TimMaxTungHang(mangNgauNhien, out int maxToanMang);
            Console.WriteLine($"Gia tri lon nhat cua mang: {maxToanMang}");

            // Sắp xếp giá trị tăng dần của từng hàng
            SapXepTangDanTungHang(mangNgauNhien);
            Console.WriteLine("\nMang sau khi sap xep:");
            InMangRangCua(mangNgauNhien);

            // In các số nguyên tố trong mảng
            Console.WriteLine("\nCac so nguyen to trong mang:");
            InSoNguyenTo(mangNgauNhien);

            // Tìm và in tất cả vị trí của một số do người dùng nhập
            Console.Write("\nNhap mot so de tim kiem: ");
            int soCanTim = int.Parse(Console.ReadLine());
            TimViTri(mangNgauNhien, soCanTim);
        }
        // Hàm in mảng răng cưa
        static void InMangRangCua(int[][] mang)
        {
            foreach (var hang in mang)
            {
                Console.WriteLine(string.Join(" ", hang));
            }
        }

        // Hàm tạo mảng răng cưa ngẫu nhiên hoặc nhập từ người dùng
        static int[][] TaoMangRangCua()
        {
            Console.Write("Nhap so hang: ");
            int soHang = int.Parse(Console.ReadLine());
            int[][] mang = new int[soHang][];
            Random rand = new Random();

            for (int i = 0; i < soHang; i++)
            {
                Console.Write($"Nhap so cot cua hang {i + 1}: ");
                int soCot = int.Parse(Console.ReadLine());
                mang[i] = new int[soCot];

                for (int j = 0; j < soCot; j++)
                {
                    mang[i][j] = rand.Next(1, 101); // Tạo số ngẫu nhiên từ 1 đến 100
                }
            }
            return mang;
        }

        // Hàm tìm giá trị lớn nhất của từng hàng và toàn bộ mảng
        static void TimMaxTungHang(int[][] mang, out int maxToanMang)
        {
            maxToanMang = int.MinValue;
            for (int i = 0; i < mang.Length; i++)
            {
                int maxHang = int.MinValue;
                foreach (int giaTri in mang[i])
                {
                    if (giaTri > maxHang)
                        maxHang = giaTri;
                    if (giaTri > maxToanMang)
                        maxToanMang = giaTri;
                }
                Console.WriteLine($"Hang {i + 1}: {maxHang}");
            }
        }

        // Hàm sắp xếp tăng dần từng hàng
        static void SapXepTangDanTungHang(int[][] mang)
        {
            foreach (var hang in mang)
            {
                Array.Sort(hang);
            }
        }

        // Hàm kiểm tra số nguyên tố
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Hàm in số nguyên tố trong mảng
        static void InSoNguyenTo(int[][] mang)
        {
            foreach (var hang in mang)
            {
                foreach (var giaTri in hang)
                {
                    if (LaSoNguyenTo(giaTri))
                        Console.Write(giaTri + " ");
                }
            }
            Console.WriteLine();
        }

        // Hàm tìm và in tất cả vị trí của một số
        static void TimViTri(int[][] mang, int so)
        {
            bool timThay = false;
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = 0; j < mang[i].Length; j++)
                {
                    if (mang[i][j] == so)
                    {
                        Console.WriteLine($"So {so} xuat hien tai vi tri: Hang {i + 1}, Cot {j + 1}");
                        timThay = true;
                    }
                }
            }
            if (!timThay)
            {
                Console.WriteLine($"So {so} khong xuat hien trong mang.");
            }
        }
        public static void Exercise05_P33()//Jagged Array - exercises
        {
            // Khởi tạo dữ liệu
            var nhom = KhoiTaoDuLieu();

            // Menu chương trình
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. In danh sach tat ca thanh vien");
                Console.WriteLine("2. Tim thong tin thanh vien theo ID");
                Console.WriteLine("3. Tim thanh vien co so nhiem vu hoan thanh cao nhat");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Chon chuc nang: ");
                int luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        InDanhSachThanhVien(nhom);
                        break;
                    case 2:
                        TimThanhVienTheoID(nhom);
                        break;
                    case 3:
                        TimThanhVienHoanThanhNhieuNhat(nhom);
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long thu lai.");
                        break;
                }
            }
        }
        // Hàm khởi tạo dữ liệu
        static object[][] KhoiTaoDuLieu()
        {
            object[][] nhom = new object[3][];
            nhom[0] = new object[] {
                new object[] { 101, "Nguyen Van A", 5 },
                new object[] { 102, "Tran Thi B", 8 },
                new object[] { 103, "Le Van C", 6 },
                new object[] { 104, "Pham Thi D", 7 },
                new object[] { 105, "Nguyen Van E", 9 }
            };
            nhom[1] = new object[] {
                new object[] { 201, "Hoang Van F", 10 },
                new object[] { 202, "Bui Thi G", 4 },
                new object[] { 203, "Dang Van H", 3 }
            };
            nhom[2] = new object[] {
                new object[] { 301, "Pham Van I", 6 },
                new object[] { 302, "Tran Thi J", 8 },
                new object[] { 303, "Nguyen Van K", 7 },
                new object[] { 304, "Dang Thi L", 9 },
                new object[] { 305, "Bui Van M", 2 },
                new object[] { 306, "Hoang Thi N", 5 }
            };

            return nhom;
        }

        // Hàm in danh sách tất cả thành viên
        static void InDanhSachThanhVien(object[][] nhom)
        {
            Console.WriteLine("\nDanh sach thanh vien:");
            for (int i = 0; i < nhom.Length; i++)
            {
                Console.WriteLine($"Nhom {i + 1}:");
                foreach (object[] thanhVien in nhom[i])
                {
                    Console.WriteLine($"  ID: {thanhVien[0]}, Ten: {thanhVien[1]}, Nhiem vu hoan thanh: {thanhVien[2]}");
                }
            }
        }

        // Hàm tìm thông tin thành viên theo ID
        static void TimThanhVienTheoID(object[][] nhom)
        {
            Console.Write("Nhap ID thanh vien: ");
            int idCanTim = int.Parse(Console.ReadLine());

            foreach (var nhomNho in nhom)
            {
                foreach (object[] thanhVien in nhomNho)
                {
                    if ((int)thanhVien[0] == idCanTim)
                    {
                        Console.WriteLine($"Thong tin thanh vien:");
                        Console.WriteLine($"  ID: {thanhVien[0]}, Ten: {thanhVien[1]}, Nhiem vu hoan thanh: {thanhVien[2]}");
                        return;
                    }
                }
            }

            Console.WriteLine($"Khong tim thay thanh vien voi ID: {idCanTim}");
        }

        // Hàm tìm thành viên hoàn thành nhiều nhiệm vụ nhất
        static void TimThanhVienHoanThanhNhieuNhat(object[][] nhom)
        {
            object[] thanhVienGioiNhat = null;
            int maxNhiemVu = int.MinValue;

            foreach (var nhomNho in nhom)
            {
                foreach (object[] thanhVien in nhomNho)
                {
                    if ((int)thanhVien[2] > maxNhiemVu)
                    {
                        maxNhiemVu = (int)thanhVien[2];
                        thanhVienGioiNhat = thanhVien;
                    }
                }
            }

            if (thanhVienGioiNhat != null)
            {
                Console.WriteLine("\nThanh vien co so nhiem vu hoan thanh cao nhat:");
                Console.WriteLine($"  ID: {thanhVienGioiNhat[0]}, Ten: {thanhVienGioiNhat[1]}, Nhiem vu hoan thanh: {thanhVienGioiNhat[2]}");
            }
        }
    }
}










