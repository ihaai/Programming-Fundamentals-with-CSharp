using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string biggestOccuringNumber = null;
            int sameOccuranceCount = 0;
            int leadingOccuranceCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    sameOccuranceCount++;
                    if (sameOccuranceCount > leadingOccuranceCount)
                    {
                        leadingOccuranceCount = sameOccuranceCount;
                        biggestOccuringNumber = array[i].ToString();
                    }
                }
                else
                {
                    sameOccuranceCount = 0;
                }
            }

            for (int i = 0; i <= leadingOccuranceCount; i++)
            {
                Console.Write(biggestOccuringNumber + " ");
            }
        }
    }
}
