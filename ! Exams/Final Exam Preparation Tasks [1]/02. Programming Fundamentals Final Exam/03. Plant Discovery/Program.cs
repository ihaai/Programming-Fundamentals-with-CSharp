using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Plant_Discovery
{
    public class Plants
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public double Average { get; set; }

        public Plants(string p, int r, double a)
        {
            this.Name = p;
            this.Rarity = r;
            this.Average = a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Plants> plantss = new List<Plants>();
            Dictionary<string, List<int>> plantInformation = new Dictionary<string, List<int>>();
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] newPlant = Console.ReadLine().Split("<->").ToArray();
                string plantName = newPlant[0];
                int rarity = int.Parse(newPlant[1]);

                if (!plantInformation.ContainsKey(plantName))
                    plantInformation.Add(plantName, new List<int>());

                plantInformation[plantName].Add(rarity);
            }
            GC.Collect();

            string[] command = Console.ReadLine().Split(" - ").ToArray();
            while (command[0] != "Exhibition")
            {
                if (command[0].Contains("Rate: "))
                {
                    command[0] = command[0].Remove(0, 6);
                    string plantName = command[0];
                    int rating = int.Parse(command[1]);

                    if (!plantInformation.ContainsKey(plantName))
                        Console.WriteLine("error");
                    else
                        plantInformation[plantName].Add(rating);
                }

                else if (command[0].Contains("Update: "))
                {
                    command[0] = command[0].Remove(0, 8);
                    string plantName = command[0];
                    int rarity = int.Parse(command[1]);

                    if (!plantInformation.ContainsKey(plantName))
                        Console.WriteLine("error");
                    else
                        plantInformation[plantName][0] = rarity;
                }

                else if (command[0].Contains("Reset: "))
                {
                    command[0] = command[0].Remove(0, 7);
                    string plantName = command[0];
                    if (!plantInformation.ContainsKey(plantName))
                        Console.WriteLine("error");
                    else
                    {
                        int rarityBuffer = plantInformation[plantName][0];
                        plantInformation[plantName].Clear();
                        plantInformation[plantName].Add(rarityBuffer);
                    }
                }

                command = Console.ReadLine().Split(" - ").ToArray();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (KeyValuePair<string, List<int>> plants in plantInformation)
            {
                if (plants.Value.Sum() - plants.Value[0] > 0)
                {
                    double divideBy = plants.Value.Count - 1;
                    plantss.Add(new Plants(plants.Key, plants.Value[0], (plants.Value.Sum() - plants.Value[0]) / divideBy));
                }
                else
                    plantss.Add(new Plants(plants.Key, plants.Value[0], 0));
            }

            foreach (Plants Plant in plantss.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.Average))
            {
                Console.WriteLine($"- {Plant.Name}; Rarity: {Plant.Rarity}; Rating: {Plant.Average:F2}");
            }
        }
    }
}