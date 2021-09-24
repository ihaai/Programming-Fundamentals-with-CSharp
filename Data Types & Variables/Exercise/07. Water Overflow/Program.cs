using System;

namespace _07._Water_Overflow
{
    class Program
    {
        public const int capacity = 255;

        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int tank = 0;

            for (int i = 0; i < lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                tank += liters;
                if (tank > capacity)
                {
                    tank -= liters;
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(tank);
        }
    }
}
