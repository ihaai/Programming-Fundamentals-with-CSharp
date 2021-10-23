using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var manipulate = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split().ToList();
                if (command[0] == "end")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Delete":
                        manipulate.RemoveAll(x => x == int.Parse(command[1]));
                        break;

                    case "Insert":
                        manipulate.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", manipulate));
        }
    }
}
