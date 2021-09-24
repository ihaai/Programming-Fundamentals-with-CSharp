using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < a; i++)
            {
                decimal r = decimal.Parse(Console.ReadLine());
                sum += r;
            }
            Console.WriteLine(sum);
        }
    }
}
