using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombNumber = bomb[0];
            var bombPower = bomb[1];

            /*
             Bomb power is basically a range. If our power is 2 it'll bomb all numbers 2 indexes further our number.
             If bombPower = 2 where "b" is to BOMB and X our NUMBER TO REMOVE==> [n|n|b|b|X|b|b|n|n] ==> we're left with [n|n|n|n]
                                                                                     \_________/
            */

            while (numbers.Contains(bombNumber))
            {
                var indexOfBombNumber = numbers.IndexOf(bombNumber);
                var leftRange = bombPower;
                var rightRange = bombPower;

                if (indexOfBombNumber - leftRange <= 0)
                {
                    leftRange = indexOfBombNumber;
                }

                if (indexOfBombNumber + rightRange >= numbers.Count)
                {
                    rightRange = numbers.Count - indexOfBombNumber - 1;
                }

                int index = indexOfBombNumber - leftRange;
                int count = leftRange + rightRange + 1;
                numbers.RemoveRange(index, count);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
