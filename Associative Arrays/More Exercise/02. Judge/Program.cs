using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> ContestInformation = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> UserInformation = new Dictionary<string, int>();
            var startInput = Console.ReadLine();
            while (startInput != "no more time")
            {
                var input = startInput.Split(" -> ").ToList();
                var username = input[0];
                var contest = input[1];
                var points = int.Parse(input[2]);

                if (!ContestInformation.ContainsKey(contest))
                {
                    ContestInformation.Add(contest, new Dictionary<string, int> { { username, points } });
                }
                else
                {
                    if (!ContestInformation[contest].ContainsKey(username))
                    {
                        ContestInformation[contest][username] = points;
                    }
                    else
                    {
                        if (ContestInformation[contest][username] < points)
                        {
                            ContestInformation[contest][username] = points;
                        }
                    }
                }

                startInput = Console.ReadLine();
            }

            int index = 1;
            foreach(var Contest in ContestInformation)
            {
                Console.WriteLine($"{Contest.Key}: {Contest.Value.Count()} participants");
                foreach(var Participant in Contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{index}. {Participant.Key} <::> {Participant.Value}");
                    index += 1;
                }
                index = 1;
            }

            Console.WriteLine("Individual standings:");
            foreach(var Contest in ContestInformation)
            {
                foreach(var Participant in Contest.Value)
                {
                    if (!UserInformation.ContainsKey(Participant.Key))
                    {
                        UserInformation.Add(Participant.Key, Participant.Value);
                    }
                    else
                    {
                        UserInformation[Participant.Key] = UserInformation[Participant.Key] + Participant.Value;
                    }
                }
            }

            int sIndex = 1;
            foreach(var Participant in UserInformation.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{sIndex}. {Participant.Key} -> {Participant.Value}");
                sIndex += 1;
            }
        }
    }
}
