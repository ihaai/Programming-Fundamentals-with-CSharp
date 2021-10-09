using System;
using System.Collections.Generic;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void NXNMatrix(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write(size + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            NXNMatrix(size);
        }
    }
}
