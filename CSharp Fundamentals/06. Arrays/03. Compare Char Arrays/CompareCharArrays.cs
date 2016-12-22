using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] str1 = Console.ReadLine().ToCharArray();
            char[] str2 = Console.ReadLine().ToCharArray();
            if (str1.Length == str2.Length)
            {
                if (str1.Last() > str2.Last())
                {
                    Console.WriteLine(">");
                }
                else if (str1.Last() < str2.Last())
                {
                    Console.WriteLine("<");
                }
                else if (str1.First() < str2.First())
                {
                    Console.WriteLine("<");
                }
                else if (str1.First() > str2.First())
                {
                    Console.WriteLine(">");
                }
                else
                {
                    Console.WriteLine("=");
                }
            }
            else if (str1.Length < str2.Length)
            {
                Console.WriteLine("<");
            }
            else if (str1.Length > str2.Length)
            {
                Console.WriteLine(">");
            }
        }
    }
}
