using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var storage = new List<string>();
            var productNumber = 0;

            while (N != 0)
            {
                storage.Add(Console.ReadLine());
                N--;
            }

            var ascendingOrder = storage.OrderBy(x => x).ToList();

            foreach(var element in ascendingOrder)
            {
                ++productNumber;
                Console.WriteLine($"{productNumber}.{element}");
            }
        }
    }
}
