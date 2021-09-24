using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal len, wid, V = 0m;
            len = decimal.Parse(Console.ReadLine());
            wid = decimal.Parse(Console.ReadLine());
            V = decimal.Parse(Console.ReadLine());
            V = (len * wid * V) / 3m;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {V:f2}");
        }
    }
}
