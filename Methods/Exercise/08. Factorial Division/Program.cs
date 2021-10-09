using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static double Factorial(int facNumber)
        {
            double result = 1;
            while (facNumber != 1)
            {
                result *= facNumber;
                facNumber--;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int fnum = int.Parse(Console.ReadLine());
            int snum = int.Parse(Console.ReadLine());
            double result1 = Factorial(fnum);
            double result2 = Factorial(snum);

            Console.WriteLine($"{result1 / result2:F2}");
        }
    }
}
