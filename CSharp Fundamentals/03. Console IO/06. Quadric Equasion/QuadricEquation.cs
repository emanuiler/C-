using System;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant == 0)
        {
            double x = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("{0:F2}", x);
        }
        else if (discriminant > 0)
        {
            double leftX = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double rightX = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double biggerX = Math.Max(leftX, rightX);
            double smallerX = Math.Min(leftX, rightX);
            Console.WriteLine("{0:F2}", smallerX);
            Console.WriteLine("{0:F2}",biggerX);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
    }
}

