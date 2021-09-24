using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int y = c * 100;
            int d = (int)(y * 365.2422);
            int h = d * 24;
            int m = h * 60;
            Console.WriteLine($"{c} centuries = {y} years = {d} days = {h} hours = {m} minutes");
        }
    }
}
