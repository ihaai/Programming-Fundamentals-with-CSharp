using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal m = decimal.Parse(Console.ReadLine());
            decimal km = m / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
