using System;

public static class Problem3_MultiplicationTable
{
    public static void run()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        int[] table = new int[10];
        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
        }

        Console.WriteLine();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {table[i - 1]}");
        }
    }
}
