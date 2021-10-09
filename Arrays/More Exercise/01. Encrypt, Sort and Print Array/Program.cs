using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLinesToRead = int.Parse(Console.ReadLine());
            int[] wordsToEncrypt = new int[numberOfLinesToRead];
            char[] vowels = { 'a', 'A', 'o', 'O', 'e', 'E', 'i', 'I', 'u', 'U' };

            for (int i = 0; i < numberOfLinesToRead; i++)
            {
                string stringInput = Console.ReadLine();
                char[] inputToChar = stringInput.ToCharArray();
                int sums = 0;

                for (int a = 0; a < inputToChar.Length; a++)
                {
                    if (vowels.Contains(inputToChar[a]))
                    {
                        sums += inputToChar[a] * stringInput.Length;
                    }
                    else
                    {
                        sums += inputToChar[a] / stringInput.Length;
                    }
                }
                wordsToEncrypt[i] = sums;
            }
            Array.Sort(wordsToEncrypt);
            foreach (var element in wordsToEncrypt)
            {
                Console.WriteLine(element);
            }
        }
    }
}
