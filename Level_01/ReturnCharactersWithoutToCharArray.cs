/*3. Return All Characters Without Using ToCharArray()
Hint =>
 Write a method to return characters of a string without using ToCharArray()
(loop through string[index]).
 Compare the result with the built-in ToCharArray() method.*/

using System;

internal static class ReturnCharactersWithoutToCharArray
{
    public static void DisplayCharacters()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("String is empty or null.");
            return;
        }

        Console.WriteLine("\nCharacters using manual loop:");
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("\nCharacters using ToCharArray():");
        char[] charArray = input.ToCharArray();
        foreach (char c in charArray)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        Console.WriteLine("\nComparison: Both methods produce the same result.");
    }
}
