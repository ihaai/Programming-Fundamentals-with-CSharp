using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            // All values are in kilograms
            const double kilo = 1000;

            var foodQ = double.Parse(Console.ReadLine());
            var hayQ = double.Parse(Console.ReadLine());
            var coverQ = double.Parse(Console.ReadLine());
            var pigWeightKG = double.Parse(Console.ReadLine());

            var foodGR = foodQ * kilo;
            var hayGR = hayQ * kilo;
            var coverGR = coverQ * kilo;
            var pigWeightGR = pigWeightKG * kilo;

            for (int i = 1; i <= 30; i++)
            {
                foodGR -= 300;

                if (i % 2 == 0)
                    hayGR -= foodGR * 0.05;

                if (i % 3 == 0)
                    coverGR -= pigWeightGR * 0.3333;
            }

            var foodKG = foodGR / kilo;
            var hayKG = hayGR / kilo;
            var coverKG = coverGR / kilo;

            if (foodKG <= 0 || hayKG <= 0 || coverKG <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }

            else if (foodKG >= 0 && hayKG >= 0 && coverKG >= 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKG:F2}, Hay: {hayKG:F2}, Cover: {coverKG:F2}.");
            }

        }
    }
}
