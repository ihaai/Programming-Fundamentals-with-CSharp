using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void IsNegativePositiveOrZero(int first, int second, int third)
        {
            if (first > 0 && second > 0 && third > 0 || first < 0 && second < 0 && third > 0 || first < 0 && second > 0 && third < 0 || first > 0 && second < 0 && third < 0)
                Console.WriteLine("positive");

            else if (first == 0 || second == 0 || third == 0)
                Console.WriteLine("zero");

            else
                Console.WriteLine("negative");
        }

        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            IsNegativePositiveOrZero(number1, number2, number3);
        }
    }
}
