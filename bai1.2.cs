using System;

class Program
{
    static void Main()
    {
        double a, b;

        // Nhap so thu nhat
        while (true)
        {
            Console.Write("Nhap so thu nhat: ");

            if (double.TryParse(Console.ReadLine(), out a))
                break;

            Console.WriteLine("Du lieu khong hop le! Vui long nhap lai.");
        }

        // Nhap so thu hai
        while (true)
        {
            Console.Write("Nhap so thu hai: ");

            if (double.TryParse(Console.ReadLine(), out b))
                break;

            Console.WriteLine("Du lieu khong hop le! Vui long nhap lai.");
        }

        // 5 phep toan
        Console.WriteLine("\n===== 5 PHEP TOAN =====");

        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));

        if (b != 0)
        {
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));
        }
        else
        {
            Console.WriteLine("Khong the thuc hien phep chia va chia du cho 0!");
        }

        // Toan tu gan phuc hop
        Console.WriteLine("\n===== TOAN TU GAN PHUC HOP =====");

        double x = a;

        x += b;
        Console.WriteLine("Sau khi x += b: " + x);

        x -= b;
        Console.WriteLine("Sau khi x -= b: " + x);

        x *= b;
        Console.WriteLine("Sau khi x *= b: " + x);

        if (b != 0)
        {
            x /= b;
            Console.WriteLine("Sau khi x /= b: " + x);

            x %= b;
            Console.WriteLine("Sau khi x %= b: " + x);
        }
        else
        {
            Console.WriteLine("Khong the thuc hien /= va %= voi 0.");
        }

        Console.ReadKey();
    }
}