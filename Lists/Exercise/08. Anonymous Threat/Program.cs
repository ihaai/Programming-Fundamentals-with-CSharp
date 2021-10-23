using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "3:1")
                {
                    break;
                }

                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);
                var mergedString = string.Empty;

                if (endIndex > data.Count - 1 || endIndex < 0)
                {
                    endIndex = data.Count - 1;
                }

                if (startIndex < 0 || startIndex > data.Count)
                {
                    startIndex = 0;
                }

                if (command[0] == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        mergedString += data[i];
                    }
                    data.RemoveRange(startIndex, endIndex - startIndex + 1);
                    data.Insert(startIndex, mergedString);
                }
                else if (command[0] == "divide")
                {
                    var divList = new List<string>();
                    int dividePartisions = int.Parse(command[2]);
                    string wordToDivide = data[startIndex];
                    data.RemoveAt(startIndex);
                    int part = wordToDivide.Length / dividePartisions;
                    for (int i = 0; i < dividePartisions; i++)
                    {
                        if ( i == dividePartisions - 1)
                        {
                            divList.Add(wordToDivide.Substring(i * part));
                        }
                        else
                        {
                            divList.Add(wordToDivide.Substring(i * part, part));
                        }
                    }
                    data.InsertRange(startIndex, divList);
                }
            }
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
