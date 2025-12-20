using System;

public static class Problem2_PosNegEvenOdd
{
    public static void run()
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Invalid input, using 0.");
                arr[i] = 0;
            }
        }

        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            int n = arr[i];
            if (n > 0)
            {
                string parity = (n % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{n} is positive and {parity}.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} is negative.");
            }
            else
            {
                Console.WriteLine($"{n} is zero.");
            }
        }

        Console.WriteLine();
        int first = arr[0];
        int last = arr[arr.Length - 1];
        if (first == last)
        {
            Console.WriteLine($"First element ({first}) is equal to last element ({last}).");
        }
        else if (first > last)
        {
            Console.WriteLine($"First element ({first}) is greater than last element ({last}).");
        }
        else
        {
            Console.WriteLine($"First element ({first}) is less than last element ({last}).");
        }
    }
}
