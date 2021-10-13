using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var biggerList = Math.Max(firstList.Count, secondList.Count);
            var mergedList = new List<int>();
            
            for (int i = 0; i < biggerList; i++)
            {
                if (firstList.Count > i)
                    mergedList.Add(firstList[i]);
                if (secondList.Count > i)
                    mergedList.Add(secondList[i]);
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
