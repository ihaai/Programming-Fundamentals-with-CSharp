using System;
using System.Linq;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();
            foreach (string word in forbiddenWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
