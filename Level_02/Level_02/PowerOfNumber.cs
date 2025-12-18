using System;

namespace Level_02Programs
{
    public static class PowerOfNumber
    {
        public static void Run()
        {
            Console.Write("Enter base integer: ");
            if (!int.TryParse(Console.ReadLine(), out int number)) { Console.WriteLine("Invalid"); return; }
            Console.Write("Enter power (non-negative integer): ");
            if (!int.TryParse(Console.ReadLine(), out int power) || power < 0) { Console.WriteLine("Invalid"); return; }

            long result = 1;
            for (int i = 1; i <= power; i++) result *= number;

            Console.WriteLine($"Result: {result}");
        }
    }
}
