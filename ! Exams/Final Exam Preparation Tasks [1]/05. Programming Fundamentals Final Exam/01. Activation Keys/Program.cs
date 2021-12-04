using System;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string crypted = Console.ReadLine();
            string workingWith = crypted;

            string[] command = Console.ReadLine().Split(">>>").ToArray();
            while (command[0] != "Generate")
            {
                if (command[0] == "Contains")
                {
                    string substring = command[1];
                    if (workingWith.Contains(substring))
                    {
                        Console.WriteLine($"{workingWith} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if (command[0] == "Flip")
                {
                    int startingIndex = int.Parse(command[2]);
                    int endingIndex = int.Parse(command[3]);
                    string substring = workingWith.Substring(startingIndex, endingIndex - startingIndex);

                    if (command[1] == "Upper")
                    {
                        string substringUpper = substring.ToUpper();
                        workingWith = workingWith.Replace(substring, substringUpper);

                        Console.WriteLine(workingWith);
                    }

                    else if (command[1] == "Lower")
                    {
                        string substringLower = substring.ToLower();
                        workingWith = workingWith.Replace(substring, substringLower);

                        Console.WriteLine(workingWith);
                    }
                }

                if (command[0] == "Slice")
                {
                    int startingIndex = int.Parse(command[1]);
                    int endingIndex = int.Parse(command[2]);

                    workingWith = workingWith.Remove(startingIndex, endingIndex - startingIndex);
                    Console.WriteLine(workingWith);
                }

                command = Console.ReadLine().Split(">>>").ToArray();
            }

            Console.WriteLine($"Your activation key is: {workingWith}");
        }
    }
}
