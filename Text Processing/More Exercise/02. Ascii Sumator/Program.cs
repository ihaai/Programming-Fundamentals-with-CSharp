using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSum = new int();
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            string findInString = Console.ReadLine();

            for (int i = 0; i < findInString.Length; i++)
            {
                if (findInString[i] > startChar && findInString[i] < endChar)
                {
                    totalSum += findInString[i];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
