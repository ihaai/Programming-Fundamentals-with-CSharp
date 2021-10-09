using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool randomFlag = true;

            //int N = int.Parse(Console.ReadLine());

            //int[] zigArray1 = new int[N];
            //int[] zigArray2 = new int[N];

            //for (int i = 0; i < N; i++)
            //{
            //    randomFlag = !randomFlag;
            //    int[] val = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //    if (randomFlag)
            //    {
            //        zigArray2[i] = val[1];
            //        zigArray1[i] = val[0];
            //    }
            //    else
            //    {
            //        zigArray2[i] = val[0];
            //        zigArray1[i] = val[1];
            //    }
            //}

            //Console.WriteLine(string.Join(" ", zigArray2));
            //Console.WriteLine(string.Join(" ", zigArray1));

            int lines = int.Parse(Console.ReadLine());
            int[] evenArray = new int[lines];
            int[] oddArray = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    evenArray[i] = numbers[0];
                    oddArray[i] = numbers[1];
                }
                else
                {
                    evenArray[i] = numbers[1];
                    oddArray[i] = numbers[0];
                }
            }
            Console.WriteLine(string.Join(" ", evenArray));
            Console.WriteLine(string.Join(" ", oddArray));
        }
    }
}
