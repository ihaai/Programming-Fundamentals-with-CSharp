using System;

namespace _11._Math_operations
{
    class Program
    {
        static double CalculateResults(double a, string operation, double b)
        {
            if (operation == "/") return a / b;
            if (operation == "*") return a * b;
            if (operation == "+") return a + b;
            if (operation == "-") return a - b;
            else return 0;
        }

        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNUmber = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateResults(firstNumber, operation, secondNUmber));
        }
    }
}
