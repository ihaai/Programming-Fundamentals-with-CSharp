using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal p = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{p * 1.31m:f3}");
        }
    }
}
