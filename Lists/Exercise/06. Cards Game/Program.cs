using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var hand1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var hand2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                if (hand1[0] > hand2[0])
                {
                    hand1.Add(hand1[0]);
                    hand1.Add(hand2[0]);
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
                else if (hand1[0] < hand2[0])
                {
                    hand2.Add(hand2[0]);
                    hand2.Add(hand1[0]);
                    hand2.RemoveAt(0);
                    hand1.RemoveAt(0);
                }
                else if (hand1[0] == hand2[0])
                {
                    hand1.Remove(hand1[0]);
                    hand2.Remove(hand2[0]);
                }

                if (hand2.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {hand1.Sum()}");
                    return;
                }
                else if (hand1.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {hand2.Sum()}");
                    return;
                }
            }
        }
    }
}
