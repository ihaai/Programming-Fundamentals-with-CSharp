using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string input = Console.ReadLine();
            int startIndex = input.IndexOf(remove);
            while (input.IndexOf(remove) >= 0)
            {
                input = input.Remove(startIndex, remove.Length);
                startIndex = input.IndexOf(remove);
            }
            Console.WriteLine(input);
        }
    }
}