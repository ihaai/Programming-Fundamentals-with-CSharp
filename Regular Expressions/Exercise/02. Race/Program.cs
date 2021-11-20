using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            string namePattern = $"[A-Za-z]+";
            string kilometerPattern = @"\d+";
            List<string> competitors = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race") break;

                var currentSum = new int();
                var currentNameCollection = Regex.Matches(input, namePattern);
                var currentKilometers = Regex.Matches(input, kilometerPattern);
                var name = string.Join("", currentNameCollection);
                var kilometers = string.Join("", currentKilometers);

                for (int i = 0; i < kilometers.Length; i++)
                {
                    currentSum += int.Parse(kilometers[i].ToString());
                }

                if (competitors.Contains(name))
                {
                    if (!participants.ContainsKey(name))
                    {
                        participants.Add(name, 0);
                    }
                    participants[name] += currentSum;
                }
            }

            int currentWinnerCounter = new int();
            var topWinners = participants.OrderByDescending(k => k.Value).ToDictionary(k => k.Key, v => v.Value);
            foreach (var winner in topWinners)
            {
                if (currentWinnerCounter < 3)
                {
                    if (currentWinnerCounter == 0) Console.WriteLine($"1st place: {winner.Key}");
                    if (currentWinnerCounter == 1) Console.WriteLine($"2nd place: {winner.Key}");
                    if (currentWinnerCounter == 2) Console.WriteLine($"3rd place: {winner.Key}");
                    currentWinnerCounter++;
                }
            }
        }
    }
}
