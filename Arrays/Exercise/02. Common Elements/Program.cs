using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringCollector = new List<string>();
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            foreach(var i in secondArray)
            {
                if (firstArray.Contains(i))
                {
                    stringCollector.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", stringCollector));
        }
    }
}
