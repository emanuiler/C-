using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(input, 2).ToString());
    }
}

