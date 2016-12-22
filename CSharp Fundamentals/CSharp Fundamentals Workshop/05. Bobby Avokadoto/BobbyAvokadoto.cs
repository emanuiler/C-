using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bobby_Avokadoto
{
    class BobbyAvokadoto
    {
        static void Main(string[] args)
        {
            uint bobbyHead = uint.Parse(Console.ReadLine());
            uint combCount = uint.Parse(Console.ReadLine());
            uint best = 0;
            uint bestCount = 0;
            for (int i = 0; i < combCount; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());
            
                if ((bobbyHead & comb) == 0)
                {
                    //count teeth
                    uint currentCount = 0;
                    for (int j = 0; j < 32; j++)
                    {
                        currentCount += ((comb >> j) & 1);
                    }

                    //check if best
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        best = comb;
                    }
                }
            }

            Console.WriteLine(best);
        }
    }
}
