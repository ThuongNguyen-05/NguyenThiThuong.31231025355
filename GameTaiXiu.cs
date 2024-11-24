using System;

namespace NguyenThiThuong._31231025355
{
    internal class GameTaiXiu
    {
        static int userBalance = 1000; // Số tiền ban đầu
        static int totalRounds = 0;    // Tổng số vòng chơi
        static int totalWins = 0;      // Số lần thắng
        static int totalLosses = 0;    // Số lần thua

        // Hàm quay xúc xắc
        static int rollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }

        // Hàm chơi một vòng
        static void playOneRound()
        {
            Console.WriteLine($"So tien hien tai cua ban: {userBalance}");
            Console.WriteLine("Ban muon dat cuoc bao nhieu tien ?");
            int betAmount;

            // Nhập số tiền cược và kiểm tra
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out betAmount) && betAmount > 0 && betAmount <= userBalance)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("So tien khong hop le, vui long nhap lai:");
                }
            }

            int com_dice = rollDice();
            Console.WriteLine("Ban doan Tai hay Xiu <T/X>?");
            string user_guessing = Console.ReadLine();
            bool userWon = false;

            if (user_guessing.ToUpper().Equals("T"))
            {
                if (com_dice >= 10) // Tài
                {
                    Console.WriteLine($"Ban Thang ! Tong diem la {com_dice} (Tai)");
                    userWon = true;
                }
                else
                {
                    Console.WriteLine($"Ban Thua ! Tong diem la {com_dice} (Xiu)");
                }
            }
            else if (user_guessing.ToUpper().Equals("X"))
            {
                if (com_dice < 10) // Xỉu
                {
                    Console.WriteLine($"Ban Thang ! Tong diem la {com_dice} (Xiu)");
                    userWon = true;
                }
                else
                {
                    Console.WriteLine($"Ban Thua ! Tong diem la {com_dice} (Tai)");
                }
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le. Ban mat luot nay.");
                return;
            }

            // Cập nhật số tiền và thống kê
            totalRounds++;
            if (userWon)
            {
                userBalance += betAmount;
                totalWins++;
            }
            else
            {
                userBalance -= betAmount;
                totalLosses++;
            }
        }

        // Hàm điều khiển trò chơi
        static void game_engine()
        {
            do
            {
                if (userBalance <= 0)
                {
                    Console.WriteLine("Ban da het tien. Tro choi ket thuc!");
                    break;
                }

                playOneRound();

                Console.WriteLine("Ban co muon choi tiep khong? <C/K>");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                    break;
            } while (true);

            // Thống kê cuối trò chơi
            Console.WriteLine("=== Thong ke ===");
            Console.WriteLine($"Tong so vong da choi: {totalRounds}");
            Console.WriteLine($"So lan thang: {totalWins}");
            Console.WriteLine($"So lan thua: {totalLosses}");
            Console.WriteLine($"So tien con lai: {userBalance}");
            Console.WriteLine("Hen gap lai lan sau!");
        }

        public static void Main()
        {
            Console.WriteLine("Chao mung den voi tro choi Tai Xiu!");
            game_engine();
        }
    }
}