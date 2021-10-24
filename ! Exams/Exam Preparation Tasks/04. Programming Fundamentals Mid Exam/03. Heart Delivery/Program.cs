using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             The neighborhoods size will be in the range [1…20]
             Each house will need an even number of hearts in the range [2 … 10]
             Each jump length will be an integer in the range [1 … 20]

             */

            var activeValentinesDay = new List<int>();

            var hood = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split().ToList();
            var currentCupidPosition = 0;

            while (command[0] != "Love!")
            {
                var jumpVal = int.Parse(command[1]);
                currentCupidPosition += jumpVal;

                if (currentCupidPosition > hood.Count - 1 || currentCupidPosition < 0)
                    currentCupidPosition = 0;


                if (hood[currentCupidPosition] == 0)
                {
                    Console.WriteLine($"Place {currentCupidPosition} already had Valentine's day.");
                }
                else
                {
                    hood[currentCupidPosition] -= 2;
                    if (hood[currentCupidPosition] == 0)
                        Console.WriteLine($"Place {currentCupidPosition} has Valentine's day.");
                }

                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine($"Cupid's last position was {currentCupidPosition}.");
            if (hood.Count(x => x != 0) > 0)
                Console.WriteLine($"Cupid has failed {hood.Count(x => x > 0)} places.");
            else
                Console.WriteLine($"Mission was successful.");
        }
    }
}
