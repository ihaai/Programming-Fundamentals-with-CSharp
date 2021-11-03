using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();


            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms.Add(word, new List<string>());
                }

                wordSynonyms[word].Add(synonym);
            }

            foreach(var syn in wordSynonyms)
            {
                Console.WriteLine($"{syn.Key} - {string.Join(", ", syn.Value)}");
            }
        }
    }
}
