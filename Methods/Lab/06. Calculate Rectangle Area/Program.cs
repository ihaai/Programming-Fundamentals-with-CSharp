using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(a, b));
        }
    }
}
