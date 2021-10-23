using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            var drumsPrice = new List<int>();

            drumsPrice.AddRange(drumSet); // Synchronizing price elements with drum elements as requested in the problem.

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Hit it again, Gabsy!")
                {
                    break;
                }

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= int.Parse(command);
                    if (drumSet[i] <= 0)
                    {
                        if (budget - (drumsPrice[i] * 3) >= 0)
                        {
                            budget -= (drumsPrice[i] * 3);
                            drumSet[i] = drumsPrice[i];
                        }
                    }
                }

                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i] <= 0)
                    {
                        drumSet.Remove(drumSet[i]);
                        drumsPrice.Remove(drumsPrice[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {budget:F2}lv.");
        }
    }
}
