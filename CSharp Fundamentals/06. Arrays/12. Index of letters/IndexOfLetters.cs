﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                for (char j = 'a'; j <= 'z'; j++)
                {
                    if (word[i] == j)
                        Console.WriteLine("{0}", j - 97);
                }
            }
        }
    }
}
