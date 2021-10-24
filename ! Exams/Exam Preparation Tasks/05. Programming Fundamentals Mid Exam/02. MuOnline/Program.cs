using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            var dungeonRooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            var totalBitcoins = new int();
            var roomsCount = new int();
            var currentHealth = 100;
            const int maxHealth = 100;

            for (int i = 0; i < dungeonRooms.Count; i++)
            {
                var action = dungeonRooms[i].Split().ToList();

                if (action[0] == "potion")
                {
                    var oldHealth = currentHealth;
                    var potionHealPoints = int.Parse(action[1]);
                    currentHealth += potionHealPoints; // Example: 70 = 70 + 10 => 80

                    if (currentHealth > maxHealth)
                        currentHealth = maxHealth;

                    var healedFor = currentHealth - oldHealth; // Example: 80 - 70 = 10

                    if (oldHealth == maxHealth)
                        healedFor = 0;

                    Console.WriteLine($"You healed for {healedFor} hp.");
                    Console.WriteLine($"Current health: {currentHealth} hp.");
                }

                else if (action[0] == "chest")
                {
                    var bitcoinAmount = int.Parse(action[1]);
                    Console.WriteLine($"You found {bitcoinAmount} bitcoins.");
                    totalBitcoins += bitcoinAmount;
                }

                else
                {
                    var monsterName = action[0];
                    var monsterAttack = int.Parse(action[1]);
                    currentHealth -= monsterAttack;

                    if (currentHealth <= 0)
                    {
                        roomsCount = i + 1;
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {roomsCount}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monsterName}.");
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {totalBitcoins}");
            Console.WriteLine($"Health: {currentHealth}");
        }
    }
}
