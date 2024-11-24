using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThuong._31231025355
{
    internal class Session_07
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            Console.WriteLine($"Chuoi vua nhap: {chuoi}");

            // 1. Tinh do dai chuoi
            Console.WriteLine($"Do dai chuoi (khong dung thu vien): {TinhDoDaiChuoi(chuoi)}");

            // 2. Tach tung ky tu
            Console.WriteLine("Tach tung ky tu cua chuoi:");
            TachKyTu(chuoi);

            // 3. In cac ky tu nguoc lai
            Console.WriteLine("Cac ky tu nguoc lai:");
            InKyTuNguoc(chuoi);

            // 4. Dem so tu trong chuoi
            Console.WriteLine($"So tu trong chuoi: {DemSoTu(chuoi)}");

            // 5. So sanh hai chuoi
            Console.Write("Nhap chuoi thu hai: ");
            string chuoi2 = Console.ReadLine();
            Console.WriteLine($"Hai chuoi co bang nhau khong? {SoSanhChuoi(chuoi, chuoi2)}");

            // 6. Dem chu cai, chu so, ky tu dac biet
            DemKyTu(chuoi, out int soChuCai, out int soChuSo, out int soKyTuDacBiet);
            Console.WriteLine($"Chu cai: {soChuCai}, Chu so: {soChuSo}, Ky tu dac biet: {soKyTuDacBiet}");

            // 7. Dem nguyen am va phu am
            DemNguyenAmPhuAm(chuoi, out int nguyenAm, out int phuAm);
            Console.WriteLine($"Nguyen am: {nguyenAm}, Phu am: {phuAm}");

            // 8. Kiem tra chuoi con
            Console.Write("Nhap chuoi con can tim: ");
            string chuoiCon = Console.ReadLine();
            Console.WriteLine($"Chuoi con co trong chuoi khong? {TimChuoiCon(chuoi, chuoiCon)}");

            // 9. Tim vi tri chuoi con
            int viTri = TimViTriChuoiCon(chuoi, chuoiCon);
            Console.WriteLine($"Vi tri dau tien cua chuoi con: {(viTri == -1 ? "Khong tim thay" : viTri.ToString())}");

            // 10. Kiem tra chu cai va in hoa hoac thuong
            Console.Write("Nhap mot ky tu: ");
            char kyTu = Console.ReadLine()[0];
            KiemTraChuCaiVaHoaThuong(kyTu);

            // 11. Dem so lan xuat hien cua chuoi con
            Console.WriteLine($"So lan xuat hien cua chuoi con: {DemSoLanXuatHien(chuoi, chuoiCon)}");

            // 12. Chen chuoi con truoc chuoi
            Console.WriteLine("Chen chuoi con truoc chuoi: ");
            Console.WriteLine(ChenChuoiCon(chuoi, chuoiCon));
        }

        // Tinh do dai chuoi
        static int TinhDoDaiChuoi(string chuoi)
        {
            int dem = 0;
            foreach (var _ in chuoi)
            {
                dem++;
            }
            return dem;
        }

        // Tach tung ky tu
        static void TachKyTu(string chuoi)
        {
            foreach (var kyTu in chuoi)
            {
                Console.WriteLine(kyTu);
            }
        }

        // In ky tu nguoc lai
        static void InKyTuNguoc(string chuoi)
        {
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                Console.Write(chuoi[i]);
            }
            Console.WriteLine();
        }

        // Dem so tu trong chuoi
        static int DemSoTu(string chuoi)
        {
            if (string.IsNullOrWhiteSpace(chuoi)) return 0;

            int soTu = 0;
            bool trongTu = false;

            foreach (char kyTu in chuoi)
            {
                if (!char.IsWhiteSpace(kyTu))
                {
                    if (!trongTu)
                    {
                        soTu++;
                        trongTu = true;
                    }
                }
                else
                {
                    trongTu = false;
                }
            }

            return soTu;
        }

        // So sanh hai chuoi
        static bool SoSanhChuoi(string chuoi1, string chuoi2)
        {
            if (chuoi1.Length != chuoi2.Length) return false;

            for (int i = 0; i < chuoi1.Length; i++)
            {
                if (chuoi1[i] != chuoi2[i]) return false;
            }

            return true;
        }

        // Dem chu cai, chu so, ky tu dac biet
        static void DemKyTu(string chuoi, out int chuCai, out int chuSo, out int kyTuDacBiet)
        {
            chuCai = chuSo = kyTuDacBiet = 0;

            foreach (char kyTu in chuoi)
            {
                if (char.IsLetter(kyTu))
                {
                    chuCai++;
                }
                else if (char.IsDigit(kyTu))
                {
                    chuSo++;
                }
                else
                {
                    kyTuDacBiet++;
                }
            }
        }

        // Dem nguyen am va phu am
        static void DemNguyenAmPhuAm(string chuoi, out int nguyenAm, out int phuAm)
        {
            nguyenAm = phuAm = 0;
            string nguyenAmChuoi = "aeiouAEIOU";

            foreach (char kyTu in chuoi)
            {
                if (char.IsLetter(kyTu))
                {
                    if (nguyenAmChuoi.Contains(kyTu))
                        nguyenAm++;
                    else
                        phuAm++;
                }
            }
        }

        // Kiem tra chuoi con
        static bool TimChuoiCon(string chuoi, string chuoiCon)
        {
            for (int i = 0; i <= chuoi.Length - chuoiCon.Length; i++)
            {
                int j;
                for (j = 0; j < chuoiCon.Length; j++)
                {
                    if (chuoi[i + j] != chuoiCon[j])
                        break;
                }
                if (j == chuoiCon.Length)
                    return true;
            }

            return false;
        }

        // Tim vi tri chuoi con
        static int TimViTriChuoiCon(string chuoi, string chuoiCon)
        {
            for (int i = 0; i <= chuoi.Length - chuoiCon.Length; i++)
            {
                int j;
                for (j = 0; j < chuoiCon.Length; j++)
                {
                    if (chuoi[i + j] != chuoiCon[j])
                        break;
                }
                if (j == chuoiCon.Length)
                    return i;
            }

            return -1;
        }

        // Kiem tra chu cai va in hoa hoac thuong
        static void KiemTraChuCaiVaHoaThuong(char kyTu)
        {
            if (char.IsLetter(kyTu))
            {
                Console.WriteLine($"Ky tu '{kyTu}' la chu cai.");
                Console.WriteLine(char.IsUpper(kyTu) ? "La chu hoa." : "La chu thuong.");
            }
            else
            {
                Console.WriteLine($"Ky tu '{kyTu}' khong phai la chu cai.");
            }
        }

        // Dem so lan xuat hien cua chuoi con
        static int DemSoLanXuatHien(string chuoi, string chuoiCon)
        {
            int dem = 0;
            int viTri = 0;

            while ((viTri = chuoi.IndexOf(chuoiCon, viTri)) != -1)
            {
                dem++;
                viTri++;
            }

            return dem;
        }

        // Chen chuoi con truoc chuoi
        static string ChenChuoiCon(string chuoi, string chuoiCon)
        {
            int viTri = chuoi.IndexOf(chuoiCon);
            if (viTri != -1)
            {
                return chuoi.Insert(viTri, chuoiCon);
            }
            return chuoi;
        }
    }
}
