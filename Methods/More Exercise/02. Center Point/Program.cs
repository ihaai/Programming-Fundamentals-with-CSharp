using System;

namespace _02._Center_Point
{
    class Program
    {
        static void PrintClosest(double x1, double y1, double x2, double y2)
        {
            double firstResult = Math.Abs(x1) + Math.Abs(y1);
            double secondResult = Math.Abs(x2) + Math.Abs(y2);

            if (firstResult < secondResult)
                Console.WriteLine("({0}, {1})", x1, y1);
            else
                Console.WriteLine("({0}, {1})", x2, y2);
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintClosest(x1, y1, x2, y2);
        }
    }
}
