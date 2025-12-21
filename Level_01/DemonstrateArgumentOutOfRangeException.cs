/*Demonstrate ArgumentOutOfRangeException
 Hint =>
 Use string.Substring() with start index greater than the end index to generate
an ArgumentOutOfRangeException.
 Use try-catch to handle the exception.*/

using System;

internal static class DemonstrateArgumentOutOfRangeException
{
    public static void InvalidSubstringArgument()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        try
        {
            Console.Write("Enter start index: ");
            int startIdx = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (startIdx > input.Length || length < 0 || startIdx + length > input.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid substring parameters");
            }

            string result = input.Substring(startIdx, length);
            Console.WriteLine($"Substring: {result}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Caught ArgumentOutOfRangeException: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input format.");
        }
    }
}
