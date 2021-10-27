using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Factorials
    {
        public int N { get; set; }

        public Factorials(int startingPoint)
        {
            this.N = startingPoint;
        }

        public BigInteger CalculateFactorial()
        {
            BigInteger ourFactorial = 1;

            for (int i = 2; i <= N; i++)
            {
                ourFactorial *= i;
            }

            return ourFactorial;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());

            Factorials calculateF = new Factorials(startingNumber);

            Console.WriteLine(calculateF.CalculateFactorial());
        }
    }
}
