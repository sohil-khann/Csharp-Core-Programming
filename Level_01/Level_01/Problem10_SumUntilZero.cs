using System;

namespace Level_01
{
    public static class Problem10_SumUntilZero
    {
        public static void Run()
        {
            double total = 0.0;
            while (true)
            {
                Console.WriteLine("Enter a number (0 to stop):");
                if (!double.TryParse(Console.ReadLine(), out var v)) { Console.WriteLine("Invalid input"); continue; }
                if (v == 0) break;
                total += v;
            }
            Console.WriteLine($"Total = {total}");
        }
    }
}