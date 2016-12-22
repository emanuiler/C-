using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Formating_Numbers
{
    class FormatingNumbers
    {
        static void Main()
        {
            short a = short.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            string Hex = a.ToString("X");
            string binary = Convert.ToString(a, 2);

            Console.WriteLine("{0,-10}|{1}|{2,10:F2}|{3,-10:F3}|",
                Hex, binary.PadLeft(10, '0'), b, c);
        }
    }
}
