using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Null_Values_Arithmetic
{
    class NullValueArithmetic
    {
        static void Main(string[] args)
        {
            string nonNum = null;
            int num1 = (int)(null+1);
            double num2 = (int)(null*1);
            Console.WriteLine(num1 + " " + num2);
        }
    }
}
