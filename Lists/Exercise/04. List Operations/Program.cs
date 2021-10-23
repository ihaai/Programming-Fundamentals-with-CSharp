using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var manipulate = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split().ToList();

                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Add": manipulate.Add(int.Parse(command[1])); break;
                    case "Insert":
                        if (int.Parse(command[2]) <= manipulate.Count-1 && int.Parse(command[2]) >= 0)
                            manipulate.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        else
                            Console.WriteLine("Invalid index");
                        break;

                    case "Remove":

                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= manipulate.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            manipulate.RemoveAt(int.Parse(command[1]));
                        }
                        break;

                    case "Shift":
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                manipulate.Add(manipulate[0]);
                                manipulate.Remove(manipulate[0]);
                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                manipulate.Insert(0, manipulate[manipulate.Count - 1]);
                                manipulate.RemoveAt(manipulate.Count - 1);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", manipulate));
        }
    }
}
