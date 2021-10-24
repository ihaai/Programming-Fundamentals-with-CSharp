using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                var action = Console.ReadLine().Split(" - ").ToList();
                if (action[0] == "Craft!")
                {
                    break;
                }

                else if (action[0] == "Collect")
                {
                    string item = action[1];

                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }

                else if (action[0] == "Drop")
                {
                    string item = action[1];

                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }

                else if (action[0] == "Combine Items")
                {
                    string[] itemsToCombine = action[1].Split(":");
                    string oldItem = itemsToCombine[0];
                    string newItem = itemsToCombine[1];

                    if (inventory.Contains(oldItem))
                    {
                        inventory.Insert(inventory.IndexOf(oldItem) + 1, newItem);
                    }
                }

                else if (action[0] == "Renew")
                {
                    string item = action[1];

                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
