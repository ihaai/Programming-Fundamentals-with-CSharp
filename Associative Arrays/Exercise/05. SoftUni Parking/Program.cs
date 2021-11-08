using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var action = input[0];
                var name = input[1];

                if (action == "register" && !parkingLot.ContainsKey(name))
                {
                    var licenseNumber = input[2];
                    parkingLot.Add(name, licenseNumber);
                    Console.WriteLine($"{name} registered {licenseNumber} successfully");
                }
                else if (action == "register" && parkingLot.ContainsKey(name))
                {
                    var licenseNumber = input[2];
                    Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                }

                else if (action == "unregister" && parkingLot.ContainsKey(name))
                {
                    Console.WriteLine($"{name} unregistered successfully");
                    parkingLot.Remove(name);
                }
                else if (action == "unregister" && !parkingLot.ContainsKey(name))
                {
                    Console.WriteLine($"ERROR: user {name} not found");
                }
            }

            foreach (var dictElement in parkingLot)
            {
                Console.WriteLine($"{dictElement.Key} => {dictElement.Value}");
            }
        }
    }
}
