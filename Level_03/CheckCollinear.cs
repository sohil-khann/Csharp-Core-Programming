/*10. Write a program to find the 3 points that are collinear using the slope formulae and
area of triangle formulae. check A (2, 4), B (4, 6) and C (6, 8) are Collinear for sampling.
Hint =>
a. Take inputs for 3 points x1, y1, x2, y2, and x3, y3
b. Write a Method to find the 3 points that are collinear using the slope formula. The 3
points A(x1,y1), b(x2,y2), and c(x3,y3) are collinear if the slopes formed by 3 points ab, bc,
and cd are equal.
slope AB = (y2 - y1)/(x2 - x1), slope BC = (y3 - y2)/(x3 - x3)
slope AC = (y3 - y1)/(x3 - x1) Points are collinear if
slope AB = slope BC = slope Ac
c. The method to find the three points is collinear using the area of the triangle formula.
The Three points are collinear if the area of the triangle formed by three points is 0. The area
of a triangle is

area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2))*/
using System;
internal static class CheckCollinear
{
    internal static void Main()
    {
        Console.WriteLine("Enter coordinates of first point (x1 y1): ");
        string[] point1 = Console.ReadLine().Split(' ');
        double x1 = Convert.ToDouble(point1[0]);
        double y1 = Convert.ToDouble(point1[1]);
        Console.WriteLine("Enter coordinates of second point (x2 y2): ");
        string[] point2 = Console.ReadLine().Split(' ');
        double x2 = Convert.ToDouble(point2[0]);
        double y2 = Convert.ToDouble(point2[1]);
        Console.WriteLine("Enter coordinates of third point (x3 y3): ");
        string[] point3 = Console.ReadLine().Split(' ');
        double x3 = Convert.ToDouble(point3[0]);
        double y3 = Convert.ToDouble(point3[1]);
        bool areCollinearBySlope = CheckCollinearityBySlope(x1, y1, x2, y2, x3, y3);
        bool areCollinearByArea = CheckCollinearityByArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine($"Are the points collinear by slope method? {areCollinearBySlope}");
        Console.WriteLine($"Are the points collinear by area method? {areCollinearByArea}");
    }
    private static bool CheckCollinearityBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) * (x3 - x2);
        double slopeBC = (y3 - y2) * (x2 - x1);
        return slopeAB == slopeBC;
    }
    private static bool CheckCollinearityByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }
}
