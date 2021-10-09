using System;

namespace _05._Orders
{
    class Program
    {
        public const double coffeePrice = 1.50;
        public const double waterPrice = 1.00;
        public const double cokePrice = 1.40;
        public const double snacksPrice = 2.00;

        static double TotalOrderPrice(string productType, double amount)
        {
            if (productType == "water") return waterPrice * amount;
            else if (productType == "coffee") return coffeePrice * amount;
            else if (productType == "coke") return cokePrice * amount;
            else if (productType == "snacks") return snacksPrice * amount;
            else return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{TotalOrderPrice(Console.ReadLine(), int.Parse(Console.ReadLine())):F2}");
        }
    }
}
