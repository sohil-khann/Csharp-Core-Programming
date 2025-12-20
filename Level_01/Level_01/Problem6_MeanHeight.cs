using System;

public static class Problem6_MeanHeight
{
    public static void run()
    {
        double[] heights = new double[11];
        Console.WriteLine("Enter heights for 11 players:");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Player {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out heights[i]))
            {
                Console.WriteLine("Invalid input, using 0.");
                heights[i] = 0.0;
            }
        }

        double sum = 0.0;
        for (int i = 0; i < heights.Length; i++) sum += heights[i];
        double mean = sum / heights.Length;

        Console.WriteLine($"Mean height: {mean}");
    }
}
