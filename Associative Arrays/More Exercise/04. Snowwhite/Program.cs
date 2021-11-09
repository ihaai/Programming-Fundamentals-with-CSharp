using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> DwarfInformation = new Dictionary<string, int>();

            var startInput = Console.ReadLine();
            while (startInput != "Once upon a time")
            {
                var input = startInput.Split(" <:> ").ToList();
                var nameID = input[0] + ":" + input[1];
                var physics = int.Parse(input[2]);

                if (!DwarfInformation.ContainsKey(nameID))
                {
                    DwarfInformation.Add(nameID, physics);
                }
                else
                {
                    DwarfInformation[nameID] = Math.Max(DwarfInformation[nameID], physics);
                }

                startInput = Console.ReadLine();
            }


            foreach (var Dwarf in DwarfInformation.OrderByDescending(x => x.Value).ThenByDescending(y => DwarfInformation.Where(x => x.Key.Split(":")[1] == y.Key.Split(":")[1]).Count()))
            {
                Console.WriteLine($"({Dwarf.Key.Split(":")[1]}) {Dwarf.Key.Split(":")[0]} <-> {Dwarf.Value}");
            }
        }
    }
}
