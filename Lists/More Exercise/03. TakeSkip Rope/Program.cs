using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            char[] textChars = text.ToCharArray();

            var numberList = new List<int>();
            var textList = new List<string>();
            var takeList = new List<int>();
            var skipList = new List<int>();
            var storingString = string.Empty;

            for (int i = 0; i < textChars.Length; i++)
            {
                if (char.IsDigit(textChars[i]))
                {
                    numberList.Add(textChars[i] - '0');
                    continue;
                }

                textList.Add(textChars[i].ToString());
            }

            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numberList[i]);
                    continue;
                }

                skipList.Add(numberList[i]);
            }

            int startingSkippingIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                var temporaryStorage = textList.Skip(startingSkippingIndex).Take(takeList[i]).ToList();
                storingString += string.Concat(temporaryStorage);
                startingSkippingIndex += takeList[i] + skipList[i];
            }

            Console.WriteLine(storingString);
        }
    }
}
