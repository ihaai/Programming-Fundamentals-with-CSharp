using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerStorage = new Dictionary<string, int>();

            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop")
                    break;

                var quantity = int.Parse(Console.ReadLine());

                if (!minerStorage.ContainsKey(resource))
                {
                    minerStorage.Add(resource, quantity);
                    continue;
                }

                minerStorage[resource] +=quantity;
            }

            foreach(var ms in minerStorage)
            {
                Console.WriteLine($"{ms.Key} -> {ms.Value}");
            }
        }
    }
}
