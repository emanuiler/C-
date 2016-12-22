using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Point_Circle_Rectangle
{
    class PointInsideOutside
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(Math.Abs(x - 1), 2) + Math.Pow(Math.Abs(y - 1), 2));
            // Circle coordinates K({1, 1}, 1,5)  R(top=1, left=-1, width=6, height=2)
            if (x >= -0.5 && x <= 2.5 && y >= -0.5 && y <= 2.5 && distance <= 1.5)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if (x >= -1 && x <= 5 && y >= -1 && y <= 1)
            {
                Console.Write("inside rectangle");
                Console.WriteLine();
            }
            else
            {
                Console.Write("outside rectangle");
                Console.WriteLine();
            }
        }
    }
}
