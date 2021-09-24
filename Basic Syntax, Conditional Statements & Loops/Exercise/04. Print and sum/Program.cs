using System;
using System.Collections.Generic;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> numCollector = new List<int>();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                numCollector.Add(i);
            }
            foreach (var listNum in numCollector)
            {
                sum += listNum;
            }
            Console.WriteLine(String.Join(" ", numCollector));
            Console.WriteLine("Sum: " + sum);
        }
    }
}
