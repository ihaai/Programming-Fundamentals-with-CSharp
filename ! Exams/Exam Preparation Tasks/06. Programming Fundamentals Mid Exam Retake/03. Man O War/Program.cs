using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            var warShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            var maxHealth = int.Parse(Console.ReadLine());
            var lowHealth = maxHealth * 0.2;

            while (true)
            {
                var cmd = Console.ReadLine().Split().ToList();

                if (cmd[0] == "Retire")
                {
                    break;
                }

                else if (cmd[0] == "Fire")
                {
                    int index = int.Parse(cmd[1]);
                    int damage = int.Parse(cmd[2]);

                    if (index >= warShip.Count || index < 0)
                    {
                        continue;
                    }
                    else
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }

                    }
                }
                else if (cmd[0] == "Defend")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    int damage = int.Parse(cmd[3]);

                    if (startIndex < 0 || startIndex >= endIndex || startIndex >= pirateShip.Count || endIndex < 0 || endIndex <= startIndex || endIndex >= pirateShip.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = startIndex; startIndex <= endIndex; startIndex++)
                        {
                            pirateShip[startIndex] -= damage;
                            if (pirateShip[startIndex] <= 0)
                            {
                                Console.WriteLine($"You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (cmd[0] == "Repair")
                {
                    int index = int.Parse(cmd[1]);
                    int health = int.Parse(cmd[2]);

                    if (index >= pirateShip.Count || index < 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (pirateShip[index] + health > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                        else
                        {
                            pirateShip[index] += health;
                        }
                    }
                }
                else if (cmd[0] == "Status")
                {
                    int counter = 0;
                    pirateShip.ForEach(p => { if (p < lowHealth) counter++; });
                    Console.WriteLine($"{counter} sections need repair.");
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
