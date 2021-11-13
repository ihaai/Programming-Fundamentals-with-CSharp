using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string message = Console.ReadLine();
            char currentCharacter = ' ';

            foreach (var chars in message)
            {
                while (chars != currentCharacter)
                {
                    sb.Append(chars);
                    currentCharacter = chars;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
