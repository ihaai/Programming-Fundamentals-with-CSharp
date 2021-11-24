using System;
using System.Linq;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDestinations = Console.ReadLine();
            string newStr = startDestinations;
            string[] command = Console.ReadLine().Split(':').ToArray();
            while (command[0] != "Travel")
            {
                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string newDestination = command[2];
                    if (index >= 0 && index <= startDestinations.Length)
                    {
                        newStr = newStr.Insert(index, newDestination);
                    }

                    Console.WriteLine(newStr);
                }

                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if ((startIndex >= 0 && startIndex <= newStr.Length - 1) && (endIndex >= 0 && endIndex <= newStr.Length - 1))
                        newStr = newStr.Remove(startIndex, endIndex - startIndex + 1);

                    Console.WriteLine(newStr);
                }

                else if (command[0] == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];
                    newStr = newStr.Replace(oldString, newString);

                    Console.WriteLine(newStr);
                }


                command = Console.ReadLine().Split(':').ToArray();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {newStr}");
        }
    }
}
