using System;

public static class Problem9_Copy2DTo1D
{
    public static void run()
    {
        Console.Write("Enter number of rows: ");
        if (!int.TryParse(Console.ReadLine(), out int rows) || rows <= 0)
        {
            Console.WriteLine("Invalid rows.");
            return;
        }
        Console.Write("Enter number of columns: ");
        if (!int.TryParse(Console.ReadLine(), out int cols) || cols <= 0)
        {
            Console.WriteLine("Invalid columns.");
            return;
        }

        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter matrix elements:");
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write($"Element [{r},{c}]: ");
                if (!int.TryParse(Console.ReadLine(), out matrix[r, c])) matrix[r, c] = 0;
            }
        }

        int[] array = new int[rows * cols];
        int idx = 0;
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                array[idx++] = matrix[r, c];
            }
        }
        string s = String.Join(", ", array);

        Console.WriteLine("1D array: " + s);
        //for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
    }
}
