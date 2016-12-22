using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Modify_Bit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());
            byte bitValue = byte.Parse(Console.ReadLine());
            ulong LastBitValue;
            ulong mask = 1;

            LastBitValue = (number >> position) & 1;

            //Checks the value of the numbersBit and the input value of the bit
            if (LastBitValue == 0 && bitValue == 0)
            {
                Console.WriteLine(number);
            }
            else if (LastBitValue == 0 && bitValue == 1)
            {
                mask = mask << position;
                Console.WriteLine(number | mask);
            }
            else if (LastBitValue == 1 && bitValue == 0)
            {
                mask = ~(mask << position);
                Console.WriteLine(number & mask);
            }
            else if (LastBitValue == 1 && bitValue == 1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
