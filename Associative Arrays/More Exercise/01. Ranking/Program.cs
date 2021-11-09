using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, double>> Submissions = new SortedDictionary<string, Dictionary<string, double>>(); // Nested Dictionary :(
            Dictionary<string, double> MaximumUserPoints = new Dictionary<string, double>();

            var contestPasswords = Console.ReadLine();
            while (contestPasswords != "end of contests")
            {
                var input = contestPasswords.Split(":").ToList();
                var contest = input[0];
                var password = input[1];
                if (!Contests.ContainsKey(contest))
                {
                    Contests.Add(contest, password);
                }

                contestPasswords = Console.ReadLine();
            }

            var studentSubmissions = Console.ReadLine();
            while (studentSubmissions != "end of submissions")
            {
                var input = studentSubmissions.Split("=>").ToList();
                var contest = input[0];
                var password = input[1];
                var username = input[2];
                var points = double.Parse(input[3]);

                if (!Contests.ContainsKey(contest) || Contests[contest] != password)
                {
                    studentSubmissions = Console.ReadLine();
                    continue;
                }

                if (!Submissions.ContainsKey(username))
                {
                    Submissions.Add(username, new Dictionary<string, double>() { { contest, points } });
                }

                if (!Submissions[username].ContainsKey(contest))
                {
                    Submissions[username].Add(contest, points);
                }

                if (Submissions[username][contest] < points)
                {
                    Submissions[username][contest] = points;
                }

                studentSubmissions = Console.ReadLine();
            }

            foreach(var Student in Submissions)
            {
                MaximumUserPoints.Add(Student.Key, Student.Value.Values.Sum());
            }

            var bestStudent = MaximumUserPoints.Keys.Max();
            var bestPoints = MaximumUserPoints.Values.Max();

            foreach (var kvp in MaximumUserPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach(var Student in Submissions)
            {
                Console.WriteLine(Student.Key);
                Console.WriteLine(string.Join("\n", Student.Value.OrderByDescending(x => x.Value).Select(x => $"#  {x.Key} -> {x.Value}")));
            }
        }
    }
}