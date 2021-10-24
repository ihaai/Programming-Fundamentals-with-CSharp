using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var groceryList = Console.ReadLine().Split('!').ToList();

            while (true)
            {
                var cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (cmd[0].Contains("Go"))
                {
                    break;
                }

                else if (cmd[0] == "Urgent")
                {
                    string item = cmd[1];

                    if (!groceryList.Contains(item))
                    {
                        groceryList.Insert(0, item);
                    }
                }

                else if (cmd[0] == "Unnecessary")
                {
                    string item = cmd[1];

                    if (groceryList.Contains(item))
                    {
                        groceryList.Remove(item);
                    }
                }

                else if (cmd[0] == "Correct")
                {
                    string oldItem = cmd[1];
                    string newItem = cmd[2];

                    if (groceryList.Contains(oldItem))
                    {
                        groceryList[groceryList.IndexOf(oldItem)] = newItem;
                    }
                }

                else if (cmd[0] == "Rearrange")
                {
                    string item = cmd[1];

                    if (groceryList.Contains(item))
                    {
                        groceryList.RemoveAt(groceryList.IndexOf(item));
                        groceryList.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", groceryList));
        } 
    }
}
