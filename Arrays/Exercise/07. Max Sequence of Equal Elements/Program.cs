using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int biggestOccuringNumber = new int();
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
                        biggestOccuringNumber = array[i];
                    }
                }
                else if (array[i] != array[i + 1])
                {
                    sameOccuranceCount = 0;
                }
                else if (array[i] != array[i + 1] && sameOccuranceCount == 0 && leadingOccuranceCount == 0)
                {
                    biggestOccuringNumber = array[0];
                }
            }



            if (leadingOccuranceCount > 0)
            {
                for (int i = 0; i <= leadingOccuranceCount; i++)
                {
                    Console.Write(biggestOccuringNumber + " ");
                }
            }
            else
            {
                Console.WriteLine(array[0]);
            }
        }
    }
}
