using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Biggest_of_3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            List<float> numbersList = new List<float>();
            numbersList.Add(a);
            numbersList.Add(b);
            numbersList.Add(c);
            numbersList.Sort();
            Console.WriteLine(numbersList[0]);
        }
    }
}
