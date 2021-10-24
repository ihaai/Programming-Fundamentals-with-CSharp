using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialLoot = Console.ReadLine().Split('|').ToList();

            while (true)
            {
                var cmd = Console.ReadLine().Split().ToList();

                if (cmd[0] == "Yohoho!")
                {
                    break;
                }

                else if (cmd[0] == "Loot")
                {
                    for (int i = 1; i < cmd.Count; i++)
                    {
                        if (!initialLoot.Contains(cmd[i]))
                        {
                            initialLoot.Insert(0, cmd[i]);
                        }
                    }
                }

                else if (cmd[0] == "Drop")
                {
                    if (int.Parse(cmd[1]) > initialLoot.Count - 1 || int.Parse(cmd[1]) < 0)
                    {
                        continue;
                    }
                    else
                    {
                        initialLoot.Add(initialLoot[int.Parse(cmd[1])]);
                        initialLoot.RemoveAt(int.Parse(cmd[1]));
                    }
                }

                else if (cmd[0] == "Steal")
                {
                    int count = int.Parse(cmd[1]);
                    if (count > initialLoot.Count)
                    {
                        count = initialLoot.Count;
                    }

                    Console.WriteLine(string.Join(", ", initialLoot.GetRange(initialLoot.Count - count, count)));

                    initialLoot.RemoveRange(initialLoot.Count - count, count);
                }
            }

            if (initialLoot.Count < 1)
            {
                Console.WriteLine("Failed treasure hunt.");
                return;
            }
            else
            {
                var itemsLenghtSum = 0.00;
                initialLoot.ForEach(i => { itemsLenghtSum += i.Length; });
                var average = itemsLenghtSum / initialLoot.Count;

                Console.WriteLine($"Average treasure gain: {average:F2} pirate credits.");
            }
        }
    }
}
