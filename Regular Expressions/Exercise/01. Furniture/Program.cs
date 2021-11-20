using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            decimal total = new decimal();
            string input = Console.ReadLine();
            while (input != "Purchase")
            {
                foreach (Match match in Regex.Matches(input, @">>(?<item>[A-Za-z ]+)<<(?<price>(\d+|\d+\.\d+))!(?<quantity>\d+)"))
                {
                    furniture.Add(match.Groups["item"].Value);
                    total += decimal.Parse(match.Groups["price"].Value) * decimal.Parse(match.Groups["quantity"].Value);
                }
                input = Console.ReadLine();
            }

            if (total > 0)
            {
                Console.WriteLine("Bought furniture:");
                Console.WriteLine(String.Join("\n", furniture));
                Console.WriteLine($"Total money spend: {total:F2}");
            }
        }
    }
}
