using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escapeLoop = false;
            var manipulate = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (escapeLoop == false)
            {
                var command = Console.ReadLine().Split().ToList();

                switch (command[0])
                {
                    case "Add": manipulate.Add(int.Parse(command[1])); break;
                    case "Remove": manipulate.Remove(int.Parse(command[1])); break;
                    case "RemoveAt": manipulate.RemoveAt(int.Parse(command[1])); break;
                    case "Insert": manipulate.Insert(int.Parse(command[2]), int.Parse(command[1])); break;
                    case "end": escapeLoop = true; break;
                }
            }

            Console.WriteLine(string.Join(" ", manipulate));
        }
    }
}
