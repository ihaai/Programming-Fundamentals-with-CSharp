using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = 0;

            for (int currentGame = 1; currentGame <= gameLost; currentGame++)
            {
                if (currentGame % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                if (currentGame % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if (currentGame % 6 == 0)
                {
                    expenses += keyboardPrice;
                }
                if (currentGame % 12 == 0)
                {
                    expenses += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
