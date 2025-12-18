using System;

public class DoubleOpt
{
    public DoubleOpt(){
       
        Console.Write("Enter first num: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second Num: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Third num: ");
        double c = Convert.ToDouble(Console.ReadLine());
        

        double sum = a + (b * c);
        double difference = (a * b) + c;
        double product = c + (a / b);
        double quotient = (a % b) + c;
        Console.WriteLine($"Result of a + b * c: {sum}");
        Console.WriteLine($"Result of a * b + c: {difference}");
        Console.WriteLine($"Result of  c + a / b: {product}");
        Console.WriteLine($"Result of a % b +c: {quotient}");
    }
}