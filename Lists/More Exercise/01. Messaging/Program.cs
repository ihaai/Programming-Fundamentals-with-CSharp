using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Messaging
{
    class Program
    {
        static int DigitSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += (number % 10);
                number /= 10;
            }
            return sum;
        }

        static int RecalculateIndex(int index, string text)
        {
            int indexCount = 0;

            for (int i = 0; i < index; i++)
            {
                indexCount++;

                if (indexCount > text.Length)
                {
                    indexCount = 0;
                }
            }

            return indexCount;
        }

        static char GetCharacter(int index, string text)
        {
            int indexCount = 0;

            for (int i = 0; i < index; i++)
            {
                indexCount++;

                if (indexCount > text.Length)
                {
                    indexCount = 0;
                }
            }

            char currentCharFromText = text[indexCount];
            return currentCharFromText;
        }


        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var text = Console.ReadLine();
            var index = new int();

            for (int i = 0; i < numbers.Count; i++)
            {
                index = DigitSum(numbers[i]);

                char currentChar = GetCharacter(index, text);
                Console.Write(currentChar);

                int realIndex = RecalculateIndex(index, text);
                string returnNewText = text.Remove(realIndex, 1);
                text = returnNewText;
            }
        }
    }
}
