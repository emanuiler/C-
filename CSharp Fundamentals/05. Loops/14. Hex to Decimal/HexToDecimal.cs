using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _14.Hex_to_Decimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();
            long result = long.Parse(hexValue, NumberStyles.HexNumber);
            Console.WriteLine(result);
        }
    }
}
