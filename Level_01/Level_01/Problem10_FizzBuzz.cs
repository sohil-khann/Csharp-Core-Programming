using System;

public static class Problem10_FizzBuzz
{
    public static void run()
    {
        Console.Write("Enter a positive integer: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Enter a positive integer.");
            return;
        }

        string[] results = new string[n + 1];
        for (int i = 0; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0 && i != 0) results[i] = "FizzBuzz";
            else if (i % 3 == 0 && i != 0) results[i] = "Fizz";
            else if (i % 5 == 0 && i != 0) results[i] = "Buzz";
            else results[i] = i.ToString();
        }

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}
