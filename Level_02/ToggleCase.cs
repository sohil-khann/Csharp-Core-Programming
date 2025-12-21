/*
 * Problem 7: Toggle Case of Characters
 * Write a C# program to toggle the case of each character in a given string. 
 * Convert uppercase letters to lowercase and vice versa.
 */

public class CaseToggler
{
    public static string ToggleCaseCharacters(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                result += char.ToUpper(c);
            }
            else
            {
                result += c;
            }
        }
        return result;
    }

    public static void DisplayToggledCase(string input)
    {
        string result = ToggleCaseCharacters(input);
        Console.WriteLine($"Original: {input}");
        Console.WriteLine($"Toggled: {result}");
        Console.WriteLine();
    }
}
