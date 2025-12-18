using System;

namespace Level_02Programs
{
    public static class Friends
    {
        public static void Run()
        {
            Console.WriteLine("Enter ages of Amar, Akbar, Anthony:");
            if (!int.TryParse(Console.ReadLine(), out int amarAge)) { Console.WriteLine("Invalid"); return; }
            if (!int.TryParse(Console.ReadLine(), out int akbarAge)) { Console.WriteLine("Invalid"); return; }
            if (!int.TryParse(Console.ReadLine(), out int anthonyAge)) { Console.WriteLine("Invalid"); return; }

            int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
            string youngest = youngestAge == amarAge ? "Amar" : youngestAge == akbarAge ? "Akbar" : "Anthony";

            Console.WriteLine("Enter heights (cm) of Amar, Akbar, Anthony:");
            if (!double.TryParse(Console.ReadLine(), out double amarH)) { Console.WriteLine("Invalid"); return; }
            if (!double.TryParse(Console.ReadLine(), out double akbarH)) { Console.WriteLine("Invalid"); return; }
            if (!double.TryParse(Console.ReadLine(), out double anthonyH)) { Console.WriteLine("Invalid"); return; }

            double tallestH = Math.Max(amarH, Math.Max(akbarH, anthonyH));
            string tallest = tallestH == amarH ? "Amar" : tallestH == akbarH ? "Akbar" : "Anthony";

            Console.WriteLine($"Youngest: {youngest} ({youngestAge})\nTallest: {tallest} ({tallestH} cm)");
        }
    }
}
