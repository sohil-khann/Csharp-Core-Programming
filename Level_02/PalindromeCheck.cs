/*
 * Problem 3: Palindrome String Check
 * Write a C# program to check if a given string is a palindrome 
 * (a string that reads the same forward and backward).
 */

public class PalindromeChecker
{
    public static bool IsPalindrome(string text)
    {
        string clean = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c) || char.IsDigit(c))
            {
                clean += char.ToLower(c);
            }
        }

        int left = 0;
        int right = clean.Length - 1;

        while (left < right)
        {
            if (clean[left] != clean[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    public static void CheckPalindrome(string input)
    {
        bool result = IsPalindrome(input);
        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Is Palindrome: {result}");
        Console.WriteLine();
    }
}
