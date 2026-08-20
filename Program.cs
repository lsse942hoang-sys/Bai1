using System;

class Program
{
    static void Main()
    {
        int choice;
        bool continueMenu = true;

        // do-while để lặp lại menu
        do
        {
            DisplayMenu();
            choice = GetMenuChoice();

            // switch-case cho menu
            switch (choice)
            {
                case 1:
                    CalculateFactorial();
                    break;

                case 2:
                    DisplayMultiplicationTable();
                    break;

                case 3:
                    FindPrimeNumbers();
                    break;

                case 4:
                    Console.WriteLine("\nCảm ơn bạn đã sử dụng chương trình. Tạm biệt!");
                    continueMenu = false;
                    break;

                default:
                    Console.WriteLine("\n❌ Lựa chọn không hợp lệ. Vui lòng chọn lại!");
                    break;
            }

            if (continueMenu && choice >= 1 && choice <= 3)
            {
                Console.WriteLine("\nNhấn phím Enter để tiếp tục...");
                Console.ReadLine();
                Console.Clear();
            }

        } while (continueMenu);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("╔══════════════════════════════════╗");
        Console.WriteLine("║      MENU CHƯƠNG TRÌNH CHÍNH     ║");
        Console.WriteLine("╚══════════════════════════════════╝");
        Console.WriteLine("1. Tính giai thừa của một số");
        Console.WriteLine("2. In bảng cửu chương");
        Console.WriteLine("3. Tìm số nguyên tố trong đoạn [a,b]");
        Console.WriteLine("4. Thoát");
        Console.Write("\nChọn chức năng (1-4): ");
    }

    static int GetMenuChoice()
    {
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            return -1;
        }
        return choice;
    }

    // Chức năng 1: Tính giai thừa
    static void CalculateFactorial()
    {
        Console.WriteLine("\n═══════════════════════════════════");
        Console.WriteLine("       TÍNH GIAI THỪA");
        Console.WriteLine("═══════════════════════════════════");

        Console.Write("Nhập số nguyên dương (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("❌ Vui lòng nhập một số nguyên dương!");
            return;
        }

        long factorial = 1;

        // Dùng for để tính giai thừa
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"\n✓ Giai thừa của {n} là: {factorial}");
    }

    // Chức năng 2: In bảng cửu chương
    static void DisplayMultiplicationTable()
    {
        Console.WriteLine("\n═══════════════════════════════════");
        Console.WriteLine("      BẢNG CỬU CHƯƠNG");
        Console.WriteLine("═══════════════════════════════════");

        Console.Write("Nhập bảng muốn in (1-9): ");
        if (!int.TryParse(Console.ReadLine(), out int table) || table < 1 || table > 9)
        {
            Console.WriteLine("❌ Vui lòng nhập số từ 1 đến 9!");
            return;
        }

        Console.WriteLine($"\n--- Bảng cửu chương {table} ---\n");

        // Dùng for để in bảng cửu chương
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{table} × {i:D2} = {table * i:D3}");
        }
    }

    // Chức năng 3: Tìm số nguyên tố trong đoạn [a,b]
    static void FindPrimeNumbers()
    {
        Console.WriteLine("\n═══════════════════════════════════");
        Console.WriteLine("   TÌM SỐ NGUYÊN TỐ TRONG ĐOẠN [a,b]");
        Console.WriteLine("═══════════════════════════════════");

        Console.Write("Nhập a: ");
        if (!int.TryParse(Console.ReadLine(), out int a) || a < 2)
        {
            Console.WriteLine("❌ Vui lòng nhập a ≥ 2!");
            return;
        }

        Console.Write("Nhập b (b > a): ");
        if (!int.TryParse(Console.ReadLine(), out int b) || b <= a)
        {
            Console.WriteLine("❌ Vui lòng nhập b > a!");
            return;
        }

        Console.WriteLine($"\nCác số nguyên tố trong đoạn [{a}, {b}]:\n");

        int primeCount = 0;

        // Dùng for để duyệt qua các số
        for (int num = a; num <= b; num++)
        {
            // Kiểm tra xem số đó có phải nguyên tố không
            if (!IsPrime(num))
            {
                continue; // Bỏ qua nếu không phải số nguyên tố
            }

            Console.Write($"{num}  ");
            primeCount++;

            // break nếu đã tìm được 20 số (tuỳ chọn, bạn có thể bỏ)
            // if (primeCount >= 20) break;
        }

        if (primeCount == 0)
        {
            Console.WriteLine("Không có số nguyên tố trong đoạn này.");
        }
        else
        {
            Console.WriteLine($"\n\n✓ Tổng cộng {primeCount} số nguyên tố được tìm thấy.");
        }
    }

    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        // Kiểm tra chia hết từ 3 đến căn bậc 2 của number
        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}