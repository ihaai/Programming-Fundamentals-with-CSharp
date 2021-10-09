using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {

        static void IsPositiveOrNot(int numberToCheck)
        {
            if (numberToCheck > 0) { Console.WriteLine($"The number {numberToCheck} is positive."); }
            else if (numberToCheck == 0) { Console.WriteLine($"The number {numberToCheck} is zero."); }
            else if (numberToCheck < 0) { Console.WriteLine($"The number {numberToCheck} is negative."); }
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            IsPositiveOrNot(number);
        }
    }
}
