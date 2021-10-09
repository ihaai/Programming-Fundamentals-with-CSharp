using System;

namespace _03._Calculations
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Substract(double a, double b)
        {
            return a - b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            if (operation == "add")
            {
                Console.WriteLine(Add(number1, number2));
            }
            else if (operation == "multiply")
            {
                Console.WriteLine(Multiply(number1, number2));
            }
            else if (operation == "substract")
            {
                Console.WriteLine(Substract(number1, number2));
            }
            else if (operation == "divide")
            {
                Console.WriteLine(Divide(number1, number2));
            }
        }
    }
}
