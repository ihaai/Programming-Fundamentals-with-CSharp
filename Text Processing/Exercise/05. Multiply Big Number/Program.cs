using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();
            int multiplyWith = int.Parse(Console.ReadLine());
            int remainder = 0;

            if (input == "0" || multiplyWith == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(input[i].ToString());
                int resultFromCalculation = currentDigit * multiplyWith + remainder;
                int result = resultFromCalculation % 10;
                remainder = resultFromCalculation / 10;
                sb.Insert(0, result);
            }

            switch (remainder)
            {
                case 0: break;
                default: sb.Insert(0, remainder); break;
            }

            Console.WriteLine(sb);
        }
    }
}
