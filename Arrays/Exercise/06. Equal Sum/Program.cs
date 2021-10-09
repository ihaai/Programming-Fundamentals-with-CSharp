using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] leftArr = numbers.Take(numbers.Length / 2).ToArray();
            int[] rightArr = numbers.Skip(numbers.Length / 2).ToArray();


            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int LSUM = 0;
            //int RSUM = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers.Length == 1)
            //    {
            //        Console.WriteLine(0);
            //        return;
            //    }
            //    LSUM = 0;
            //    for (int sumLeft = i; sumLeft > 0; sumLeft--)
            //    {
            //        int nextElementPos = sumLeft - 1;
            //        if (sumLeft > 0)
            //        {
            //            LSUM += numbers[nextElementPos];
            //        }
            //    }

            //    RSUM = 0;
            //    for (int j = i; j < numbers.Length; j++)
            //    {
            //        int nextElementPos = j + 1;
            //        if (j < numbers.Length - 1)
            //        {
            //            RSUM += numbers[nextElementPos];
            //        }
            //    }

            //    if (RSUM == LSUM)
            //    {
            //        Console.WriteLine(i);
            //        return;
            //    }
            //}

            //Console.WriteLine("no");
        }
    }
}
