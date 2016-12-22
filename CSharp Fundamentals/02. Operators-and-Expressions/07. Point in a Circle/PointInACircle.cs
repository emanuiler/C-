using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Point_in_a_Circle
{
    class PointInACircle
    {
        static void Main()
        {
            double x = Math.Abs(double.Parse(Console.ReadLine()));
            double y = Math.Abs(double.Parse(Console.ReadLine()));
            double distance = Math.Sqrt(Math.Pow(Math.Abs(x), 2) + Math.Pow(Math.Abs(y), 2));
            // Circle coordinates K({0, 0}, 2)  r = 2
            if (distance <= 2)
            {
                Console.WriteLine("yes {0:0.00}", distance);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", distance);
            }
        }
    }
}
