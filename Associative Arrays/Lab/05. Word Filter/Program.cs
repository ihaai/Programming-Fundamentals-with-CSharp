using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();
            words = words.Where(x => x.Length % 2 == 0).Select(x => x.ToString()).ToList();
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
