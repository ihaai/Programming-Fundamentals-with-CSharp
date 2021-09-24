using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int gathered = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                gathered += startingYield - 26;
                startingYield -= 10;
                days++;
                if (startingYield < 100)
                {
                    gathered -= 26;
                }
            }

            Console.WriteLine(days);
            Console.WriteLine(gathered);
        }
    }
}
