using System;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i+1])
                {
                    list[i] += list[i+1];
                    list.RemoveAt(i+1);
                    i = -1; // We're restarting the loop this way.
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
