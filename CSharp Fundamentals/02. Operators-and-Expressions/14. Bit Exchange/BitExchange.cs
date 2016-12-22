using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Bit_Exchange
{
    class BitExchange
    {
        static void Main()
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32 int.
            int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            int threeFourFive = number & 0x00000038; // get bits 3-5
            int twentyThreeFourFive = number & 0x07000000; // get bits 24-26
            number &= ~0x07000038; // clear bits 3-5 and 24-26
            number |= threeFourFive << 21; // put bits 3-5 in 24-26
            number |= twentyThreeFourFive >> 21; // put bits 24-26 in 3-5
            
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
        }
    }
}
