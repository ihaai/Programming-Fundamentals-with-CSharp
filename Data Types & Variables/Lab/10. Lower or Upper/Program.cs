using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char chars = char.Parse(Console.ReadLine());
            if (Char.IsUpper(chars))
                Console.WriteLine("upper-case");
            else
                Console.WriteLine("lower-case");
        }
    }
}
