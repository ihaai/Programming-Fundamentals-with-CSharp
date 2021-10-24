using System;
using System.Linq;
using System.Collections.Generic;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var tankNeededXP = double.Parse(Console.ReadLine());
            var battleCount = int.Parse(Console.ReadLine());
            int battleCntr = 0;
            var totalXPcollected = 0.00;

            for (int i = 1; i <= battleCount; i++)
            {
                battleCntr++;
                var xpPerBattle = double.Parse(Console.ReadLine());

                totalXPcollected += xpPerBattle;

                if (i % 3 == 0)
                {
                    totalXPcollected += xpPerBattle * 0.15;
                }
                if (i % 5 == 0)
                {
                    totalXPcollected -= xpPerBattle * 0.10;
                }
                if (i % 15 == 0)
                {
                    totalXPcollected += xpPerBattle * 0.05;
                }

                if (totalXPcollected >= tankNeededXP)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {battleCntr} battles.");
                    return;
                }
            }

            Console.WriteLine($"Player was not able to collect the needed experience, {tankNeededXP - totalXPcollected:F2} more needed.");
        }
    }
}
