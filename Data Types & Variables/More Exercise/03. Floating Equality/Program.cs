using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double nn = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double r = Math.Abs(n - nn);
            Console.WriteLine(r <= eps);
        }
    }
}
