using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;


            switch (typeOfGroup)
            {
                case "Students":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 8.45 * countOfPeople;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 9.80 * countOfPeople;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 10.46 * countOfPeople;
                    }
                    if (countOfPeople >= 30)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Business":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 16;
                    }
                    if (countOfPeople >= 100)
                    {
                        price = price * (countOfPeople - 10);
                    }
                    else
                    {
                        price *= countOfPeople;
                    }
                    break;
                case "Regular":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 15 * countOfPeople;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 20 * countOfPeople;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 22.50 * countOfPeople;
                    }
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price -= price * 0.05;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
