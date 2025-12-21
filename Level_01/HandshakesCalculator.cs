// Problem 2 & 3: Maximum Number of Handshakes
// Description: Find the maximum number of handshakes among N number of students
// Formula: Handshakes = (n * (n - 1)) / 2

class HandshakesCalculator
{
    public static void CalculateHandshakes()
    {
        
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        
        int maxHandshakes = GetMaximumHandshakes(numberOfStudents);
        
        Console.WriteLine($"The maximum number of possible handshakes among {numberOfStudents} students is: {maxHandshakes}");
    }
    
    private static int GetMaximumHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }
}
