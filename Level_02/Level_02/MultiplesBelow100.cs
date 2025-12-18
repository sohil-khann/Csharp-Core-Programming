using System;

namespace Level_02Programs
{
    public static class MultiplesBelow100
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            if (!int.TryParse(Console.ReadLine(), out int number)) { Console.WriteLine("Invalid"); return; }

            Console.WriteLine($"Multiples of {number} below 100:");
            for (int i = 100; i >= 1; i--)
            {
                if (i % number == 0) Console.WriteLine(i);
            }
        }
    }
}
