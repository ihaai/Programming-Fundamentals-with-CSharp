using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._P_rates
{
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

        public City() { }

        public City(string name, int population, int gold)
        {
            this.Name = name;
            this.Population = population;
            this.Gold = gold;
        }

        public City Plunder(City city, List<City> collection, string name, int population, int gold)
        {
            city.Population -= population;
            city.Gold -= gold;
            Console.WriteLine($"{city.Name} plundered! {gold} gold stolen, {population} citizens killed.");
            if (city.Population <= 0 || city.Gold <= 0)
            {
                Console.WriteLine($"{city.Name} has been wiped off the map!");
                collection.Remove(city);
            }

            return city;
        }

        public City Prosper(City city, string name, int gold)
        {
            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
            else
            {
                city.Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {city.Name} now has {city.Gold} gold.");
            }

            return city;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            City classInstance = new City();
            List<City> cityCollection = new List<City>();

            string[] newCity = Console.ReadLine().Split("||").ToArray();
            while (newCity[0] != "Sail")
            {
                string name = newCity[0];
                int population = int.Parse(newCity[1]);
                int gold = int.Parse(newCity[2]);

                City checkCity = cityCollection.FirstOrDefault(x => x.Name == name);
                if (checkCity == null)
                {
                    cityCollection.Add(new City(name, population, gold));
                }
                else
                {
                    checkCity.Population += population;
                    checkCity.Gold += gold;
                }

                newCity = Console.ReadLine().Split("||").ToArray();
            }

            string[] command = Console.ReadLine().Split("=>").ToArray();
            while (command[0] != "End")
            {
                if (command[0] == "Plunder")
                {
                    string name = command[1];
                    int population = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);

                    City city = cityCollection.FirstOrDefault(x => x.Name == name);
                    city = classInstance.Plunder(city, cityCollection, name, population, gold);
                }

                if (command[0] == "Prosper")
                {
                    string name = command[1];
                    int gold = int.Parse(command[2]);

                    City city = cityCollection.FirstOrDefault(x => x.Name == name);
                    city = classInstance.Prosper(city, name, gold);
                }

                command = Console.ReadLine().Split("=>").ToArray();
            }

            if (cityCollection.Count != 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityCollection.Count} wealthy settlements to go to:");
                Console.WriteLine(string.Join("\n", cityCollection.OrderByDescending(x => x.Gold).ThenBy(x => x.Name).Select(x => $"{x.Name} -> Population: {x.Population} citizens, Gold: {x.Gold} kg")));
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
