using System;
using System.Collections.Generic;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dividerNumbers = { 2, 3, 6, 7, 10 };
            List<int> numCollector = new List<int>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < dividerNumbers.Length; i++)
            {
                if (num % dividerNumbers[i] == 0)
                {
                    numCollector.Add(dividerNumbers[i]);
                }
            }
            if (numCollector.Count > 0)
            {
                Console.WriteLine($"The number is divisible by {Math.Max(numCollector[0], numCollector[numCollector.Count - 1])}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
