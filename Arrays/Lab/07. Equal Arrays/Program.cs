using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var intArr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i <= intArr1.Length-1; i++)
            {
                if (intArr1[i] != intArr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {intArr1.Sum()}");
        }
    }
}
