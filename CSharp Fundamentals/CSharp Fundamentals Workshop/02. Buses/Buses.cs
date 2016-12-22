using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Buses
{
    class Buses
    {
        static void Main()
        {
            int buses = int.Parse(Console.ReadLine());
            int counter = 1;
            int lastspeed = 0;
            int currentspeed = 0;
            int start = int.MaxValue;
            for (int i = 1; i <= buses; i++)
            {
                int speedOfABus = int.Parse(Console.ReadLine());

                currentspeed = speedOfABus;

                if (currentspeed <= lastspeed && currentspeed <= start)
                {
                    counter++;
                }
                if (speedOfABus <= start)
                {
                    start = speedOfABus;
                }
                lastspeed = currentspeed;
            }
            Console.WriteLine(counter);
        }
    }
}
