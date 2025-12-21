// Problem 4: Triangular Park Running Rounds
// Description: An athlete runs in a triangular park with given sides. Calculate how many rounds needed for 5 km run
// Formula: Perimeter = side1 + side2 + side3, Rounds = 5000 / Perimeter (converting 5 km to meters)

class TriangularParkRunner
{
    public static void CalculateRunningRounds()
    {
        
        Console.Write("Enter side 1 of triangle (meters): ");
        double side1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter side 2 of triangle (meters): ");
        double side2 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter side 3 of triangle (meters): ");
        double side3 = double.Parse(Console.ReadLine());
        
        double rounds = CalculateRounds(side1, side2, side3);
        
        Console.WriteLine($"The athlete needs to complete {Math.Ceiling(rounds)} full rounds to cover 5 km (or {rounds:F2} rounds approximately)");
    }
    
    private static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        return 5000.0 / perimeter;
    }
}
