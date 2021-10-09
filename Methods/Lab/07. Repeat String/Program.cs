using System;

namespace _07._Repeat_String
{
    class Program
    {
        static string StringRepeat(string str, int count)
        {
            string storage = null;
            for (int i = 0; i < count; i++)
            {
                storage += str;
            }
            return storage;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(StringRepeat(Console.ReadLine(), int.Parse(Console.ReadLine())));
        }
    }
}
