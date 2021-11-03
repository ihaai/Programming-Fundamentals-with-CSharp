using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordOccurences = new Dictionary<string, int>();

            var words = Console.ReadLine().ToLower().Split().ToList();

            for (int i = 0; i < words.Count; i++)
            {
                if (!wordOccurences.ContainsKey(words[i]))
                {
                    wordOccurences.Add(words[i], 0);
                }
                wordOccurences[words[i]]++;
            }

            var odds = wordOccurences.Where(x => x.Value % 2 == 1).Select(x => x.Key).ToList();

            Console.WriteLine(string.Join(" ", odds));
        }
    }
}
