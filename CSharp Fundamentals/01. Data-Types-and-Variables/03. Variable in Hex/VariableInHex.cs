using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Variable_in_Hex
{
    class VariableInHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(254, 16));
            int num = 0xFE;
            Console.WriteLine(num);
        }
    }
}
