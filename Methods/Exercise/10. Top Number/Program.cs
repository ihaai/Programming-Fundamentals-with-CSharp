using System;

namespace _10._Top_Number
{
    class Program
    {
        static bool HasOddDigitInside(int number)
        {
            bool currentCheck = false;
            while (number != 0)
            {
                int temporaryNumber = number % 10;
                number /= 10;
                if (temporaryNumber % 2 != 0)
                {
                    currentCheck = true;
                }
            }

            return currentCheck;
        }

        static bool DivisableByEight(int number)
        {
            int digitSum = 0;
            while (number != 0)
            {
                digitSum += (number % 10);
                number /= 10;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int endingPoint = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endingPoint; i++)
            {
                if (DivisableByEight(i) && HasOddDigitInside(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
