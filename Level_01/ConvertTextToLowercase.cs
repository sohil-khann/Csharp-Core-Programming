using static System.Net.Mime.MediaTypeNames;
/*
10.Convert Text to Lowercase
 Hint =>
 Write a method to convert each character in a string to lowercase using ASCII
logic(char manipulation).
 Compare the result with the built-in string.ToLower().*/
using System;

internal static class ConvertTextToLowercase
{
    public static string ManualToLowercase(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (c >= 'A' && c <= 'Z')
            {
                result[i] = (char)(c + 32);
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }

    public static void CompareLowercaseMethods()
    {
        Console.Write("Enter text to convert: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        string manualResult = ManualToLowercase(input);
        string builtInResult = input.ToLower();

        Console.WriteLine($"\nOriginal text: {input}");
        Console.WriteLine($"Manual conversion: {manualResult}");
        Console.WriteLine($"Built-in ToLower(): {builtInResult}");

        if (manualResult == builtInResult)
        {
            Console.WriteLine("\nBoth methods produce identical results.");
        }
        else
        {
            Console.WriteLine("\nResults differ.");
        }
    }
}
