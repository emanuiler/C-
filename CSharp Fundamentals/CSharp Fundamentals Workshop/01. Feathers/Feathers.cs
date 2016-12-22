using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Feathers
{
    class Feathers
    {
        static void Main(string[] args)
        {
            long b = long.Parse(Console.ReadLine());
            long f = long.Parse(Console.ReadLine());
            double avgFeathersPerBird = (double)f / (double)b;
            double magic;
            if (b % 2 == 0)
            {
                magic = avgFeathersPerBird * 123123123123;
                Console.WriteLine("{0:F4}", magic);
            }
            else if (b % 2 != 0)
            {
                magic = avgFeathersPerBird / 317;
                Console.WriteLine("{0:F4}", magic);
            }
        }
    }
}
