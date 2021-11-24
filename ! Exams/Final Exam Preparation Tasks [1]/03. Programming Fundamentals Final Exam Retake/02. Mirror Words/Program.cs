using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static string Reverse(string str) => new string(str.ToCharArray().Reverse().ToArray());

        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"([@#])(?<normal>[A-Za-z]{3,})\1\1(?<mirrored>[A-Za-z]{3,})\1");
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();
            int validCounter = new int();

            foreach (Match match in pattern.Matches(input))
            {
                validCounter++;

                string normalWord = match.Groups["normal"].Value;
                string mirroredWord = match.Groups["mirrored"].Value;
                string buffer = normalWord;

                buffer = Reverse(buffer);

                if (buffer == mirroredWord)
                {
                    sb.Append($"{normalWord} <=> {mirroredWord}, ");
                }
            }

            if (validCounter > 0)
            {
                Console.WriteLine($"{validCounter} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
                

            if (sb.Length > 0)
            {
                Console.WriteLine("The mirror words are:");
                sb.Remove(sb.Length - 2, 2);
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
