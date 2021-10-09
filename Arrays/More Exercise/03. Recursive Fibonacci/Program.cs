using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Recursive_Fibonacci
{
    class Program
    {

        static long Fibanocci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            long Fn = Fibanocci(n - 1) + Fibanocci(n - 2); // <== Following the formula.
            return Fn;
        }


        static void Main(string[] args)
        {
            var fibanocciStorage = new List<long>();

            int endRange = int.Parse(Console.ReadLine());
            for (int i = 0; i <= endRange; i++)
            {
                fibanocciStorage.Add(Fibanocci(i));
            }

            Console.WriteLine(fibanocciStorage.Last());
        }
    }
}
