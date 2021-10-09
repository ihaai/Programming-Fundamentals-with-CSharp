using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int firstIndex = 0; firstIndex < array.Length; firstIndex++)
            {
                bool isGreaterThanAll = true;
                for (int secondIndex = firstIndex + 1; secondIndex < array.Length; secondIndex++)
                {
                    if (array[firstIndex] <= array[secondIndex])
                    {
                        isGreaterThanAll = false;
                    }
                }
                if (isGreaterThanAll)
                {
                    Console.Write(array[firstIndex] + " ");
                }
            }
        }
    }
}
