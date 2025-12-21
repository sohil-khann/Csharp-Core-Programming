// Problem 12: Trigonometric Functions Calculator
// Description: Calculate various trigonometric functions (sine, cosine, tangent) given an angle in degrees
// Returns: An array with [sine, cosine, tangent]

class TrigonometricCalculator
{
    public static void CalculateTrigonometricFunctions()
    {
        
        Console.Write("Enter angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());
        
        double[] results = GetTrigonometricValues(angle);
        
        Console.WriteLine($"For angle {angle}°:");
        Console.WriteLine($"Sine: {results[0]:F6}");
        Console.WriteLine($"Cosine: {results[1]:F6}");
        Console.WriteLine($"Tangent: {results[2]:F6}");
    }
    
    private static double[] GetTrigonometricValues(double angle)
    {
        double radians = angle * Math.PI / 180.0;
        
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);
        
        return new double[] { sine, cosine, tangent };
    }
}
