using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetEvenAndOddSumAndMultiply(int number)
        {
            int sumEven = new int();
            int sumOdd = new int();

            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
            }

            return sumEven * sumOdd;
        }

        static void Main(string[] args)
        {
            int numbers = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetEvenAndOddSumAndMultiply(numbers));
        }
    }
}
