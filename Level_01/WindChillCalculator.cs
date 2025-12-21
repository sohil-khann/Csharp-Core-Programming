// Problem 11: Wind Chill Temperature Calculator
// Description: Calculate wind chill temperature given temperature and wind speed
// Formula: windChill = 35.74 + 0.6215*temp + (0.4275*temp - 35.75) * windSpeed^0.16

class WindChillCalculator
{
    public static void CalculateWindChill()
    {
        
        Console.Write("Enter temperature in Fahrenheit: ");
        double temperature = double.Parse(Console.ReadLine());
        
        Console.Write("Enter wind speed in mph: ");
        double windSpeed = double.Parse(Console.ReadLine());
        
        double windChill = GetWindChillTemperature(temperature, windSpeed);
        
        Console.WriteLine($"Wind chill temperature: {windChill:F2}°F");
    }
    
    private static double GetWindChillTemperature(double temperature, double windSpeed)
    {
        double windChillValue = 35.74 + (0.6215 * temperature) + ((0.4275 * temperature) - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChillValue;
    }
}
