using System;

namespace Level_03
{
    public static class DayOfWeekProgram
    {
        public static void Run()
        {
            Console.Write("Enter month (1-12): ");
            if (!int.TryParse(Console.ReadLine(), out int m)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter day: ");
            if (!int.TryParse(Console.ReadLine(), out int d)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter year: ");
            if (!int.TryParse(Console.ReadLine(), out int y)) { Console.WriteLine("Invalid input"); return; }

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            Console.WriteLine($"Day of week (0=Sunday...6=Saturday): {d0}");
        }
    }
}