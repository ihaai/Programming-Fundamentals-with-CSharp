using System;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count / 2; i++)
            {
                var sum = list[i] + list[list.Count - i - 1];
                Console.Write(sum + " ");
            }

            if (list.Count % 2 == 1)
            {
            	Console.Write(list[list.Count/2] + " ");
            }
        }
    }
}
