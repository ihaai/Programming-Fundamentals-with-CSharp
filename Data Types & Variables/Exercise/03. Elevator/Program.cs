using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (n <= p)
                Console.WriteLine(1);
            else
                Console.WriteLine((int)Math.Ceiling((double)n / p));
        }
    }
}
