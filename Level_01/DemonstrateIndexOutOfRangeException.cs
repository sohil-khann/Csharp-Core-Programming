/*. Demonstrate IndexOutOfRangeException
 Hint =>
 Access an invalid index of a string using charAt() (string[index] in C#) to
generate the exception.
 Write another method with try-catch to handle the exception.*/

using System;

internal static class DemonstrateIndexOutOfRangeException
{
    public static void AccessInvalidStringIndex()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        try
        {
            Console.Write("Enter an index to access: ");
            int index = Convert.ToInt32(Console.ReadLine());

            char character = input[index];
            Console.WriteLine($"Character at index {index}: {character}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index is out of range for the string.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid index input.");
        }
    }

    public static void AccessInvalidArrayIndex()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter an array index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            int value = numbers[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Array index is out of range.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid index format.");
        }
    }
}
