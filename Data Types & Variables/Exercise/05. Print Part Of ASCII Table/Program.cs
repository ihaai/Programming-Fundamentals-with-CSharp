using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; start <= end; i++)
            {
                Console.Write((char)i + " ");
                if (i == end)
                    return;
            }
        }
    }
}
