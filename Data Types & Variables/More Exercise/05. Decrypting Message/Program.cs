using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int NL = int.Parse(Console.ReadLine());
            string message = null;

            for (int i = 1; i <= NL; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                ch += (char)key;
                message += ch;
            }
            Console.WriteLine(message);
        }
    }
}
