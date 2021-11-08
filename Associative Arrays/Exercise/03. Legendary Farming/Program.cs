using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            legendaryItems.Add("shards", 0);
            legendaryItems.Add("fragments", 0);
            legendaryItems.Add("motes", 0);

            //Global variables:
            var quantity = new int();
            var item = string.Empty;
            bool escapeLoopFlag = false;

            while (escapeLoopFlag == false)
            {
                var cmd = Console.ReadLine().Split().ToList();
                for (int i = 0; i < cmd.Count; i++)
                {
                    quantity = int.Parse(cmd[i]);
                    item = cmd[i + 1].ToLower();
                    if (!junkItems.ContainsKey(item)) junkItems.Add(item, 0);

                    if (item == "shards") legendaryItems[item] += quantity;
                    if (item == "fragments") legendaryItems[item] += quantity;
                    if (item == "motes") legendaryItems[item] += quantity;
                    else junkItems[item] += quantity;

                    if (legendaryItems["shards"] >= 250)
                    {
                        Console.WriteLine($"Shadowmourne obtained!");
                        escapeLoopFlag = !escapeLoopFlag;
                        break;
                    }
                    else if (legendaryItems["fragments"] >= 250)
                    {
                        Console.WriteLine($"Valanyr obtained!");
                        escapeLoopFlag = !escapeLoopFlag;
                        break;
                    }
                    else if (legendaryItems["motes"] >= 250)
                    {
                        Console.WriteLine($"Dragonwrath obtained!");
                        escapeLoopFlag = !escapeLoopFlag;
                        break;
                    }

                    i++;
                }
            }

            if (legendaryItems["shards"] >= 250)
                legendaryItems["shards"] -= 250;
            else if (legendaryItems["fragments"] >= 250)
                legendaryItems["fragments"] -= 250;
            else if (legendaryItems["motes"] >= 250)
                legendaryItems["motes"] -= 250;

            foreach (var leftOversLen in legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{leftOversLen.Key}: {leftOversLen.Value}");
            }

            foreach (var leftOversJunk in junkItems.OrderBy(x => x.Key))
            {
                if (leftOversJunk.Key == "shards" || leftOversJunk.Key == "fragments" || leftOversJunk.Key == "motes")
                {
                    junkItems.Remove(leftOversJunk.Key);
                }
                else
                {
                    Console.WriteLine($"{leftOversJunk.Key}: {leftOversJunk.Value}");
                }
            }
        }
    }
}
