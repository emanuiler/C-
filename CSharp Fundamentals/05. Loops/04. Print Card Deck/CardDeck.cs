using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Print_Card_Deck
{
    class CardDeck
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n;
            char j = 'J';
            char q = 'Q';
            char k = 'K';
            char a = 'A';
            switch (input)
            {
                case "2":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "3":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "4":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "5":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "6":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "7":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "8":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "9":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "10":
                    n = Convert.ToInt32(input);
                    for (int i = 2; i <= n; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    break;
                case "J":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);                       
                    }
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
                    break;
                case "Q":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
                    break;
                case "K":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", k);
                    break;
                case "A":
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    }
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", k);
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", a);
                    break;

                default:
                    break;
            }
        }
    }
}
