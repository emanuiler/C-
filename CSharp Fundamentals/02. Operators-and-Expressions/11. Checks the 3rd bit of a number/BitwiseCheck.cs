using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Checks_the_3rd_bit_of_a_number
{
    class BitwiseCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string result;
            result = (number & 0x8) != 0 ? "1" : "0";
            Console.WriteLine(result);
        }
    }
}
