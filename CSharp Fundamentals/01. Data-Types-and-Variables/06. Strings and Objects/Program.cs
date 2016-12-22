using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string something = "World";
            object ofTwo = greeting + " " + something;
            string one = (string)ofTwo;
            Console.WriteLine(one);
        }
    }
}
