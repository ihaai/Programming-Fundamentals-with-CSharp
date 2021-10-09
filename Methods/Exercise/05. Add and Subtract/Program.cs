using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Add(num1, num2) - num3);
        }
    }
}
