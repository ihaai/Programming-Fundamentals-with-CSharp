using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            LongerLine(a, b, c, d, x1, y1, x2, y2);
        }

        private static void LongerLine(double a, double b, double c, double d, double x1, double y1, double x2, double y2)
        {
            double sum1 = Math.Abs(a - c) * Math.Abs(a - c) + Math.Abs(b - d) * Math.Abs(b - d);// дължина първа линия 
            double sum2 = Math.Abs(x1 - x2) * Math.Abs(x1 - x2) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2);// дължина втора линия
            if (sum1 >= sum2)
            {
                double sum3 = Math.Abs(a) * Math.Abs(a) + Math.Abs(b) * Math.Abs(b);
                double sum4 = Math.Abs(c) * Math.Abs(c) + Math.Abs(d) * Math.Abs(d);
                if (sum3 <= sum4)
                {
                    Console.WriteLine($"({a}, {b})({c}, {d})");
                }
                else
                {
                    Console.WriteLine($"({c}, {d})({a}, {b})");
                }
            }
            else
            {
                double sum3 = Math.Abs(x1) * Math.Abs(x1) + Math.Abs(y1) * Math.Abs(y1);
                double sum4 = Math.Abs(x2) * Math.Abs(x2) + Math.Abs(y2) * Math.Abs(y2);
                if (sum3 <= sum4)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
        }
    }
}