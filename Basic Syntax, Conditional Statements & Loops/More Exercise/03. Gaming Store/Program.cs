using System;

namespace _03._Gaming_Store
{
    class Program
    {
        public const double OUTFALL4PRICE = 39.99;
        public const double CSOGPRICE = 15.99;
        public const double ZPLINTERZELLPRICE = 19.99;
        public const double HONORED2PRICE = 59.99;
        public const double ROVERWATCHPRICE = 29.99;
        public const double ROVERWATCHORIGINSPRICE = 39.99;

        static void Main(string[] args)
        {
            bool on = true;
            string keyWord = string.Empty;
            double totalSum = 0;

            double budget = double.Parse(Console.ReadLine());
            double tBudget = budget;

            while (on)
            {
                keyWord = Console.ReadLine();
                switch (keyWord)
                {
                    case "Game Time":
                        on = false;
                        break;


                    case "OutFall 4":
                        if (tBudget >= OUTFALL4PRICE)
                        {
                            tBudget -= OUTFALL4PRICE;
                            totalSum += OUTFALL4PRICE;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "CS: OG":
                        if (tBudget >= CSOGPRICE)
                        {
                            tBudget -= CSOGPRICE;
                            totalSum += CSOGPRICE;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (tBudget >= ROVERWATCHORIGINSPRICE)
                        {
                            tBudget -= ROVERWATCHORIGINSPRICE;
                            totalSum += ROVERWATCHORIGINSPRICE;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Honored 2":
                        if (tBudget >= HONORED2PRICE)
                        {
                            tBudget -= HONORED2PRICE;
                            totalSum += HONORED2PRICE;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        if (tBudget >= ZPLINTERZELLPRICE)
                        {
                            tBudget -= ZPLINTERZELLPRICE;
                            totalSum += ZPLINTERZELLPRICE;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch":
                        if (tBudget >= ROVERWATCHPRICE)
                        {
                            tBudget -= ROVERWATCHPRICE;
                            totalSum += ROVERWATCHPRICE;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }

            if (tBudget <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSum:F2}. Remaining: ${budget - totalSum:F2}");
            }
        }
    }
}
