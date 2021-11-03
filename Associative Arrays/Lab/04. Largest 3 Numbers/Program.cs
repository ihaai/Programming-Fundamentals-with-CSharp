using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            numbers = numbers.OrderByDescending(n => n).Take(3).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
