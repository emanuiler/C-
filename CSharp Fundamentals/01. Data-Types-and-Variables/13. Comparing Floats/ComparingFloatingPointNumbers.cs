using System;

class ComparingFloatingPointNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double difference = Math.Abs(a - b);
        Console.WriteLine((difference < eps) ? "true" : "false");
    }
}

