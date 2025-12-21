// Problem 6: Spring Season Checker
// Description: Check whether given month and day fall in Spring Season
// Spring Season: March 20 (month 3, day 20) to June 20 (month 6, day 20)

class SpringSeasonChecker
{
    public static void CheckSpringSeason()
    {
        
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        
        Console.Write("Enter day (1-31): ");
        int day = int.Parse(Console.ReadLine());
        
        bool isSpringseason = IsSpringseason(month, day);
        
        if (isSpringseason)
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }
    
    private static bool IsSpringseason(int month, int day)
    {
        if (month < 3 || month > 6)
            return false;
        
        if (month == 3 && day < 20)
            return false;
        
        if (month == 6 && day > 20)
            return false;
        
        return true;
    }
}
