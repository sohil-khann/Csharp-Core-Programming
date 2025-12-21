/*
 * Problem 10: Remove a Specific Character from a String
 * Write a C# program to remove all occurrences of a specific character from a string.
 * Example Input:
 * String: "Hello World"
 * Character to Remove: 'l'
 * Expected Output:
 * Modified String: "Heo Word"
 */

public class SpecificCharacterRemover
{
    public static string RemoveCharacter(string input, char charToRemove)
    {
        string result = "";
        foreach (char c in input)
        {
            if (c != charToRemove)
            {
                result += c;
            }
        }
        return result;
    }

    public static void DisplayCharacterRemoved(string input, char charToRemove)
    {
        string result = RemoveCharacter(input, charToRemove);
        Console.WriteLine($"Original String: {input}");
        Console.WriteLine($"Character to Remove: {charToRemove}");
        Console.WriteLine($"Modified String: {result}");
        Console.WriteLine();
    }
}
