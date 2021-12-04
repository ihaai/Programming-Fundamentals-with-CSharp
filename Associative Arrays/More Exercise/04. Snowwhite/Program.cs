using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Snowwhite
{
    public class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }

        public Dwarf(string name, string color, int physics)
        {
            this.Name = name;
            this.Color = color;
            this.Physics = physics;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfCollection = new List<Dwarf>();

            string[] newDwarf = Console.ReadLine().Split(" <:> ").ToArray();
            while (newDwarf[0] != "Once upon a time")
            {
                string name = newDwarf[0];
                string color = newDwarf[1];
                int physics = int.Parse(newDwarf[2]);

                Dwarf checkDwarf = dwarfCollection.FirstOrDefault(x => x.Name == name && x.Color == color);

                if (checkDwarf == null)
                {
                    dwarfCollection.Add(new Dwarf(name, color, physics));
                }
                else
                {
                    checkDwarf.Physics = Math.Max(checkDwarf.Physics, physics);
                }

                newDwarf = Console.ReadLine().Split(" <:> ").ToArray();
            }

            Console.WriteLine(string.Join("\n", 
                dwarfCollection.OrderByDescending(x => x.Physics)
                .ThenByDescending(x => dwarfCollection.Where(y => y.Color == x.Color).Count())
                .Select(x => $"({x.Color}) {x.Name} <-> {x.Physics}")));
        }
    }
}
