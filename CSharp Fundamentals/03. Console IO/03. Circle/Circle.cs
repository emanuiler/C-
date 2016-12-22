using System;

namespace _03.Circle
{
    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2} {1:F2}",
                2 * Math.PI * r, Math.Pow(r, 2) * Math.PI);
        }
    }
}
