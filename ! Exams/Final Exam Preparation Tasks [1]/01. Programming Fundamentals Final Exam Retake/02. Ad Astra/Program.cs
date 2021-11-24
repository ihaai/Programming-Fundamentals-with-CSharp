using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Regex pattern = new Regex(@"([|#])(?<itemname>([A-Za-z]+|[A-Za-z]+\s[A-Za-z]+))\1(?<expiry>[0-9][0-9]\/[0-9][0-9]\/[0-9][0-9])\1(?<calories>\d+)\1");
            int nutritionSum = new int();
            string input = Console.ReadLine();
            foreach (Match match in pattern.Matches(input))
            {
                string item = match.Groups["itemname"].Value;
                string expiry = match.Groups["expiry"].Value;
                string nutrition = match.Groups["calories"].Value;

                sb.AppendLine($"Item: {item}, Best before: {expiry}, Nutrition: {nutrition}");

                nutritionSum += int.Parse(nutrition);
            }

            Console.WriteLine($"You have food to last you for: {(int)nutritionSum/2000} days!");
            Console.WriteLine(sb.ToString());
        }
    }
}
