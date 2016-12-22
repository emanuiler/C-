using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Int_Double_String
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "integer":
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num1 + 1);
                    break;
                case "real":
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", num2 + 1);
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
                default:
                    break;
            }
        }
    }
}
