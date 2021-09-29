using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i <= intArr.Length-1; i++)
            {
                if (intArr[i] % 2 == 0)
                    sumOdd += intArr[i];
                else
                    sumEven += intArr[i];
            }
            Console.WriteLine(sumOdd - sumEven);
        }
    }
}
