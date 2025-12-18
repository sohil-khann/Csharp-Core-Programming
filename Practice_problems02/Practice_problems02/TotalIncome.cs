using System;

namespace Practice_problems02
{
    public static class TotalIncome
    {
        public static void Run()
        {
            decimal salary;
            while (true)
            {
                Console.Write("Enter salary (INR): ");
                if (decimal.TryParse(Console.ReadLine(), out salary))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            decimal bonus;
            while (true)
            {
                Console.Write("Enter bonus (INR): ");
                if (decimal.TryParse(Console.ReadLine(), out bonus))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            decimal total = salary + bonus;
            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {total}");
        }
    }
}