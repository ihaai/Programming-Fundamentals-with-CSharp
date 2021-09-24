using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double priceForSaber = double.Parse(Console.ReadLine());
            double priceForRobe = double.Parse(Console.ReadLine());
            double priceForBelt = double.Parse(Console.ReadLine());

            double numOfSabers = (double)Math.Ceiling(studentsNumber * 1.10m);
            double numOfFreeBelts = (double)Math.Floor(studentsNumber / 6.0m);
            double finalPriceSabers = numOfSabers * priceForSaber;
            double finalPriceRobes = priceForRobe * studentsNumber;
            double finalPriceBelts = (studentsNumber - numOfFreeBelts) * priceForBelt;
            double totalPrice = finalPriceSabers + finalPriceRobes + finalPriceBelts;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalPrice - budget):F2}lv more.");
            }
        }
    }
}
