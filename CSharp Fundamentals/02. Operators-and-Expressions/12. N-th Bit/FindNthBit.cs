using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.N_th_Bit
{
    class FindNthBit
    {
        static void Main()
        {
            //Get the bit at postion p in a number n 
            long p = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long result = (long)((p >> n) & 1);
            Console.WriteLine(result);

            //  does same thing
            //byte position = byte.Parse(Console.ReadLine());
            //ulong number = ulong.Parse(Console.ReadLine());
            //ulong mask = (ulong)(1 << position);
            //ulong nAndMask = number & mask;
            //ulong bit = nAndMask >> position;
            //Console.WriteLine(bit);
        }
    }
}
