using System;
using System.Linq;

namespace _06._Middle_Characters
{
    class Program
    {
        static string MiddleCharacter(string text)
        {
            string storage = string.Empty;
            if (text.Length % 2 == 0)
            {
                storage = text[text.Length / 2 - 1].ToString() + text[text.Length / 2].ToString();
            }
            else
            {
                storage = text[text.Length / 2].ToString();
            }

            return storage;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(text));
        }
    }
}
