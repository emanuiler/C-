using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Isosceles_Triangle
{
    class DrawingTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            char c = '\u00A9';

            Console.WriteLine("    " + c);
            Console.WriteLine();
            Console.WriteLine("   " + c + " " + c);
            Console.WriteLine();
            Console.WriteLine("  " + c + "   " + c);
            Console.WriteLine();
            Console.Write(" " + c + " " + c + " " + c + " " + c);
            Console.WriteLine();
        }
    }
}

