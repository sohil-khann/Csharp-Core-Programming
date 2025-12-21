/*
 * Problem 6: Find Substring Occurrences
 * Write a C# program to count how many times a given substring occurs in a string.
 */

public class SubstringCounter
{
    public static int CountOccurrences(string text, string substring)
    {
        if (substring.Length == 0)
            return 0;

        int count = 0;
        int position = 0;

        while (position <= text.Length - substring.Length)
        {
            bool match = true;
            for (int i = 0; i < substring.Length; i++)
            {
                if (text[position + i] != substring[i])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                count++;
            }
            position++;
        }

        return count;
    }

    public static void DisplaySubstringCount(string text, string substring)
    {
        int count = CountOccurrences(text, substring);
        Console.WriteLine($"Text: {text}");
        Console.WriteLine($"Substring: {substring}");
        Console.WriteLine($"Occurrences: {count}");
        Console.WriteLine();
    }
}
