using System;
using System.Linq;

namespace _01._Password_Reset
{
    class Program
    {
        static string OddTaker(string str)
        {
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                    newStr += str[i];
            }
            return newStr;
        }

        static void Main(string[] args)
        {
            string crypted = Console.ReadLine();
            string workingWith = crypted;
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "Done")
            {
                if (command[0] == "TakeOdd")
                {
                    workingWith = OddTaker(workingWith);
                    Console.WriteLine(workingWith);
                }
                if (command[0] == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);

                    string subString = workingWith.Substring(index, lenght);
                    workingWith = workingWith.Remove(workingWith.IndexOf(subString), subString.Length);
                    Console.WriteLine(workingWith);
                }
                if (command[0] == "Substitute")
                {
                    string subString = command[1];
                    string substitude = command[2];

                    if (workingWith.Contains(subString))
                    {
                        workingWith = workingWith.Replace(subString, substitude);
                        Console.WriteLine(workingWith);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Your password is: {workingWith}");
        }
    }
}
