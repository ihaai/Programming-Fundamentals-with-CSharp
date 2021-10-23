using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var racers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var finishIndex = racers.Count / 2;
            var rightPartRacers = new List<int>();
            var leftPartRacers = new List<int>();
            var leftPartTime = new double();
            var rightPartTime = new double();

            // Adding left players
            for (int i = 0; i < finishIndex; i++)
            {
                leftPartRacers.Add(racers[i]);
            }

            // Adding right players
            for (int i = racers.Count - 1; i > finishIndex; i--)
            {
                rightPartRacers.Add(racers[i]);
            }

            foreach (var left in leftPartRacers)
            {
                if (left == 0)
                {
                    leftPartTime *= 0.8;
                    continue;
                }

                leftPartTime += left;
            }

            foreach (var right in rightPartRacers)
            {
                if (right == 0)
                {
                    rightPartTime *= 0.8;
                    continue;
                }

                rightPartTime += right;
            }

            if (leftPartTime < rightPartTime)
            {
                if (leftPartTime % 1 > 0)
                {
                    Console.WriteLine($"The winner is left with total time: {leftPartTime:F1}");
                }
                else
                {
                    Console.WriteLine($"The winner is left with total time: {leftPartTime}");
                }
            }
            else if (leftPartTime > rightPartTime)
            {
                if (rightPartTime % 1 > 0)
                {
                    Console.WriteLine($"The winner is right with total time: {rightPartTime:F1}");
                }
                else
                {
                    Console.WriteLine($"The winner is right with total time: {rightPartTime}");
                }
            }
        }
    }
}
