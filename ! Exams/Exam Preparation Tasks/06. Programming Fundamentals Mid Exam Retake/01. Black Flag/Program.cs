using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            var plunder_DaysOf = double.Parse(Console.ReadLine());
            var plunder_Daily = double.Parse(Console.ReadLine());
            var plunder_Expected = double.Parse(Console.ReadLine());
            var plunder_Gained = new double();

            for (int i = 1; i <= plunder_DaysOf; i++)
            {
                plunder_Gained += plunder_Daily;

                if (i % 3 == 0) // Every third day we do something...
                    plunder_Gained += (plunder_Daily * 0.5);

                if (i % 5 == 0) // Every fifth day we do something...
                    plunder_Gained -= (plunder_Gained * 0.3);
            }

            if (plunder_Gained >= plunder_Expected)
                Console.WriteLine($"Ahoy! {plunder_Gained:F2} plunder gained.");
            else if (plunder_Gained < plunder_Expected)
                Console.WriteLine($"Collected only {(plunder_Gained/plunder_Expected).ToString("0.00%"):F2} of the plunder.");
        }
    }
}
