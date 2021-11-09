using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Dragon_Army
{
    class Program
    {
        static void AddDragon(Dictionary<string, SortedDictionary<string, int[]>> dragonDict, string type, string name, int dmg, int hlth, int armr)
        {
            if (!dragonDict.ContainsKey(type))
            {
                dragonDict.Add(type, new SortedDictionary<string, int[]>());
            }

            if (!dragonDict[type].ContainsKey(name))
            {
                dragonDict[type][name] = new int[3];
            }
            dragonDict[type][name][0] = dmg;
            dragonDict[type][name][1] = hlth;
            dragonDict[type][name][2] = armr;
        }

        static void CheckValues(string[] input, ref int dmg, ref int hlth, ref int armr)
        {
            if (input[2] != "null") dmg = int.Parse(input[2]);
            if (input[3] != "null") hlth = int.Parse(input[3]);
            if (input[4] != "null") armr = int.Parse(input[4]);
        }

        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int[]>> DragonStats = new Dictionary<string, SortedDictionary<string, int[]>>();
            var numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                var dragon = Console.ReadLine().Split().ToArray();
                var type = dragon[0];
                var name = dragon[1];
                var damage = 45;
                var health = 250;
                var armor = 10;

                CheckValues(dragon, ref damage, ref health, ref armor);
                AddDragon(DragonStats, type, name, damage, health, armor);
            }

            foreach(var DragonType in DragonStats)
            {
                Console.WriteLine($"{DragonType.Key}::({DragonType.Value.Select(x => x.Value[0]).Average():F2}/{DragonType.Value.Select(x => x.Value[1]).Average():F2}/{DragonType.Value.Select(x => x.Value[2]).Average():F2})");
                foreach(var Dragons in DragonType.Value)
                {
                    Console.WriteLine($"-{Dragons.Key} -> damage: {Dragons.Value[0]}, health: {Dragons.Value[1]}, armor: {Dragons.Value[2]}");
                }
            }
        }
    }
}
