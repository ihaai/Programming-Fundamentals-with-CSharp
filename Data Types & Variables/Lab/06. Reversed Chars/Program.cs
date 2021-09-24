using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char[] cArr = { a, b, c };
            Array.Reverse(cArr);
            Console.WriteLine(string.Join(" ", cArr));
        }
    }
}
