using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = Console.ReadLine();
            string concat = Console.ReadLine();
            Console.WriteLine(string.Concat(nameFirst, concat, nameSecond));
        }
    }
}
