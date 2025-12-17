using System;

public class Program : AddTwoNum

{

    public static void Main(string[] args)

    {
        AddTwoNum p = new AddTwoNum();
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        //int a = Convert.ToInt32(args[0]);
        //int b = Convert.ToInt32(args[1]);

        PrintMessage(p.Add(a, b));
        p.sub(a, b);
        Console.WriteLine("Multiplication is " + p.Multiply(a, b));
        Console.WriteLine("Division is " + p.Divide(a, b));

      Console.ReadKey(); 
    }
}