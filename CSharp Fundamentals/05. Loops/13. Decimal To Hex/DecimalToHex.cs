using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Program
{
    static void Main()
    {
        //long input = long.Parse(Console.ReadLine());
        //string hexValue = input.ToString("X");
        //Console.WriteLine(hexValue);
        long number = long.Parse(Console.ReadLine());
        string hexNumb = Convert.ToString(number, 16).ToUpper();
        Console.WriteLine(hexNumb);
    }
}

