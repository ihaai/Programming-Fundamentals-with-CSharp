using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    var cmd = input.Split(" | ").ToList();
                    var forceSide = cmd[0];
                    var forceUser = cmd[1];

                    if (!sides.ContainsKey(forceSide))
                    {
                        sides.Add(forceSide, new List<string>());
                    }
                    if (!sides[forceSide].Contains(forceUser) && !sides.Values.Any(x => x.Contains(forceUser)))
                    {
                        sides[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    var cmd = input.Split(" -> ").ToList();
                    var forceSide = cmd[1];
                    var forceUser = cmd[0];

                    if (!sides.Values.Any(x => x.Contains(forceUser)))
                    {
                        if (!sides.ContainsKey(forceSide))
                        {
                            sides.Add(forceSide, new List<string>());
                        }
                        sides[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        foreach(var sd in sides.Where(x => x.Value.Contains(forceUser)))
                        {
                            sd.Value.Remove(forceUser);
                        }

                        if (!sides.ContainsKey(forceSide))
                        {
                            sides.Add(forceSide, new List<string>());
                        }
                        sides[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var side in sides.OrderByDescending(key => key.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, u => u.Value))
            {
                side.Value.Sort();
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(string.Join("\n! ", side.Value));
                }
            }
        }
    }
}
