/*
 * Problem 5: Find the Longest Word in a Sentence
 * Write a C# program that takes a sentence as input and returns the longest word 
 * in the sentence.
 */

public class LongestWordFinder
{
    public static string FindLongestWord(string sentence)
    {
        string longest = "";
        string current = "";

        foreach (char c in sentence)
        {
            if (char.IsLetter(c))
            {
                current += c;
            }
            else
            {
                if (current.Length > longest.Length)
                {
                    longest = current;
                }
                current = "";
            }
        }

        if (current.Length > longest.Length)
        {
            longest = current;
        }

        return longest;
    }

    public static void DisplayLongestWord(string sentence)
    {
        string longest = FindLongestWord(sentence);
        Console.WriteLine($"Sentence: {sentence}");
        Console.WriteLine($"Longest Word: {longest}");
        Console.WriteLine($"Length: {longest.Length}");
        Console.WriteLine();
    }
}
