using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = new int();
            int rightSum = new int();

            for (int mainIndex = 0; mainIndex < integerArray.Length; mainIndex++)
            {
                leftSum = 0;
                rightSum = 0;

                // Left side sum loop
                for (int left = 0; left < mainIndex; left++)
                {
                    leftSum += integerArray[left];
                }

                // Right side sum loop
                for (int right = integerArray.Length - 1; right > mainIndex; right--)
                {
                    rightSum += integerArray[right];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(mainIndex);
                    return; // Stopping the program.
                }
            }
            Console.WriteLine("no");
        }
    }
}
