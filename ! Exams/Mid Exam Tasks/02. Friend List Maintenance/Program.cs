using System;
using System.Linq;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int blcnt = 0;
            int lstcnt = 0;

            while (true)
            {
                var cmd = Console.ReadLine().Split().ToList();
                if (cmd[0] == "Report")
                {
                    break;
                }

                else if (cmd[0] == "Blacklist")
                {
                    string name = cmd[1];

                    if (!friends.Contains(name))
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was blacklisted.");
                        friends[friends.IndexOf(name)] = "Blacklisted";
                        blcnt++;
                    }
                }

                else if (cmd[0] == "Error")
                {
                    int index = int.Parse(cmd[1]);

                    if (index >= 0 && index <= friends.Count - 1)
                    {
                        if (friends[index] == "Blacklisted" || friends[index] == "Lost")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{friends[index]} was lost due to an error.");
                            friends[index] = "Lost";
                            lstcnt++;
                        }
                    }
                }

                else if (cmd[0] == "Change")
                {
                    int index = int.Parse(cmd[1]);
                    string newName = cmd[2];

                    if (index >= 0 && index <= friends.Count - 1)
                    {
                        Console.WriteLine($"{friends[index]} changed his username to {newName}.");
                        friends[index] = newName;
                    }
                }
            }

            Console.WriteLine($"Blacklisted names: {blcnt}");
            Console.WriteLine($"Lost names: {lstcnt}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
