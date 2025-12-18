using System;

namespace Practice_problems02
{
    public static class TripSummary
    {
        public static void Run()
        {
            Console.Write("Enter traveler name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter fromCity: ");
            string fromCity = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter viaCity: ");
            string viaCity = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter toCity: ");
            string toCity = Console.ReadLine() ?? string.Empty;

            double fromToVia;
            while (true)
            {
                Console.Write("Enter distance from fromCity to viaCity (miles): ");
                if (double.TryParse(Console.ReadLine(), out fromToVia))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            double viaToFinalCity;
            while (true)
            {
                Console.Write("Enter distance from viaCity to toCity (miles): ");
                if (double.TryParse(Console.ReadLine(), out viaToFinalCity))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            double timeTaken;
            while (true)
            {
                Console.Write("Enter time taken for journey (hours): ");
                if (double.TryParse(Console.ReadLine(), out timeTaken))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            double totalDistance = fromToVia + viaToFinalCity;
            Console.WriteLine($"The results of the trip are: {name}, {totalDistance} miles, and {timeTaken} hours");
        }
    }
}