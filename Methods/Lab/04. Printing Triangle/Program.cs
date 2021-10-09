using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void PrintTriangle(int ending)
        {
            for (int i = 1; i <= ending; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleReverse(int ending)
        {
            for (int i = ending - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
            PrintTriangleReverse(input);
        }
    }
}
