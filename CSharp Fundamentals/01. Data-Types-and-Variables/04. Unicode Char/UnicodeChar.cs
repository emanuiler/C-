using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Unicode_Char
{
    class UnicodeChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToChar(42));
            int dec = 42;
            char uni = (char)dec;
            Console.WriteLine(uni);
        }
    }
}
