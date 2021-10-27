using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Randomize_Words
{
    class Program
    {

        static void WordScramble(List<string> str, Random rnd)
        {
            for (int i = 0; i < str.Count; i++)
            {
                int positionToSwap = rnd.Next(str.Count);
                string temporaryElement = str[i];
                str[i] = str[positionToSwap];
                str[positionToSwap] = temporaryElement;
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            var text = Console.ReadLine().Split().ToList();
            WordScramble(text, rnd);

            Console.WriteLine(string.Join("\n", text));
        }
    }
}
