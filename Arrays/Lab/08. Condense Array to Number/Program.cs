using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int i = 0;

            if (intArr.Length == 1)
            {
                Console.WriteLine(intArr[0]);
                return;
            }

            while (intArr.Length > 1)
            {
                int[] condensed = new int[intArr.Length - 1];
                for (i = 0; i < intArr.Length - 1; i++)
                {
                    condensed[i] = intArr[i] + intArr[i + 1];
                }
                intArr = condensed;
            }
            Console.WriteLine(intArr[i-1]);
        }
    }
}
