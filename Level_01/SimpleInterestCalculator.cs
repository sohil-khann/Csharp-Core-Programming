// Problem 1: Calculate Simple Interest
// Description: Input the Principal, Rate, and Time values and calculate Simple Interest
// Formula: Simple Interest = Principal * Rate * Time / 100

class SimpleInterestCalculator
{
    public static void CalculateSimpleInterest()
    {
        
        Console.Write("Enter Principal amount: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Rate of Interest (%): ");
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Time (years): ");
        double time = double.Parse(Console.ReadLine());
        
        double simpleInterest = ComputeSimpleInterest(principal, rate, time);
        
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
    
    private static double ComputeSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}
