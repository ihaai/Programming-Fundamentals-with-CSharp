using System;

namespace _08._Math_Power
{
    class Program
    {
        static double PowerRaise(double numberToRaise, int power)
        {
            return Math.Pow(numberToRaise, power);
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerRaise(number, power));
        }
    }
}
