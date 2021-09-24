using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char a = 'a'; a < 'a' + n; a++)
            {
                for (char b = 'a'; b < 'a' + n; b++)
                {
                    for (char c = 'a'; c < 'a' + n; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
