using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Array_Manipulator
{
    class Program
    {
        // Using Lists instead of Arrays since they got more methods to work with therefore it makes it easier. Lists for the win!

        static void PrintIndex(int index)
        {
            if (index > -1)
                Console.WriteLine(index);
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void Main(string[] args)
        {
            var startingList = Console.ReadLine().Split().ToList();
            var commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "end")
            {
                if (commands[0] == "exchange")
                {
                    if (int.Parse(commands[1]) >= startingList.Count || int.Parse(commands[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        startingList = ExchangeList(startingList, int.Parse(commands[1]));
                    }
                }

                if (commands[0] == "min")
                {
                    FindMinimum(startingList, commands[1]);
                }
                else if (commands[0] == "max")
                {
                    FindMaximum(startingList, commands[1]);
                }

                else if (commands[0] == "first" || commands[0] == "last")
                {
                    if (int.Parse(commands[1]) > startingList.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (int.Parse(commands[1]) == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        FindNumbers(startingList, commands[0], int.Parse(commands[1]), commands[2]);
                    }
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", startingList)}]");
        }

        static List<string> ExchangeList(List<string> currentList, int splitAt)
        {
            var split = currentList.Take(splitAt);
            var split2 = currentList.Skip(splitAt);

            var exchangedList = new List<string>();
            foreach (var i in split2)
            {
                exchangedList.Add(i);
            }
            foreach (var i in split)
            {
                exchangedList.Add(i);
            }

            exchangedList.Insert(exchangedList.Count, exchangedList[0]);
            exchangedList.RemoveAt(0);

            return exchangedList;
        }

        static void FindMinimum(List<string> currentList, string numberType)
        {
            int divisionType = numberType == "odd" ? 1 : 0;
            int currentBigIndex = -1;
            int min = int.MaxValue;

            for (int i = 0; i < currentList.Count; i++)
            {
                if ((int.Parse(currentList[i]) <= min) && (int.Parse(currentList[i]) % 2 == divisionType))
                {
                    min = int.Parse(currentList[i]);
                    currentBigIndex = i;
                }
            }

            PrintIndex(currentBigIndex);
        }

        static void FindMaximum(List<string> currentList, string numberType)
        {
            int divisionType = numberType == "odd" ? 1 : 0;
            int currentBigIndex = -1;
            int max = int.MinValue;

            for (int i = 0; i < currentList.Count; i++)
            {
                if ((int.Parse(currentList[i]) >= max) && (int.Parse(currentList[i]) % 2 == divisionType))
                {
                    max = int.Parse(currentList[i]);
                    currentBigIndex = i;
                }
            }

            PrintIndex(currentBigIndex);
        }

        static void FindNumbers(List<string> currentList, string pos, int itemCount, string numberType)
        {
            var storage = new List<string>();
            int counter = 0;

            if (pos == "first")
            {
                if (numberType == "even")
                {
                    foreach (var element in currentList)
                    {
                        if (int.Parse(element) % 2 == 0)
                        {
                            counter++;
                            storage.Add(element);
                        }
                        if (counter == itemCount)
                        {
                            break;
                        }
                    }
                }
                else if (numberType == "odd")
                {
                    foreach (var element in currentList)
                    {
                        if (int.Parse(element) % 2 != 0)
                        {
                            counter++;
                            storage.Add(element);
                        }
                        if (counter == itemCount)
                        {
                            break;
                        }
                    }
                }
            }
            else if (pos == "last")
            {
                if (numberType == "even")
                {
                    for (int i = currentList.Count - 1; i >= 0; i--)
                    {
                        if (int.Parse(currentList[i]) % 2 == 0)
                        {
                            counter++;
                            storage.Add(currentList[i]);
                        }
                        if (counter == itemCount)
                        {
                            break;
                        }
                    }
                    storage.Reverse();
                }
                else if (numberType == "odd")
                {
                    for (int i = currentList.Count - 1; i >= 0; i--)
                    {
                        if (int.Parse(currentList[i]) % 2 != 0)
                        {
                            counter++;
                            storage.Add(currentList[i]);
                        }
                        if (counter == itemCount)
                        {
                            break;
                        }
                    }
                    storage.Reverse();
                }
            }

            Console.WriteLine($"[{string.Join(", ", storage)}]");
            storage.Clear();
        }
    }
}
