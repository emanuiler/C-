using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_5_Numbers
{
    class SumOfNumbers
    {
        static void Main()
        {
            short firstNum = short.Parse(Console.ReadLine());
            short secondNum = short.Parse(Console.ReadLine());
            short thirdNum = short.Parse(Console.ReadLine());
            short forthNum = short.Parse(Console.ReadLine());
            short fifthNum = short.Parse(Console.ReadLine());
            Console.WriteLine(firstNum + secondNum + thirdNum + forthNum + fifthNum);
        }
    }
}
