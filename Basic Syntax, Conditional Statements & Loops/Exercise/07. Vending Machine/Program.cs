using System;

namespace _07._Vending_Machine
{
    class Program
    {
        public const double NutsPrice = 2.0;
        public const double WaterPrice = 0.7;
        public const double CrispsPrice = 1.5;
        public const double SodaPrice = 0.8;
        public const double CokePrice = 1.0;

        static void Main(string[] args)
        {
            string startCommand = string.Empty;
            string endCommand = string.Empty;
            double coinSum = 0;
            //double startCommand = 0;

            while (true)
            {
                startCommand = Console.ReadLine();
                if (startCommand == "Start")
                    break;

                if (startCommand != "0.1" && startCommand != "0.2" && startCommand != "0.5" && startCommand != "1" && startCommand != "2")
                    Console.WriteLine("Cannot accept " + startCommand);
                else
                    coinSum += Convert.ToDouble(startCommand);

            }

            while (true)
            {
                endCommand = Console.ReadLine();
                switch (endCommand)
                {
                    case "Nuts":
                        if (NutsPrice > coinSum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinSum -= NutsPrice;
                            Console.WriteLine($"Purchased nuts");
                        }
                        break;
                    case "Water":
                        if (WaterPrice > coinSum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinSum -= WaterPrice;
                            Console.WriteLine($"Purchased water");
                        }
                        break;
                    case "Crisps":
                        if (CrispsPrice > coinSum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinSum -= CrispsPrice;
                            Console.WriteLine($"Purchased crisps");
                        }
                        break;
                    case "Soda":
                        if (SodaPrice > coinSum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinSum -= SodaPrice;
                            Console.WriteLine($"Purchased soda");
                        }
                        break;
                    case "Coke":
                        if (CokePrice > coinSum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinSum -= CokePrice;
                            Console.WriteLine($"Purchased coke");
                        }
                        break;
                    case "End":
                        Console.WriteLine($"Change: {coinSum:F2}");
                        return;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
        }
    }
}
