using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Get the position in the alphabet by getting the ASCII value and substracting it by the first letter in the ASCII - 1
            107 - (97-1) = 107 - 96 => 11 => 'k' is at position 11 in the alphabet
            */

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0.0;

            foreach (var i in input)
            {
                char firstL = i[0];
                char lastL = i[^1];
                string between = i[1..^1];
                double numberString = double.Parse(between);

                if (char.IsUpper(firstL))
                {
                    int letterPos = (char)firstL - 64; // 65 - 64 = 1
                    numberString /= letterPos;
                }
                else if (char.IsLower(firstL))
                {
                    int letterPos = (char)firstL - 96; // 97 - 96 = 1
                    numberString *= letterPos;
                }

                if (char.IsUpper(lastL))
                {
                    int letterPos = (char)lastL - 64; // 65 - 64 = 1
                    numberString -= letterPos;
                }
                else if (char.IsLower(lastL))
                {
                    int letterPos = (char)lastL - 96; // 97 - 96 = 1
                    numberString += letterPos;
                }
                totalSum += numberString;
            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
