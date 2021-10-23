using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfArrays = Console.ReadLine().Split('|').ToList();

            for (int i = listOfArrays.Count - 1; i >= 0; i--)
            {
                string[] arrays = listOfArrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int k = 0; k <= arrays.Length - 1; k++)
                {
                    Console.Write(arrays[k] + " ");
                }
            }
        }
    }
}
