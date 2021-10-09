using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void ReturnVowels(string text)
        {
            int count = new int();
            char[] vowels = { 'a', 'A', 'e', 'E', 'o', 'O', 'u', 'U', 'i', 'I' };
            char[] textToChar = text.ToCharArray();
            foreach(var element in textToChar)
            {
                if (vowels.Contains(element))
                    count++;
            }
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            ReturnVowels(text);
        }
    }
}
