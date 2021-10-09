using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleHeight = int.Parse(Console.ReadLine());
            long numberToPrintInTriangle = new long();
            for (long row = 0; row < triangleHeight; row++)
            {
                numberToPrintInTriangle = 1;
                for (long col = 0; col<= row; col++)
                {
                    Console.Write(numberToPrintInTriangle + " ");
                    numberToPrintInTriangle 
                        = numberToPrintInTriangle * (row - col) / (col + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
