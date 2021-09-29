using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int summator = 0;
            for (int i = 0; i <= numArray.Length-1; i++)
            {
                if (numArray[i] % 2 == 0)
                {
                    summator += numArray[i];
                }
            }
            Console.WriteLine(summator);
        }
    }
}
