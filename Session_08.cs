using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenThiThuong._31231025355
{
    internal class Session_08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi:");
            string chuoi = Console.ReadLine();
            Console.WriteLine($"Chuoi vua nhap la:{chuoi}");
            //1.tinh do dai cua chuoi
            Console.WriteLine($"Do dai cua chuoi la : {TinhDoDaiChuoi(chuoi)}");
            //2.tach tung ky tu cua chuoi
            Console.WriteLine($"Chuoi sau khi tach la: ");
            TachKyTu(chuoi);
            //3. In cac ky tu nguoc lai
            Console.WriteLine("Cac ky tu nguoc lai:");
            InKyTuNguoc(chuoi);
            //4.Dem so tu 
            int sotu = DemSoTu(chuoi);
            Console.WriteLine($"Chuoi co {sotu} tu ");
            //5.So sanh hai chuoi 
            Console.WriteLine("Nhap chuoi thu hai :");
            string chuoi2= Console.ReadLine();
            Console.WriteLine(sosanhhaichuoi(chuoi,chuoi2));
            Console.WriteLine(chuoi.CompareTo(chuoi2));
            //6.KT chu, so, ky tu dac biet
            Demchusovakytudb(chuoi, out int so, out int chu, out int kytudb);

            // In kết quả
            Console.WriteLine($"So ky tu so: {so}");
            Console.WriteLine($"So ky tu chu: {chu}");
            Console.WriteLine($"So ky tu dac biet: {kytudb}");
           



        }
        //Tim do dai chuoi
        static int TinhDoDaiChuoi(string chuoi)
        {
            int dem = 0;
            foreach (var _ in chuoi)
            {
                dem++;
            }
            return dem;
        }
        //Tach ky tu
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
        //Dem so tu 
        static int DemSoTu(string chuoi)
        {
            int count = 0;
            //bo khoang trang thua co trong chuoi
            chuoi =chuoi.Trim();
            while (chuoi.IndexOf("  ")!=-1)
            {
                chuoi.Replace("  ", " ") ;
            }
            //dem
            foreach (char c in chuoi)
                if (c == ' ') count++;
            return count+1;
        }
        //So sannh hai chuoi : tra ve 0 neu s1==s2, 1 neu s1>s2,-1 neu s1<s2
        static int sosanhhaichuoi(string chuoi, string chuoi2)
        {
            int min_len = chuoi.Length < chuoi2.Length ? chuoi.Length : chuoi2.Length;
            for (int i = 0; i < min_len; i++)
            {
                if (chuoi[i] > chuoi2[i]) return 1;
                if (chuoi[i] < chuoi2[i]) return -1;
            }
            return chuoi.Length > chuoi2.Length ? 1 : chuoi.Length < chuoi2.Length ? -1 : 0;
        }
        // Dem chu, so va ky tu dac biet
        static void Demchusovakytudb(string chuoi, out int so, out int chu, out int kytudb)
        {
            // Khởi tạo các biến đếm
            so = 0;
            chu = 0;
            kytudb = 0;

            // Duyệt qua từng ký tự trong chuỗi
            foreach (char c in chuoi)
            {
                if (c >= '0' && c <= '9') // Kiểm tra ký tự số
                    so++;
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) // Kiểm tra ký tự chữ
                    chu++;
                else // Các ký tự khác là ký tự đặc biệt
                    kytudb++;
            }
        }

    }
}
