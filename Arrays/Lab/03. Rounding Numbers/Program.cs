using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach(var i in numbers)
            {
                Console.WriteLine($"{Convert.ToDecimal(i)} => {Convert.ToDecimal(Math.Round(i, 0, MidpointRounding.AwayFromZero))}");
            }
        }
    }
}
