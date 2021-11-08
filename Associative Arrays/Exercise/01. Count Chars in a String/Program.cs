using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();
            var text = Console.ReadLine().Split().ToList();
            var mergedText = string.Join("", text).ToCharArray();

            foreach(var charElement in mergedText)
            {
                if (!counter.ContainsKey(charElement))
                {
                    counter.Add(charElement, 0);
                }

                counter[charElement]++;
            }

            foreach(var dicElement in counter)
            {
                Console.WriteLine($"{dicElement.Key} -> {dicElement.Value}");
            }
        }
    }
}
