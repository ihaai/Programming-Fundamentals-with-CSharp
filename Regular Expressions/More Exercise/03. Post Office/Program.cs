using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex firstPattern = new Regex(@"(\$|\%|\#|\*|\&)(?<capitals>[A-Z]+)\1");

            List<string> cryptedAscii = Console.ReadLine().Split('|').ToList();
            string first = cryptedAscii[0];
            string second = cryptedAscii[1];
            string third = cryptedAscii[2];

            first = firstPattern.Match(first).Groups["capitals"].Value;

            for (int i = 0; i < first.Length; i++)
            {
                int asciiCode = (char)first[i];
                Regex secondPattern = new Regex($@"({asciiCode}):(?<lenght>[0-9][0-9])");
                int lenght = int.Parse(secondPattern.Match(second).Groups["lenght"].Value);

                Regex thirdPattern = new Regex($@"(?<!\S){first[i]}.{{{lenght}}}(?!\S)");
                string word = thirdPattern.Match(third).Value;

                Console.WriteLine(word);
            }
        }
    }
}
