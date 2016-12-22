using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());

            ulong factorial = 1;

            while (num > 1)
            {
                factorial *= num;
                num--;
            }
            Console.WriteLine(factorial);
        }
    }
}
