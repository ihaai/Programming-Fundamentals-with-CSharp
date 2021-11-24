using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"([=\/])(?<dest>[A-Z][A-Za-z]{2,9999999})\1");
            List<string> destinations = new List<string>();
            int sum = new int();

            string input = Console.ReadLine();
            foreach (Match match in pattern.Matches(input))
            {
                sum += match.Groups["dest"].Value.Length;
                destinations.Add(match.Groups["dest"].Value);
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
