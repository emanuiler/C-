using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Play_Card
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string cards = "2,3,4,5,6,7,8,9,10,J,Q,K,A";
            string input = Console.ReadLine();
            string[] cardsArray = cards.Split(',').ToArray();
            if (cardsArray.Contains(input))
            {
                Console.WriteLine("yes {0}", input);
            }
            else
            {
                Console.WriteLine("no {0}", input);
            }
        }
    }
}
