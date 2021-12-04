using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static long TresholdCalculator(string input)
        {
            long calculatedTreshold = 1;
            foreach (var chars in input)
            {
                if (Char.IsDigit(chars))
                    calculatedTreshold *= long.Parse(chars.ToString());
            }

            return calculatedTreshold;
        }

        static long CoolnessCalculator(string emoji)
        {
            long coolnessValue = new long();
            foreach (var chars in emoji)
            {
                if (Char.IsLetter(chars))
                    coolnessValue += chars;
            }

            return coolnessValue;
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            List<string> emojiCollection = new List<string>();
            Regex emojiPattern = new Regex(@"(:{2}|\*{2})(?<emojiName>[A-Z][a-z]{2,})\1");

            string input = Console.ReadLine();
            long coolTreshold = TresholdCalculator(input);
            int validCounter = 0;
            long coolness = new long();

            foreach (Match match in emojiPattern.Matches(input))
            {
                validCounter++;

                string currentEmoji = match.Groups["emojiName"].Value.ToString();
                coolness = CoolnessCalculator(currentEmoji);
                if (coolness >= coolTreshold)
                {
                    emojiCollection.Add(match.Value.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{validCounter} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", emojiCollection));

        }
    }
}
