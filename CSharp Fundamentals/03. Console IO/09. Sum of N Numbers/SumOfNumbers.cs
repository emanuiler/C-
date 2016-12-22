using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_of_N_Numbers
{
    class SumOfNumbers
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            float sum = 0;
            for (int i = 0; i < n; i++)
            {
                float number = float.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
