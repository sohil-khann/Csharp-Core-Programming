/*
 * Problem 1: Count Vowels and Consonants
 * Write a C# program to count the number of vowels and consonants in a given string.
 */

public class VowelConsonantCounter
{
    public static void CountVowelsAndConsonants(string input)
    {
        int vowels = 0;
        int consonants = 0;

        foreach (char c in input)
        {
            char lower = char.ToLower(c);
            if (char.IsLetter(c))
            {
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }

        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Vowels: {vowels}");
        Console.WriteLine($"Consonants: {consonants}");
        Console.WriteLine();
    }
}
