using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagonsCount = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                var command = Console.ReadLine().Split().ToList();

                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "Add")
                {
                    wagonsCount.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagonsCount.Count; i++)
                    {
                        if (wagonsCount[i] + int.Parse(command[0]) <= wagonCapacity)
                        {
                            wagonsCount[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagonsCount));
        }
    }
}
