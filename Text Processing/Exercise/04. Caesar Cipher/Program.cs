using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(Char.ConvertFromUtf32(message[i]+3));
            }
        }
    }
}
